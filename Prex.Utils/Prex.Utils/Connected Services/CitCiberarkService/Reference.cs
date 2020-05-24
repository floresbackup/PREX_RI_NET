﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prex.Utils.CitCiberarkService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://tempuri.org/", ConfigurationName="CitCiberarkService.AIMServiceSoap")]
    public interface AIMServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://tempuri.org/GetPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Prex.Utils.CitCiberarkService.PasswordResponse GetPassword(Prex.Utils.CitCiberarkService.PasswordRequest passwordWSRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://tempuri.org/GetPassword", ReplyAction="*")]
        System.Threading.Tasks.Task<Prex.Utils.CitCiberarkService.PasswordResponse> GetPasswordAsync(Prex.Utils.CitCiberarkService.PasswordRequest passwordWSRequest);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://tempuri.org/")]
    public partial class PasswordRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string appIDField;
        
        private string safeField;
        
        private string folderField;
        
        private string objectField;
        
        private string userNameField;
        
        private string addressField;
        
        private string databaseField;
        
        private string policyIDField;
        
        private string reasonField;
        
        private int connectionTimeoutField;
        
        private string queryField;
        
        private System.Nullable<PasswordQueryFormat> queryFormatField;
        
        private KeyAndValue[] attributesField;
        
        public PasswordRequest() {
            this.connectionTimeoutField = 30;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AppID {
            get {
                return this.appIDField;
            }
            set {
                this.appIDField = value;
                this.RaisePropertyChanged("AppID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Safe {
            get {
                return this.safeField;
            }
            set {
                this.safeField = value;
                this.RaisePropertyChanged("Safe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
                this.RaisePropertyChanged("Folder");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
                this.RaisePropertyChanged("Object");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Database {
            get {
                return this.databaseField;
            }
            set {
                this.databaseField = value;
                this.RaisePropertyChanged("Database");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string PolicyID {
            get {
                return this.policyIDField;
            }
            set {
                this.policyIDField = value;
                this.RaisePropertyChanged("PolicyID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
                this.RaisePropertyChanged("Reason");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        [System.ComponentModel.DefaultValueAttribute(30)]
        public int ConnectionTimeout {
            get {
                return this.connectionTimeoutField;
            }
            set {
                this.connectionTimeoutField = value;
                this.RaisePropertyChanged("ConnectionTimeout");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Query {
            get {
                return this.queryField;
            }
            set {
                this.queryField = value;
                this.RaisePropertyChanged("Query");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<PasswordQueryFormat> QueryFormat {
            get {
                return this.queryFormatField;
            }
            set {
                this.queryFormatField = value;
                this.RaisePropertyChanged("QueryFormat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=12)]
        public KeyAndValue[] Attributes {
            get {
                return this.attributesField;
            }
            set {
                this.attributesField = value;
                this.RaisePropertyChanged("Attributes");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://tempuri.org/")]
    public enum PasswordQueryFormat {
        
        /// <remarks/>
        Exact,
        
        /// <remarks/>
        Regexp,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://tempuri.org/")]
    public partial class KeyAndValue : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://tempuri.org/")]
    public partial class PasswordResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string contentField;
        
        private string userNameField;
        
        private string addressField;
        
        private string databaseField;
        
        private string policyIDField;
        
        private KeyAndValue[] propertiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("Content");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Database {
            get {
                return this.databaseField;
            }
            set {
                this.databaseField = value;
                this.RaisePropertyChanged("Database");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string PolicyID {
            get {
                return this.policyIDField;
            }
            set {
                this.policyIDField = value;
                this.RaisePropertyChanged("PolicyID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        public KeyAndValue[] Properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
                this.RaisePropertyChanged("Properties");
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
    public interface AIMServiceSoapChannel : Prex.Utils.CitCiberarkService.AIMServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AIMServiceSoapClient : System.ServiceModel.ClientBase<Prex.Utils.CitCiberarkService.AIMServiceSoap>, Prex.Utils.CitCiberarkService.AIMServiceSoap {
        
        public AIMServiceSoapClient() {
        }
        
        public AIMServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AIMServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AIMServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AIMServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Prex.Utils.CitCiberarkService.PasswordResponse GetPassword(Prex.Utils.CitCiberarkService.PasswordRequest passwordWSRequest) {
            return base.Channel.GetPassword(passwordWSRequest);
        }
        
        public System.Threading.Tasks.Task<Prex.Utils.CitCiberarkService.PasswordResponse> GetPasswordAsync(Prex.Utils.CitCiberarkService.PasswordRequest passwordWSRequest) {
            return base.Channel.GetPasswordAsync(passwordWSRequest);
        }
    }
}