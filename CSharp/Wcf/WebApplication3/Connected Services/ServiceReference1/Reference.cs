﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHello", ReplyAction="http://tempuri.org/IService1/GetHelloResponse")]
        string GetHello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHello", ReplyAction="http://tempuri.org/IService1/GetHelloResponse")]
        System.Threading.Tasks.Task<string> GetHelloAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestMethodStr", ReplyAction="http://tempuri.org/IService1/TestMethodStrResponse")]
        string TestMethodStr(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestMethodStr", ReplyAction="http://tempuri.org/IService1/TestMethodStrResponse")]
        System.Threading.Tasks.Task<string> TestMethodStrAsync(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAdd", ReplyAction="http://tempuri.org/IService1/GetAddResponse")]
        int GetAdd(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAdd", ReplyAction="http://tempuri.org/IService1/GetAddResponse")]
        System.Threading.Tasks.Task<int> GetAddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJson", ReplyAction="http://tempuri.org/IService1/GetJsonResponse")]
        string GetJson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJson", ReplyAction="http://tempuri.org/IService1/GetJsonResponse")]
        System.Threading.Tasks.Task<string> GetJsonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetImage", ReplyAction="http://tempuri.org/IService1/GetImageResponse")]
        string GetImage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetImage", ReplyAction="http://tempuri.org/IService1/GetImageResponse")]
        System.Threading.Tasks.Task<string> GetImageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetScan", ReplyAction="http://tempuri.org/IService1/GetScanResponse")]
        string GetScan();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetScan", ReplyAction="http://tempuri.org/IService1/GetScanResponse")]
        System.Threading.Tasks.Task<string> GetScanAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication3.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication3.ServiceReference1.IService1>, WebApplication3.ServiceReference1.IService1 {
        
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
        
        public string GetHello() {
            return base.Channel.GetHello();
        }
        
        public System.Threading.Tasks.Task<string> GetHelloAsync() {
            return base.Channel.GetHelloAsync();
        }
        
        public string TestMethodStr(int i) {
            return base.Channel.TestMethodStr(i);
        }
        
        public System.Threading.Tasks.Task<string> TestMethodStrAsync(int i) {
            return base.Channel.TestMethodStrAsync(i);
        }
        
        public int GetAdd(int a, int b) {
            return base.Channel.GetAdd(a, b);
        }
        
        public System.Threading.Tasks.Task<int> GetAddAsync(int a, int b) {
            return base.Channel.GetAddAsync(a, b);
        }
        
        public string GetJson() {
            return base.Channel.GetJson();
        }
        
        public System.Threading.Tasks.Task<string> GetJsonAsync() {
            return base.Channel.GetJsonAsync();
        }
        
        public string GetImage() {
            return base.Channel.GetImage();
        }
        
        public System.Threading.Tasks.Task<string> GetImageAsync() {
            return base.Channel.GetImageAsync();
        }
        
        public string GetScan() {
            return base.Channel.GetScan();
        }
        
        public System.Threading.Tasks.Task<string> GetScanAsync() {
            return base.Channel.GetScanAsync();
        }


    }
}
