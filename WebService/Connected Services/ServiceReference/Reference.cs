﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTestData", ReplyAction="http://tempuri.org/IService1/GetTestDataResponse")]
        System.Xml.Linq.XElement GetTestData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTestData", ReplyAction="http://tempuri.org/IService1/GetTestDataResponse")]
        System.Threading.Tasks.Task<System.Xml.Linq.XElement> GetTestDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllInterchanges", ReplyAction="http://tempuri.org/IService1/GetAllInterchangesResponse")]
        System.Xml.Linq.XElement GetAllInterchanges();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllInterchanges", ReplyAction="http://tempuri.org/IService1/GetAllInterchangesResponse")]
        System.Threading.Tasks.Task<System.Xml.Linq.XElement> GetAllInterchangesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeID", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeIDResponse")]
        System.Xml.Linq.XElement FilterByInterchangeID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeID", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeIDResponse")]
        System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeNode", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeNodeResponse")]
        System.Xml.Linq.XElement FilterByInterchangeNode(string node);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeNode", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeNodeResponse")]
        System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeNodeAsync(string node);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeIDAndNode", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeIDAndNodeResponse")]
        System.Xml.Linq.XElement FilterByInterchangeIDAndNode(int id, string node);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeIDAndNode", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeIDAndNodeResponse")]
        System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeIDAndNodeAsync(int id, string node);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeNodeValue", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeNodeValueResponse")]
        System.Xml.Linq.XElement FilterByInterchangeNodeValue(string node, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FilterByInterchangeNodeValue", ReplyAction="http://tempuri.org/IService1/FilterByInterchangeNodeValueResponse")]
        System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeNodeValueAsync(string node, string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebService.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebService.ServiceReference.IService1>, WebService.ServiceReference.IService1 {
        
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
        
        public System.Xml.Linq.XElement GetTestData() {
            return base.Channel.GetTestData();
        }
        
        public System.Threading.Tasks.Task<System.Xml.Linq.XElement> GetTestDataAsync() {
            return base.Channel.GetTestDataAsync();
        }
        
        public System.Xml.Linq.XElement GetAllInterchanges() {
            return base.Channel.GetAllInterchanges();
        }
        
        public System.Threading.Tasks.Task<System.Xml.Linq.XElement> GetAllInterchangesAsync() {
            return base.Channel.GetAllInterchangesAsync();
        }
        
        public System.Xml.Linq.XElement FilterByInterchangeID(int id) {
            return base.Channel.FilterByInterchangeID(id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeIDAsync(int id) {
            return base.Channel.FilterByInterchangeIDAsync(id);
        }
        
        public System.Xml.Linq.XElement FilterByInterchangeNode(string node) {
            return base.Channel.FilterByInterchangeNode(node);
        }
        
        public System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeNodeAsync(string node) {
            return base.Channel.FilterByInterchangeNodeAsync(node);
        }
        
        public System.Xml.Linq.XElement FilterByInterchangeIDAndNode(int id, string node) {
            return base.Channel.FilterByInterchangeIDAndNode(id, node);
        }
        
        public System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeIDAndNodeAsync(int id, string node) {
            return base.Channel.FilterByInterchangeIDAndNodeAsync(id, node);
        }
        
        public System.Xml.Linq.XElement FilterByInterchangeNodeValue(string node, string value) {
            return base.Channel.FilterByInterchangeNodeValue(node, value);
        }
        
        public System.Threading.Tasks.Task<System.Xml.Linq.XElement> FilterByInterchangeNodeValueAsync(string node, string value) {
            return base.Channel.FilterByInterchangeNodeValueAsync(node, value);
        }
    }
}
