﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebApplication1.ServicioVenta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicioPntoVetaSoap", Namespace="http://tempuri.org/")]
    public partial class ServicioPntoVeta : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarProductoEOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarPuntoVentaEOperationCompleted;
        
        private System.Threading.SendOrPostCallback FacturaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServicioPntoVeta() {
            this.Url = global::WebApplication1.Properties.Settings.Default.WebApplication1_ServicioVenta_ServicioPntoVeta;
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
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event ListarProductoECompletedEventHandler ListarProductoECompleted;
        
        /// <remarks/>
        public event ListarPuntoVentaECompletedEventHandler ListarPuntoVentaECompleted;
        
        /// <remarks/>
        public event FacturaCompletedEventHandler FacturaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarProductoE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductoModels[] ListarProductoE() {
            object[] results = this.Invoke("ListarProductoE", new object[0]);
            return ((ProductoModels[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarProductoEAsync() {
            this.ListarProductoEAsync(null);
        }
        
        /// <remarks/>
        public void ListarProductoEAsync(object userState) {
            if ((this.ListarProductoEOperationCompleted == null)) {
                this.ListarProductoEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarProductoEOperationCompleted);
            }
            this.InvokeAsync("ListarProductoE", new object[0], this.ListarProductoEOperationCompleted, userState);
        }
        
        private void OnListarProductoEOperationCompleted(object arg) {
            if ((this.ListarProductoECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarProductoECompleted(this, new ListarProductoECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarPuntoVentaE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public PuntoVentaModels[] ListarPuntoVentaE() {
            object[] results = this.Invoke("ListarPuntoVentaE", new object[0]);
            return ((PuntoVentaModels[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarPuntoVentaEAsync() {
            this.ListarPuntoVentaEAsync(null);
        }
        
        /// <remarks/>
        public void ListarPuntoVentaEAsync(object userState) {
            if ((this.ListarPuntoVentaEOperationCompleted == null)) {
                this.ListarPuntoVentaEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarPuntoVentaEOperationCompleted);
            }
            this.InvokeAsync("ListarPuntoVentaE", new object[0], this.ListarPuntoVentaEOperationCompleted, userState);
        }
        
        private void OnListarPuntoVentaEOperationCompleted(object arg) {
            if ((this.ListarPuntoVentaECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarPuntoVentaECompleted(this, new ListarPuntoVentaECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Factura", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Factura Factura(Factura facturaEnt) {
            object[] results = this.Invoke("Factura", new object[] {
                        facturaEnt});
            return ((Factura)(results[0]));
        }
        
        /// <remarks/>
        public void FacturaAsync(Factura facturaEnt) {
            this.FacturaAsync(facturaEnt, null);
        }
        
        /// <remarks/>
        public void FacturaAsync(Factura facturaEnt, object userState) {
            if ((this.FacturaOperationCompleted == null)) {
                this.FacturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFacturaOperationCompleted);
            }
            this.InvokeAsync("Factura", new object[] {
                        facturaEnt}, this.FacturaOperationCompleted, userState);
        }
        
        private void OnFacturaOperationCompleted(object arg) {
            if ((this.FacturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FacturaCompleted(this, new FacturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductoModels {
        
        private int idProductoField;
        
        private string nomProductoField;
        
        private System.Nullable<int> precioProductoField;
        
        private System.Nullable<int> idPuntoventaField;
        
        /// <remarks/>
        public int IdProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
            }
        }
        
        /// <remarks/>
        public string NomProducto {
            get {
                return this.nomProductoField;
            }
            set {
                this.nomProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> PrecioProducto {
            get {
                return this.precioProductoField;
            }
            set {
                this.precioProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> idPuntoventa {
            get {
                return this.idPuntoventaField;
            }
            set {
                this.idPuntoventaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Factura {
        
        private int idFacturaField;
        
        private System.Nullable<int> idProductoField;
        
        private System.Nullable<int> cantidadField;
        
        private System.Nullable<int> totalField;
        
        /// <remarks/>
        public int IdFactura {
            get {
                return this.idFacturaField;
            }
            set {
                this.idFacturaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> IdProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PuntoVentaModels {
        
        private int idPuntoField;
        
        private string nombrePuntoField;
        
        /// <remarks/>
        public int IdPunto {
            get {
                return this.idPuntoField;
            }
            set {
                this.idPuntoField = value;
            }
        }
        
        /// <remarks/>
        public string NombrePunto {
            get {
                return this.nombrePuntoField;
            }
            set {
                this.nombrePuntoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void ListarProductoECompletedEventHandler(object sender, ListarProductoECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarProductoECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarProductoECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductoModels[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductoModels[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void ListarPuntoVentaECompletedEventHandler(object sender, ListarPuntoVentaECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarPuntoVentaECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarPuntoVentaECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PuntoVentaModels[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PuntoVentaModels[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void FacturaCompletedEventHandler(object sender, FacturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FacturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FacturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Factura Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Factura)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591