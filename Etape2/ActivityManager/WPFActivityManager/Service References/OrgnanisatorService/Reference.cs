﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFActivityManager.OrgnanisatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrgnanisatorService.IOrganisation")]
    public interface IOrganisation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrganisation/Hello", ReplyAction="http://tempuri.org/IOrganisation/HelloResponse")]
        string Hello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrganisation/Hello", ReplyAction="http://tempuri.org/IOrganisation/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrganisationChannel : WPFActivityManager.OrgnanisatorService.IOrganisation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrganisationClient : System.ServiceModel.ClientBase<WPFActivityManager.OrgnanisatorService.IOrganisation>, WPFActivityManager.OrgnanisatorService.IOrganisation {
        
        public OrganisationClient() {
        }
        
        public OrganisationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrganisationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrganisationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrganisationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Hello() {
            return base.Channel.Hello();
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync() {
            return base.Channel.HelloAsync();
        }
    }
}