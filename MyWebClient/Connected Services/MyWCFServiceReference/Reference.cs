﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebClient.MyWCFServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MyWebClient.MyWCFServiceReference.City))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MyWebClient.MyWCFServiceReference.Person))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MyWebClient.MyWCFServiceReference.Lecturer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MyWebClient.MyWCFServiceReference.Student))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class City : MyWebClient.MyWCFServiceReference.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MyWebClient.MyWCFServiceReference.Lecturer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MyWebClient.MyWCFServiceReference.Student))]
    public partial class Person : MyWebClient.MyWCFServiceReference.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyWebClient.MyWCFServiceReference.City CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelephoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyWebClient.MyWCFServiceReference.TelephonePrefix TelephonePrefixField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyWebClient.MyWCFServiceReference.City City {
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((this.TelephoneField.Equals(value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyWebClient.MyWCFServiceReference.TelephonePrefix TelephonePrefix {
            get {
                return this.TelephonePrefixField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephonePrefixField, value) != true)) {
                    this.TelephonePrefixField = value;
                    this.RaisePropertyChanged("TelephonePrefix");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lecturer", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Lecturer : MyWebClient.MyWCFServiceReference.Person {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Student : MyWebClient.MyWCFServiceReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SemesterField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Semester {
            get {
                return this.SemesterField;
            }
            set {
                if ((this.SemesterField.Equals(value) != true)) {
                    this.SemesterField = value;
                    this.RaisePropertyChanged("Semester");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelephonePrefix", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class TelephonePrefix : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrefixField;
        
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
        public string Prefix {
            get {
                return this.PrefixField;
            }
            set {
                if ((object.ReferenceEquals(this.PrefixField, value) != true)) {
                    this.PrefixField = value;
                    this.RaisePropertyChanged("Prefix");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="StudentList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="Student")]
    [System.SerializableAttribute()]
    public class StudentList : System.Collections.Generic.List<MyWebClient.MyWCFServiceReference.Student> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyWCFServiceReference.IMyWCFService")]
    public interface IMyWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWCFService/StudentSelectByID", ReplyAction="http://tempuri.org/IMyWCFService/StudentSelectByIDResponse")]
        MyWebClient.MyWCFServiceReference.Student StudentSelectByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWCFService/StudentSelectByID", ReplyAction="http://tempuri.org/IMyWCFService/StudentSelectByIDResponse")]
        System.Threading.Tasks.Task<MyWebClient.MyWCFServiceReference.Student> StudentSelectByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWCFService/StudentSelectAll", ReplyAction="http://tempuri.org/IMyWCFService/StudentSelectAllResponse")]
        MyWebClient.MyWCFServiceReference.StudentList StudentSelectAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWCFService/StudentSelectAll", ReplyAction="http://tempuri.org/IMyWCFService/StudentSelectAllResponse")]
        System.Threading.Tasks.Task<MyWebClient.MyWCFServiceReference.StudentList> StudentSelectAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWCFService/LecturerLogin", ReplyAction="http://tempuri.org/IMyWCFService/LecturerLoginResponse")]
        MyWebClient.MyWCFServiceReference.Lecturer LecturerLogin(string eMail, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWCFService/LecturerLogin", ReplyAction="http://tempuri.org/IMyWCFService/LecturerLoginResponse")]
        System.Threading.Tasks.Task<MyWebClient.MyWCFServiceReference.Lecturer> LecturerLoginAsync(string eMail, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyWCFServiceChannel : MyWebClient.MyWCFServiceReference.IMyWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWCFServiceClient : System.ServiceModel.ClientBase<MyWebClient.MyWCFServiceReference.IMyWCFService>, MyWebClient.MyWCFServiceReference.IMyWCFService {
        
        public MyWCFServiceClient() {
        }
        
        public MyWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyWebClient.MyWCFServiceReference.Student StudentSelectByID(int id) {
            return base.Channel.StudentSelectByID(id);
        }
        
        public System.Threading.Tasks.Task<MyWebClient.MyWCFServiceReference.Student> StudentSelectByIDAsync(int id) {
            return base.Channel.StudentSelectByIDAsync(id);
        }
        
        public MyWebClient.MyWCFServiceReference.StudentList StudentSelectAll() {
            return base.Channel.StudentSelectAll();
        }
        
        public System.Threading.Tasks.Task<MyWebClient.MyWCFServiceReference.StudentList> StudentSelectAllAsync() {
            return base.Channel.StudentSelectAllAsync();
        }
        
        public MyWebClient.MyWCFServiceReference.Lecturer LecturerLogin(string eMail, string password) {
            return base.Channel.LecturerLogin(eMail, password);
        }
        
        public System.Threading.Tasks.Task<MyWebClient.MyWCFServiceReference.Lecturer> LecturerLoginAsync(string eMail, string password) {
            return base.Channel.LecturerLoginAsync(eMail, password);
        }
    }
}
