﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace WebAppDb2.WebRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetHelloOperationCompleted;
        
        private System.Threading.SendOrPostCallback TestMethodStrOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAddOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetJsonOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetImageScanResultOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetImageScanRawOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetScanOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::WebAppDb2.Properties.Settings.Default.WebAppDb2_WebRef_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetHelloCompletedEventHandler GetHelloCompleted;
        
        /// <remarks/>
        public event TestMethodStrCompletedEventHandler TestMethodStrCompleted;
        
        /// <remarks/>
        public event GetAddCompletedEventHandler GetAddCompleted;
        
        /// <remarks/>
        public event GetJsonCompletedEventHandler GetJsonCompleted;
        
        /// <remarks/>
        public event GetImageScanResultCompletedEventHandler GetImageScanResultCompleted;
        
        /// <remarks/>
        public event GetImageScanRawCompletedEventHandler GetImageScanRawCompleted;
        
        /// <remarks/>
        public event GetScanCompletedEventHandler GetScanCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetHello", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetHello() {
            object[] results = this.Invoke("GetHello", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetHelloAsync() {
            this.GetHelloAsync(null);
        }
        
        /// <remarks/>
        public void GetHelloAsync(object userState) {
            if ((this.GetHelloOperationCompleted == null)) {
                this.GetHelloOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHelloOperationCompleted);
            }
            this.InvokeAsync("GetHello", new object[0], this.GetHelloOperationCompleted, userState);
        }
        
        private void OnGetHelloOperationCompleted(object arg) {
            if ((this.GetHelloCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHelloCompleted(this, new GetHelloCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/TestMethodStr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string TestMethodStr(int i, [System.Xml.Serialization.XmlIgnoreAttribute()] bool iSpecified) {
            object[] results = this.Invoke("TestMethodStr", new object[] {
                        i,
                        iSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TestMethodStrAsync(int i, bool iSpecified) {
            this.TestMethodStrAsync(i, iSpecified, null);
        }
        
        /// <remarks/>
        public void TestMethodStrAsync(int i, bool iSpecified, object userState) {
            if ((this.TestMethodStrOperationCompleted == null)) {
                this.TestMethodStrOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTestMethodStrOperationCompleted);
            }
            this.InvokeAsync("TestMethodStr", new object[] {
                        i,
                        iSpecified}, this.TestMethodStrOperationCompleted, userState);
        }
        
        private void OnTestMethodStrOperationCompleted(object arg) {
            if ((this.TestMethodStrCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TestMethodStrCompleted(this, new TestMethodStrCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GetAdd(int a, [System.Xml.Serialization.XmlIgnoreAttribute()] bool aSpecified, int b, [System.Xml.Serialization.XmlIgnoreAttribute()] bool bSpecified, out int GetAddResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool GetAddResultSpecified) {
            object[] results = this.Invoke("GetAdd", new object[] {
                        a,
                        aSpecified,
                        b,
                        bSpecified});
            GetAddResult = ((int)(results[0]));
            GetAddResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void GetAddAsync(int a, bool aSpecified, int b, bool bSpecified) {
            this.GetAddAsync(a, aSpecified, b, bSpecified, null);
        }
        
        /// <remarks/>
        public void GetAddAsync(int a, bool aSpecified, int b, bool bSpecified, object userState) {
            if ((this.GetAddOperationCompleted == null)) {
                this.GetAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAddOperationCompleted);
            }
            this.InvokeAsync("GetAdd", new object[] {
                        a,
                        aSpecified,
                        b,
                        bSpecified}, this.GetAddOperationCompleted, userState);
        }
        
        private void OnGetAddOperationCompleted(object arg) {
            if ((this.GetAddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAddCompleted(this, new GetAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetJson", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetJson() {
            object[] results = this.Invoke("GetJson", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetJsonAsync() {
            this.GetJsonAsync(null);
        }
        
        /// <remarks/>
        public void GetJsonAsync(object userState) {
            if ((this.GetJsonOperationCompleted == null)) {
                this.GetJsonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetJsonOperationCompleted);
            }
            this.InvokeAsync("GetJson", new object[0], this.GetJsonOperationCompleted, userState);
        }
        
        private void OnGetJsonOperationCompleted(object arg) {
            if ((this.GetJsonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetJsonCompleted(this, new GetJsonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetImageScanResult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetImageScanResult() {
            object[] results = this.Invoke("GetImageScanResult", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetImageScanResultAsync() {
            this.GetImageScanResultAsync(null);
        }
        
        /// <remarks/>
        public void GetImageScanResultAsync(object userState) {
            if ((this.GetImageScanResultOperationCompleted == null)) {
                this.GetImageScanResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImageScanResultOperationCompleted);
            }
            this.InvokeAsync("GetImageScanResult", new object[0], this.GetImageScanResultOperationCompleted, userState);
        }
        
        private void OnGetImageScanResultOperationCompleted(object arg) {
            if ((this.GetImageScanResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetImageScanResultCompleted(this, new GetImageScanResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetImageScanRaw", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetImageScanRaw() {
            object[] results = this.Invoke("GetImageScanRaw", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetImageScanRawAsync() {
            this.GetImageScanRawAsync(null);
        }
        
        /// <remarks/>
        public void GetImageScanRawAsync(object userState) {
            if ((this.GetImageScanRawOperationCompleted == null)) {
                this.GetImageScanRawOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImageScanRawOperationCompleted);
            }
            this.InvokeAsync("GetImageScanRaw", new object[0], this.GetImageScanRawOperationCompleted, userState);
        }
        
        private void OnGetImageScanRawOperationCompleted(object arg) {
            if ((this.GetImageScanRawCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetImageScanRawCompleted(this, new GetImageScanRawCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetScan", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetScan() {
            object[] results = this.Invoke("GetScan", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetScanAsync() {
            this.GetScanAsync(null);
        }
        
        /// <remarks/>
        public void GetScanAsync(object userState) {
            if ((this.GetScanOperationCompleted == null)) {
                this.GetScanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetScanOperationCompleted);
            }
            this.InvokeAsync("GetScan", new object[0], this.GetScanOperationCompleted, userState);
        }
        
        private void OnGetScanOperationCompleted(object arg) {
            if ((this.GetScanCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetScanCompleted(this, new GetScanCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetHelloCompletedEventHandler(object sender, GetHelloCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHelloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetHelloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void TestMethodStrCompletedEventHandler(object sender, TestMethodStrCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestMethodStrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TestMethodStrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetAddCompletedEventHandler(object sender, GetAddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int GetAddResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool GetAddResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetJsonCompletedEventHandler(object sender, GetJsonCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetJsonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetJsonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetImageScanResultCompletedEventHandler(object sender, GetImageScanResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetImageScanResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetImageScanResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetImageScanRawCompletedEventHandler(object sender, GetImageScanRawCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetImageScanRawCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetImageScanRawCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetScanCompletedEventHandler(object sender, GetScanCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetScanCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetScanCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591