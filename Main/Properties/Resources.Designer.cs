﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Main.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Ищет локализованную строку, похожую на A Group of Visits with the specified name\n\n {0}\n\nalready exists on the disk, do you want to overwrite the existing Group of Visits with a new one?.
        /// </summary>
        public static string dlgGroupExists {
            get {
                return ResourceManager.GetString("dlgGroupExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The Group of Visits and the Visit with the specified names\n\n {0}\n\n {1}\n\nalready exist on the disk, should you overwrite the existing Group of Visits and the Visit with new ones?.
        /// </summary>
        public static string dlgVisGrpExisis {
            get {
                return ResourceManager.GetString("dlgVisGrpExisis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на A Visit with the specified name\n\n{0}\n\nalready exists on disk,overwrite the existing Visit with a new one?.
        /// </summary>
        public static string dlgVisitExisis {
            get {
                return ResourceManager.GetString("dlgVisitExisis", resourceCulture);
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
        ///   Ищет локализованную строку, похожую на Add to current group of visits.
        /// </summary>
        public static string lblAddCurVis {
            get {
                return ResourceManager.GetString("lblAddCurVis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create a new visit group.
        /// </summary>
        public static string lblCreGrpVis {
            get {
                return ResourceManager.GetString("lblCreGrpVis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create single Visit.
        /// </summary>
        public static string lblCreSnglVisit {
            get {
                return ResourceManager.GetString("lblCreSnglVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enter Visit name.
        /// </summary>
        public static string lblEnterNameVisit {
            get {
                return ResourceManager.GetString("lblEnterNameVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The visit group name is empty or contains invalid characters.
        /// </summary>
        public static string lblErrNameGrpVisit {
            get {
                return ResourceManager.GetString("lblErrNameGrpVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The visit name is empty or contains invalid characters.
        /// </summary>
        public static string lblErrNameVisit {
            get {
                return ResourceManager.GetString("lblErrNameVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Group of visits.
        /// </summary>
        public static string lblGroupVisit {
            get {
                return ResourceManager.GetString("lblGroupVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на A group of visits and a visit in same directory.
        /// </summary>
        public static string lblGrpVisitSameDir {
            get {
                return ResourceManager.GetString("lblGrpVisitSameDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Name group of visits.
        /// </summary>
        public static string lblNameGrpVisit {
            get {
                return ResourceManager.GetString("lblNameGrpVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Visit name.
        /// </summary>
        public static string lblNameVisit {
            get {
                return ResourceManager.GetString("lblNameVisit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Placement.
        /// </summary>
        public static string lblPlacement {
            get {
                return ResourceManager.GetString("lblPlacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на You must select a location.
        /// </summary>
        public static string lblSelectPlase {
            get {
                return ResourceManager.GetString("lblSelectPlase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на You must select the name of the visit group.
        /// </summary>
        public static string lblSelNameGrpVis {
            get {
                return ResourceManager.GetString("lblSelNameGrpVis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на the visit will be created in:.
        /// </summary>
        public static string lblVisitGreateIn {
            get {
                return ResourceManager.GetString("lblVisitGreateIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на This directory is not empty.
        /// </summary>
        public static string lblWrnCatNotEmpty {
            get {
                return ResourceManager.GetString("lblWrnCatNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Clear.
        /// </summary>
        public static string m_Clear {
            get {
                return ResourceManager.GetString("m_Clear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Controll.
        /// </summary>
        public static string m_Controll {
            get {
                return ResourceManager.GetString("m_Controll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Debug windows.
        /// </summary>
        public static string m_Debugs {
            get {
                return ResourceManager.GetString("m_Debugs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File.
        /// </summary>
        public static string m_File {
            get {
                return ResourceManager.GetString("m_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Freeze.
        /// </summary>
        public static string m_Freeze {
            get {
                return ResourceManager.GetString("m_Freeze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Hidden windows.
        /// </summary>
        public static string m_Hidden {
            get {
                return ResourceManager.GetString("m_Hidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Info.
        /// </summary>
        public static string m_Info {
            get {
                return ResourceManager.GetString("m_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Metrology.
        /// </summary>
        public static string m_Metrology {
            get {
                return ResourceManager.GetString("m_Metrology", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Show window.
        /// </summary>
        public static string m_Show {
            get {
                return ResourceManager.GetString("m_Show", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Show all hidden windows.
        /// </summary>
        public static string m_ShowAll {
            get {
                return ResourceManager.GetString("m_ShowAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на MainWindow.
        /// </summary>
        public static string m_Title {
            get {
                return ResourceManager.GetString("m_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Trace.
        /// </summary>
        public static string m_Trace {
            get {
                return ResourceManager.GetString("m_Trace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Write.
        /// </summary>
        public static string m_Write {
            get {
                return ResourceManager.GetString("m_Write", resourceCulture);
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
        ///   Ищет локализованную строку, похожую на Add....
        /// </summary>
        public static string nfile_Add {
            get {
                return ResourceManager.GetString("nfile_Add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Add File....
        /// </summary>
        public static string nfile_Add_File {
            get {
                return ResourceManager.GetString("nfile_Add_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create visit....
        /// </summary>
        public static string nfile_Add_New_Project {
            get {
                return ResourceManager.GetString("nfile_Add_New_Project", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Add existing visit....
        /// </summary>
        public static string nfile_Add_Project {
            get {
                return ResourceManager.GetString("nfile_Add_Project", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Close .
        /// </summary>
        public static string nfile_Close {
            get {
                return ResourceManager.GetString("nfile_Close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CloseProject.
        /// </summary>
        public static string nfile_Close_Project {
            get {
                return ResourceManager.GetString("nfile_Close_Project", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Close all.
        /// </summary>
        public static string nfile_CloseAll {
            get {
                return ResourceManager.GetString("nfile_CloseAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create.
        /// </summary>
        public static string nfile_Create {
            get {
                return ResourceManager.GetString("nfile_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Visit or Group.
        /// </summary>
        public static string nfile_Flt_ALL {
            get {
                return ResourceManager.GetString("nfile_Flt_ALL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Last files.
        /// </summary>
        public static string nfile_last_Files {
            get {
                return ResourceManager.GetString("nfile_last_Files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Last visit or visits groups.
        /// </summary>
        public static string nfile_last_ProjectGroups {
            get {
                return ResourceManager.GetString("nfile_last_ProjectGroups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Last visits.
        /// </summary>
        public static string nfile_last_Projects {
            get {
                return ResourceManager.GetString("nfile_last_Projects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на nFile_New.
        /// </summary>
        public static string nFile_New {
            get {
                return ResourceManager.GetString("nFile_New", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Open.
        /// </summary>
        public static string nfile_Open {
            get {
                return ResourceManager.GetString("nfile_Open", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Open Visit or Group visits.
        /// </summary>
        public static string nfile_Open_ALL {
            get {
                return ResourceManager.GetString("nfile_Open_ALL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Open file....
        /// </summary>
        public static string nfile_Open_File {
            get {
                return ResourceManager.GetString("nfile_Open_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Open visits group....
        /// </summary>
        public static string nfile_Open_Group {
            get {
                return ResourceManager.GetString("nfile_Open_Group", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Open visit....
        /// </summary>
        public static string nfile_Open_Project {
            get {
                return ResourceManager.GetString("nfile_Open_Project", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Save {0}.
        /// </summary>
        public static string nfile_Save {
            get {
                return ResourceManager.GetString("nfile_Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Save all.
        /// </summary>
        public static string nfile_SaveAll {
            get {
                return ResourceManager.GetString("nfile_SaveAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Save {0} as....
        /// </summary>
        public static string nfile_SaveAS {
            get {
                return ResourceManager.GetString("nfile_SaveAS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на New Visit.
        /// </summary>
        public static string nProject_New {
            get {
                return ResourceManager.GetString("nProject_New", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на New Visit group.
        /// </summary>
        public static string nProjectGroup_New {
            get {
                return ResourceManager.GetString("nProjectGroup_New", resourceCulture);
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
        ///   Ищет локализованную строку, похожую на Not Save.
        /// </summary>
        public static string strNoSave {
            get {
                return ResourceManager.GetString("strNoSave", resourceCulture);
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
        ///   Ищет локализованную строку, похожую на Save.
        /// </summary>
        public static string strSave {
            get {
                return ResourceManager.GetString("strSave", resourceCulture);
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
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Exceptions Loggin.
        /// </summary>
        public static string strTitleExceptions {
            get {
                return ResourceManager.GetString("strTitleExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Visit.
        /// </summary>
        public static string tProject {
            get {
                return ResourceManager.GetString("tProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Projects explorer.
        /// </summary>
        public static string tProjectExplorer {
            get {
                return ResourceManager.GetString("tProjectExplorer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Visits Group.
        /// </summary>
        public static string tProjectGroup {
            get {
                return ResourceManager.GetString("tProjectGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Visits.
        /// </summary>
        public static string tProjects {
            get {
                return ResourceManager.GetString("tProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Trip.
        /// </summary>
        public static string tTrip {
            get {
                return ResourceManager.GetString("tTrip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Trips.
        /// </summary>
        public static string tTrips {
            get {
                return ResourceManager.GetString("tTrips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Create new visit.
        /// </summary>
        public static string wCreateVisitDialogLabel {
            get {
                return ResourceManager.GetString("wCreateVisitDialogLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Save current changes?.
        /// </summary>
        public static string wFileSaveDialogLabel {
            get {
                return ResourceManager.GetString("wFileSaveDialogLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Horizont drilling.
        /// </summary>
        public static string wFileSaveDialogTitle {
            get {
                return ResourceManager.GetString("wFileSaveDialogTitle", resourceCulture);
            }
        }
    }
}
