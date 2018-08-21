﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivityManager.Test.ProxyActivityNS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Activity", Namespace="http://schemas.datacontract.org/2004/07/ActivityManager.DAL.ClientModel")]
    [System.SerializableAttribute()]
    public partial class Activity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdActivityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdSubActivityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LibelleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
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
        public string Adress {
            get {
                return this.AdressField;
            }
            set {
                if ((object.ReferenceEquals(this.AdressField, value) != true)) {
                    this.AdressField = value;
                    this.RaisePropertyChanged("Adress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdActivity {
            get {
                return this.IdActivityField;
            }
            set {
                if ((this.IdActivityField.Equals(value) != true)) {
                    this.IdActivityField = value;
                    this.RaisePropertyChanged("IdActivity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdSubActivity {
            get {
                return this.IdSubActivityField;
            }
            set {
                if ((this.IdSubActivityField.Equals(value) != true)) {
                    this.IdSubActivityField = value;
                    this.RaisePropertyChanged("IdSubActivity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Libelle {
            get {
                return this.LibelleField;
            }
            set {
                if ((object.ReferenceEquals(this.LibelleField, value) != true)) {
                    this.LibelleField = value;
                    this.RaisePropertyChanged("Libelle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Num {
            get {
                return this.NumField;
            }
            set {
                if ((this.NumField.Equals(value) != true)) {
                    this.NumField = value;
                    this.RaisePropertyChanged("Num");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityFaultContract", Namespace="http://schemas.datacontract.org/2004/07/ActivityManager.Services.Faults")]
    [System.SerializableAttribute()]
    public partial class ActivityFaultContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MethodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime RequestTimeField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Method {
            get {
                return this.MethodField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodField, value) != true)) {
                    this.MethodField = value;
                    this.RaisePropertyChanged("Method");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTime {
            get {
                return this.RequestTimeField;
            }
            set {
                if ((this.RequestTimeField.Equals(value) != true)) {
                    this.RequestTimeField = value;
                    this.RaisePropertyChanged("RequestTime");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.BestDev.be/ActivityManager", ConfigurationName="ProxyActivityNS.ActivityService")]
    public interface ActivityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.BestDev.be/ActivityManager/ActivityService/getActivities", ReplyAction="http://www.BestDev.be/ActivityManager/ActivityService/getActivitiesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ActivityManager.Test.ProxyActivityNS.ActivityFaultContract), Action="http://www.BestDev.be/ActivityManager/ActivityService/getActivitiesActivityFaultC" +
            "ontractFault", Name="ActivityFaultContract", Namespace="http://schemas.datacontract.org/2004/07/ActivityManager.Services.Faults")]
        System.Collections.Generic.List<ActivityManager.Test.ProxyActivityNS.Activity> getActivities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.BestDev.be/ActivityManager/ActivityService/getActivitiesOnDate", ReplyAction="http://www.BestDev.be/ActivityManager/ActivityService/getActivitiesOnDateResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(ActivityManager.Test.ProxyActivityNS.ActivityFaultContract), Action="http://www.BestDev.be/ActivityManager/ActivityService/getActivitiesOnDateActivity" +
            "FaultContractFault", Name="ActivityFaultContract", Namespace="http://schemas.datacontract.org/2004/07/ActivityManager.Services.Faults")]
        System.Collections.Generic.List<ActivityManager.Test.ProxyActivityNS.Activity> getActivitiesOnDate(System.DateTime TheDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ActivityServiceChannel : ActivityManager.Test.ProxyActivityNS.ActivityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ActivityServiceClient : System.ServiceModel.ClientBase<ActivityManager.Test.ProxyActivityNS.ActivityService>, ActivityManager.Test.ProxyActivityNS.ActivityService {
        
        public ActivityServiceClient() {
        }
        
        public ActivityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ActivityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActivityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActivityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ActivityManager.Test.ProxyActivityNS.Activity> getActivities() {
            return base.Channel.getActivities();
        }
        
        public System.Collections.Generic.List<ActivityManager.Test.ProxyActivityNS.Activity> getActivitiesOnDate(System.DateTime TheDate) {
            return base.Channel.getActivitiesOnDate(TheDate);
        }
    }
}