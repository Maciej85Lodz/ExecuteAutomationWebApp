﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExecuteAutoEmployee.PFServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/PFServiceClient")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DurationWorkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GradeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float SalaryField;
        
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
        public int DurationWorked {
            get {
                return this.DurationWorkedField;
            }
            set {
                if ((this.DurationWorkedField.Equals(value) != true)) {
                    this.DurationWorkedField = value;
                    this.RaisePropertyChanged("DurationWorked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((this.GradeField.Equals(value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PFServiceClient.IPFService")]
    public interface IPFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/IsPfEligible", ReplyAction="http://tempuri.org/IPFService/IsPfEligibleResponse")]
        bool IsPfEligible(ExecuteAutoEmployee.PFServiceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/IsPfEligible", ReplyAction="http://tempuri.org/IPFService/IsPfEligibleResponse")]
        System.Threading.Tasks.Task<bool> IsPfEligibleAsync(ExecuteAutoEmployee.PFServiceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployeeContribSofar", ReplyAction="http://tempuri.org/IPFService/GetPfEmployeeContribSofarResponse")]
        System.Nullable<double> GetPfEmployeeContribSofar(ExecuteAutoEmployee.PFServiceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployeeContribSofar", ReplyAction="http://tempuri.org/IPFService/GetPfEmployeeContribSofarResponse")]
        System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployeeContribSofarAsync(ExecuteAutoEmployee.PFServiceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployerContribSofar", ReplyAction="http://tempuri.org/IPFService/GetPfEmployerContribSofarResponse")]
        System.Nullable<double> GetPfEmployerContribSofar(ExecuteAutoEmployee.PFServiceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployerContribSofar", ReplyAction="http://tempuri.org/IPFService/GetPfEmployerContribSofarResponse")]
        System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployerContribSofarAsync(ExecuteAutoEmployee.PFServiceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/IsPfEligibleWithId", ReplyAction="http://tempuri.org/IPFService/IsPfEligibleWithIdResponse")]
        bool IsPfEligibleWithId(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/IsPfEligibleWithId", ReplyAction="http://tempuri.org/IPFService/IsPfEligibleWithIdResponse")]
        System.Threading.Tasks.Task<bool> IsPfEligibleWithIdAsync(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployerControlSofarWithId", ReplyAction="http://tempuri.org/IPFService/GetPfEmployerControlSofarWithIdResponse")]
        System.Nullable<double> GetPfEmployerControlSofarWithId(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployerControlSofarWithId", ReplyAction="http://tempuri.org/IPFService/GetPfEmployerControlSofarWithIdResponse")]
        System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployerControlSofarWithIdAsync(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployeeControlSofarWithId", ReplyAction="http://tempuri.org/IPFService/GetPfEmployeeControlSofarWithIdResponse")]
        System.Nullable<double> GetPfEmployeeControlSofarWithId(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPFService/GetPfEmployeeControlSofarWithId", ReplyAction="http://tempuri.org/IPFService/GetPfEmployeeControlSofarWithIdResponse")]
        System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployeeControlSofarWithIdAsync(int empId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPFServiceChannel : ExecuteAutoEmployee.PFServiceClient.IPFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PFServiceClient : System.ServiceModel.ClientBase<ExecuteAutoEmployee.PFServiceClient.IPFService>, ExecuteAutoEmployee.PFServiceClient.IPFService {
        
        public PFServiceClient() {
        }
        
        public PFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsPfEligible(ExecuteAutoEmployee.PFServiceClient.Employee employee) {
            return base.Channel.IsPfEligible(employee);
        }
        
        public System.Threading.Tasks.Task<bool> IsPfEligibleAsync(ExecuteAutoEmployee.PFServiceClient.Employee employee) {
            return base.Channel.IsPfEligibleAsync(employee);
        }
        
        public System.Nullable<double> GetPfEmployeeContribSofar(ExecuteAutoEmployee.PFServiceClient.Employee employee) {
            return base.Channel.GetPfEmployeeContribSofar(employee);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployeeContribSofarAsync(ExecuteAutoEmployee.PFServiceClient.Employee employee) {
            return base.Channel.GetPfEmployeeContribSofarAsync(employee);
        }
        
        public System.Nullable<double> GetPfEmployerContribSofar(ExecuteAutoEmployee.PFServiceClient.Employee employee) {
            return base.Channel.GetPfEmployerContribSofar(employee);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployerContribSofarAsync(ExecuteAutoEmployee.PFServiceClient.Employee employee) {
            return base.Channel.GetPfEmployerContribSofarAsync(employee);
        }
        
        public bool IsPfEligibleWithId(int empId) {
            return base.Channel.IsPfEligibleWithId(empId);
        }
        
        public System.Threading.Tasks.Task<bool> IsPfEligibleWithIdAsync(int empId) {
            return base.Channel.IsPfEligibleWithIdAsync(empId);
        }
        
        public System.Nullable<double> GetPfEmployerControlSofarWithId(int empId) {
            return base.Channel.GetPfEmployerControlSofarWithId(empId);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployerControlSofarWithIdAsync(int empId) {
            return base.Channel.GetPfEmployerControlSofarWithIdAsync(empId);
        }
        
        public System.Nullable<double> GetPfEmployeeControlSofarWithId(int empId) {
            return base.Channel.GetPfEmployeeControlSofarWithId(empId);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<double>> GetPfEmployeeControlSofarWithIdAsync(int empId) {
            return base.Channel.GetPfEmployeeControlSofarWithIdAsync(empId);
        }
    }
}
