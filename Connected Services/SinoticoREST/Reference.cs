﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TessituraCleaners.SinoticoREST {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alarms", Namespace="http://schemas.datacontract.org/2004/07/MyTestWebService")]
    [System.SerializableAttribute()]
    public partial class Alarms : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MachineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProgNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShiftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string End {
            get {
                return this.EndField;
            }
            set {
                if ((object.ReferenceEquals(this.EndField, value) != true)) {
                    this.EndField = value;
                    this.RaisePropertyChanged("End");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Machine {
            get {
                return this.MachineField;
            }
            set {
                if ((object.ReferenceEquals(this.MachineField, value) != true)) {
                    this.MachineField = value;
                    this.RaisePropertyChanged("Machine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Note {
            get {
                return this.NoteField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteField, value) != true)) {
                    this.NoteField = value;
                    this.RaisePropertyChanged("Note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operator {
            get {
                return this.OperatorField;
            }
            set {
                if ((object.ReferenceEquals(this.OperatorField, value) != true)) {
                    this.OperatorField = value;
                    this.RaisePropertyChanged("Operator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProgNr {
            get {
                return this.ProgNrField;
            }
            set {
                if ((object.ReferenceEquals(this.ProgNrField, value) != true)) {
                    this.ProgNrField = value;
                    this.RaisePropertyChanged("ProgNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Shift {
            get {
                return this.ShiftField;
            }
            set {
                if ((object.ReferenceEquals(this.ShiftField, value) != true)) {
                    this.ShiftField = value;
                    this.RaisePropertyChanged("Shift");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Start {
            get {
                return this.StartField;
            }
            set {
                if ((object.ReferenceEquals(this.StartField, value) != true)) {
                    this.StartField = value;
                    this.RaisePropertyChanged("Start");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SinoticoREST.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAlarms", ReplyAction="http://tempuri.org/IService1/GetAlarmsResponse")]
        TessituraCleaners.SinoticoREST.Alarms[] GetAlarms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAlarms", ReplyAction="http://tempuri.org/IService1/GetAlarmsResponse")]
        System.Threading.Tasks.Task<TessituraCleaners.SinoticoREST.Alarms[]> GetAlarmsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadAll", ReplyAction="http://tempuri.org/IService1/LoadAllResponse")]
        void LoadAll(System.Data.DataTable dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadAll", ReplyAction="http://tempuri.org/IService1/LoadAllResponse")]
        System.Threading.Tasks.Task LoadAllAsync(System.Data.DataTable dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOperatorName", ReplyAction="http://tempuri.org/IService1/GetOperatorNameResponse")]
        string GetOperatorName(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOperatorName", ReplyAction="http://tempuri.org/IService1/GetOperatorNameResponse")]
        System.Threading.Tasks.Task<string> GetOperatorNameAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProgressiveNumber", ReplyAction="http://tempuri.org/IService1/GetProgressiveNumberResponse")]
        int GetProgressiveNumber(System.DateTime evDate, string cShift, int mac, string operatorx, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProgressiveNumber", ReplyAction="http://tempuri.org/IService1/GetProgressiveNumberResponse")]
        System.Threading.Tasks.Task<int> GetProgressiveNumberAsync(System.DateTime evDate, string cShift, int mac, string operatorx, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertNewOperation", ReplyAction="http://tempuri.org/IService1/InsertNewOperationResponse")]
        void InsertNewOperation(System.DateTime evDate, string cShift, string operatorName, System.DateTime cStart, System.DateTime cEnd, int machine, string reason, string cType, string note, System.DateTime dateLoad, int progNum, int tempoMin, string ptPrec);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertNewOperation", ReplyAction="http://tempuri.org/IService1/InsertNewOperationResponse")]
        System.Threading.Tasks.Task InsertNewOperationAsync(System.DateTime evDate, string cShift, string operatorName, System.DateTime cStart, System.DateTime cEnd, int machine, string reason, string cType, string note, System.DateTime dateLoad, int progNum, int tempoMin, string ptPrec);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateOperation", ReplyAction="http://tempuri.org/IService1/UpdateOperationResponse")]
        void UpdateOperation(System.DateTime endclean, long id, string note, int timeStamp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateOperation", ReplyAction="http://tempuri.org/IService1/UpdateOperationResponse")]
        System.Threading.Tasks.Task UpdateOperationAsync(System.DateTime endclean, long id, string note, int timeStamp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJobId", ReplyAction="http://tempuri.org/IService1/GetJobIdResponse")]
        long GetJobId();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJobId", ReplyAction="http://tempuri.org/IService1/GetJobIdResponse")]
        System.Threading.Tasks.Task<long> GetJobIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTimeStampInMM", ReplyAction="http://tempuri.org/IService1/GetTimeStampInMMResponse")]
        int GetTimeStampInMM(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTimeStampInMM", ReplyAction="http://tempuri.org/IService1/GetTimeStampInMMResponse")]
        System.Threading.Tasks.Task<int> GetTimeStampInMMAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShift", ReplyAction="http://tempuri.org/IService1/GetShiftResponse")]
        string GetShift();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetShift", ReplyAction="http://tempuri.org/IService1/GetShiftResponse")]
        System.Threading.Tasks.Task<string> GetShiftAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HasError", ReplyAction="http://tempuri.org/IService1/HasErrorResponse")]
        bool HasError();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HasError", ReplyAction="http://tempuri.org/IService1/HasErrorResponse")]
        System.Threading.Tasks.Task<bool> HasErrorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActivateAlarm", ReplyAction="http://tempuri.org/IService1/ActivateAlarmResponse")]
        void ActivateAlarm(long id, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActivateAlarm", ReplyAction="http://tempuri.org/IService1/ActivateAlarmResponse")]
        System.Threading.Tasks.Task ActivateAlarmAsync(long id, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeactivateAlarm", ReplyAction="http://tempuri.org/IService1/DeactivateAlarmResponse")]
        void DeactivateAlarm(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeactivateAlarm", ReplyAction="http://tempuri.org/IService1/DeactivateAlarmResponse")]
        System.Threading.Tasks.Task DeactivateAlarmAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TessituraCleaners.SinoticoREST.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TessituraCleaners.SinoticoREST.IService1>, TessituraCleaners.SinoticoREST.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TessituraCleaners.SinoticoREST.Alarms[] GetAlarms() {
            return base.Channel.GetAlarms();
        }
        
        public System.Threading.Tasks.Task<TessituraCleaners.SinoticoREST.Alarms[]> GetAlarmsAsync() {
            return base.Channel.GetAlarmsAsync();
        }
        
        public void LoadAll(System.Data.DataTable dt) {
            base.Channel.LoadAll(dt);
        }
        
        public System.Threading.Tasks.Task LoadAllAsync(System.Data.DataTable dt) {
            return base.Channel.LoadAllAsync(dt);
        }
        
        public string GetOperatorName(string code) {
            return base.Channel.GetOperatorName(code);
        }
        
        public System.Threading.Tasks.Task<string> GetOperatorNameAsync(string code) {
            return base.Channel.GetOperatorNameAsync(code);
        }
        
        public int GetProgressiveNumber(System.DateTime evDate, string cShift, int mac, string operatorx, string type) {
            return base.Channel.GetProgressiveNumber(evDate, cShift, mac, operatorx, type);
        }
        
        public System.Threading.Tasks.Task<int> GetProgressiveNumberAsync(System.DateTime evDate, string cShift, int mac, string operatorx, string type) {
            return base.Channel.GetProgressiveNumberAsync(evDate, cShift, mac, operatorx, type);
        }
        
        public void InsertNewOperation(System.DateTime evDate, string cShift, string operatorName, System.DateTime cStart, System.DateTime cEnd, int machine, string reason, string cType, string note, System.DateTime dateLoad, int progNum, int tempoMin, string ptPrec) {
            base.Channel.InsertNewOperation(evDate, cShift, operatorName, cStart, cEnd, machine, reason, cType, note, dateLoad, progNum, tempoMin, ptPrec);
        }
        
        public System.Threading.Tasks.Task InsertNewOperationAsync(System.DateTime evDate, string cShift, string operatorName, System.DateTime cStart, System.DateTime cEnd, int machine, string reason, string cType, string note, System.DateTime dateLoad, int progNum, int tempoMin, string ptPrec) {
            return base.Channel.InsertNewOperationAsync(evDate, cShift, operatorName, cStart, cEnd, machine, reason, cType, note, dateLoad, progNum, tempoMin, ptPrec);
        }
        
        public void UpdateOperation(System.DateTime endclean, long id, string note, int timeStamp) {
            base.Channel.UpdateOperation(endclean, id, note, timeStamp);
        }
        
        public System.Threading.Tasks.Task UpdateOperationAsync(System.DateTime endclean, long id, string note, int timeStamp) {
            return base.Channel.UpdateOperationAsync(endclean, id, note, timeStamp);
        }
        
        public long GetJobId() {
            return base.Channel.GetJobId();
        }
        
        public System.Threading.Tasks.Task<long> GetJobIdAsync() {
            return base.Channel.GetJobIdAsync();
        }
        
        public int GetTimeStampInMM(System.DateTime start, System.DateTime end) {
            return base.Channel.GetTimeStampInMM(start, end);
        }
        
        public System.Threading.Tasks.Task<int> GetTimeStampInMMAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.GetTimeStampInMMAsync(start, end);
        }
        
        public string GetShift() {
            return base.Channel.GetShift();
        }
        
        public System.Threading.Tasks.Task<string> GetShiftAsync() {
            return base.Channel.GetShiftAsync();
        }
        
        public bool HasError() {
            return base.Channel.HasError();
        }
        
        public System.Threading.Tasks.Task<bool> HasErrorAsync() {
            return base.Channel.HasErrorAsync();
        }
        
        public void ActivateAlarm(long id, string note) {
            base.Channel.ActivateAlarm(id, note);
        }
        
        public System.Threading.Tasks.Task ActivateAlarmAsync(long id, string note) {
            return base.Channel.ActivateAlarmAsync(id, note);
        }
        
        public void DeactivateAlarm(long id) {
            base.Channel.DeactivateAlarm(id);
        }
        
        public System.Threading.Tasks.Task DeactivateAlarmAsync(long id) {
            return base.Channel.DeactivateAlarmAsync(id);
        }
    }
}
