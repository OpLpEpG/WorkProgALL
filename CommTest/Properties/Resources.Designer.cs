﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerialPortTest.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SerialPortTest.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Delete file.
        /// </summary>
        public static string cptDeleteFile {
            get {
                return ResourceManager.GetString("cptDeleteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Total.
        /// </summary>
        public static string cptTotal {
            get {
                return ResourceManager.GetString("cptTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File can not be appended  data begin: {0} data end: {1}  data append from {2}.
        /// </summary>
        public static string errAppendFromBad {
            get {
                return ResourceManager.GetString("errAppendFromBad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Can not append not exisis file {0}.
        /// </summary>
        public static string errAppendNotExistsFile {
            get {
                return ResourceManager.GetString("errAppendNotExistsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на connection: {0} is locked for data exchage.
        /// </summary>
        public static string errConnectionLocked {
            get {
                return ResourceManager.GetString("errConnectionLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error reading EEPROM. Maximum packet length: 255.
        /// </summary>
        public static string errEEPread {
            get {
                return ResourceManager.GetString("errEEPread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error writing EEPROM. Maximum packet length: 255.
        /// </summary>
        public static string errEEPWrite {
            get {
                return ResourceManager.GetString("errEEPWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на From {0} bigger total {1}.
        /// </summary>
        public static string errFromBiggeTotal {
            get {
                return ResourceManager.GetString("errFromBiggeTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Delete file? {0}, all data mast bee lost.
        /// </summary>
        public static string msgDeleteFile {
            get {
                return ResourceManager.GetString("msgDeleteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Total {0} bigger SSD size {1}.
        /// </summary>
        public static string msgTotalBiggeSSD {
            get {
                return ResourceManager.GetString("msgTotalBiggeSSD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Position in file.
        /// </summary>
        public static string prmFilePos {
            get {
                return ResourceManager.GetString("prmFilePos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на From.
        /// </summary>
        public static string prmFrom {
            get {
                return ResourceManager.GetString("prmFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Option: Append.
        /// </summary>
        public static string prmOptAppend {
            get {
                return ResourceManager.GetString("prmOptAppend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Cancel.
        /// </summary>
        public static string strCancel {
            get {
                return ResourceManager.GetString("strCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на data length.
        /// </summary>
        public static string strDataLen {
            get {
                return ResourceManager.GetString("strDataLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Reading EEPROM.
        /// </summary>
        public static string strEEPRead {
            get {
                return ResourceManager.GetString("strEEPRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Writing EEPROM.
        /// </summary>
        public static string strEEPWrite {
            get {
                return ResourceManager.GetString("strEEPWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Metadata error .
        /// </summary>
        public static string strErrMetadata {
            get {
                return ResourceManager.GetString("strErrMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error.
        /// </summary>
        public static string strError {
            get {
                return ResourceManager.GetString("strError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на maximum data length.
        /// </summary>
        public static string strMaxDataLen {
            get {
                return ResourceManager.GetString("strMaxDataLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на packet length.
        /// </summary>
        public static string strPacketLen {
            get {
                return ResourceManager.GetString("strPacketLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Reading metadata.
        /// </summary>
        public static string strReadMetaData {
            get {
                return ResourceManager.GetString("strReadMetaData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Reading memory.
        /// </summary>
        public static string strReadRam {
            get {
                return ResourceManager.GetString("strReadRam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Reading memory {0} terminated.
        /// </summary>
        public static string strReadRamCancel {
            get {
                return ResourceManager.GetString("strReadRamCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Timeout.
        /// </summary>
        public static string strTimeout {
            get {
                return ResourceManager.GetString("strTimeout", resourceCulture);
            }
        }
    }
}