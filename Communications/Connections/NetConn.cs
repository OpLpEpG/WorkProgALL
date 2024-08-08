﻿using Connections.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Connections
{
    public class NetConn : AbstractConnection, INetConnection, IDisposable
    {
        private string host;
        private int port;
        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private Thread? netThread;

        static NetConn()
        {
            _ConnectionTypes.Add(typeof(NetConn));
        }
        public override string? ToString()
        {
            return $"{Host}:{Port}";
        }

        public NetConn() : base()
        {
            host = "192.168.4.1";
            port = 5000;
        }
        public string Host
        {
            get => host;
            set
            {
                if (IsOpen) throw new Exception("errror");
                host = value;
            }
        }
        public int Port
        {
            get => port;
            set
            {
                if (IsOpen) throw new Exception("errror");
                port = value;
            }
        }
        public override bool IsOpen { get { return socket.Connected; } }
        public override Task Close(int timout = 5000)
        {
            socket.Close();
            if (netThread != null && Ctsreadthread != null)
            {
                Ctsreadthread?.Cancel();
                while (netThread.IsAlive && --timout > 0) Thread.Sleep(1);
                netThread = null;
            }
            return base.Close(timout);
        }
        public override Task Open(int timout)
        {
            return Task.Run(async () =>
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                using (Cts = new CancellationTokenSource())
                {
                    try
                    {
                        await base.Open(timout);

                        if (netThread == null)
                        {
                            netThread = new Thread(() => NetReadThread(Ctsreadthread!.Token));
                            netThread.Name = "====netThread====";
                            netThread.IsBackground = true;
                            netThread.Start();
                        }

                        await socket.ConnectAsync(host, port, Cts.Token);
                    }
                    finally
                    {
                        Cts = null;
                        if (!socket.Connected) socket.Close();
                    }
                }
            });
        }
        protected override Task Send(DataReq dataReq)
        {
            return Task.Run(async () =>
            {
                using (Cts = new CancellationTokenSource(dataReq.timout))
                {
                    try
                    {
                        await socket.SendAsync(new ArraySegment<byte>(dataReq.txBuf), SocketFlags.None, Cts.Token);
                    }
                    finally
                    {
                        Cts = null;
                    }
                }
            });
        }
        private bool IsDisposed
        {
            get
            {
                try
                {
                    var r = socket.RemoteEndPoint;
                    return false;
                }
                catch (ObjectDisposedException)
                {
                    return true;
                }
            }
        }
        private async void NetReadThread(CancellationToken tok)
        {
            while (true)
            {
                try
                {
                    if (tok.IsCancellationRequested) return;
                    int cntin = currenRq != null ? currenRq.rxCount : rxBuf.Length;
                    if (!socket.Connected || !IsReading || cntin <= 0)
                    {
                        continue;
                    }
                    try
                    {
                        int cntout = 0;
                        var cnt = cntin - offset;
                        if (cnt == 0)
                        {
                            logger?.LogInformation("CNT = 0 !!!");
                            continue;
                        }
                        var m = new Memory<byte>(rxBuf, offset, cnt);
                        while (socket.Connected && cntout == 0)
                        {
                            cntout = await socket.ReceiveAsync(m, SocketFlags.None, Cts != null ? Cts.Token : default);
                        }
                        if (cntout + offset > rxBuf.Length) { throw new Exception("Buffer OverFlow"); }
                        if (Cts != null && Cts.IsCancellationRequested)
                        {
                            IsReading = false;
                            continue;
                        }
                        lock (_lock)
                        {
                            oldOffset = offset;
                            offset += cntout;
                        }

                        if (offset >= cntin)
                        {
                            IsReading = false;
                            logger?.LogInformation("IsReading END: {cnt} {off}", cntout, offset);
                        }
                        rxRowEvent.Set();
                        // App.logger?.LogTrace("I:{cnt} {off}", cntout, offset);
                    }
                    catch (Exception e)
                    {
                        logger?.LogInformation($"ERR {Thread.CurrentThread.ManagedThreadId} {dbg} {e}");
                    }
                }
                catch (Exception e)
                {
                    logger?.LogError(e.Message, e);
                }
            }

        }
    }
}
