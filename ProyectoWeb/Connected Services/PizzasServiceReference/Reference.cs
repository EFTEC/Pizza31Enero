﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb.PizzasServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PIZZAS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PIZZAS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal IDPIZZAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TITULOField;
        
        private System.Nullable<decimal> PRECIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IMAGENField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoWeb.PizzasServiceReference.ORDENES ORDENESField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal IDPIZZA {
            get {
                return this.IDPIZZAField;
            }
            set {
                if ((this.IDPIZZAField.Equals(value) != true)) {
                    this.IDPIZZAField = value;
                    this.RaisePropertyChanged("IDPIZZA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TITULO {
            get {
                return this.TITULOField;
            }
            set {
                if ((object.ReferenceEquals(this.TITULOField, value) != true)) {
                    this.TITULOField = value;
                    this.RaisePropertyChanged("TITULO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<decimal> PRECIO {
            get {
                return this.PRECIOField;
            }
            set {
                if ((this.PRECIOField.Equals(value) != true)) {
                    this.PRECIOField = value;
                    this.RaisePropertyChanged("PRECIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string IMAGEN {
            get {
                return this.IMAGENField;
            }
            set {
                if ((object.ReferenceEquals(this.IMAGENField, value) != true)) {
                    this.IMAGENField = value;
                    this.RaisePropertyChanged("IMAGEN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public ProyectoWeb.PizzasServiceReference.ORDENES ORDENES {
            get {
                return this.ORDENESField;
            }
            set {
                if ((object.ReferenceEquals(this.ORDENESField, value) != true)) {
                    this.ORDENESField = value;
                    this.RaisePropertyChanged("ORDENES");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ORDENES", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ORDENES : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal IDORDENField;
        
        private System.Nullable<decimal> IDPIZZAField;
        
        private System.Nullable<System.DateTime> FECHAField;
        
        private System.Nullable<decimal> CANTIDADField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string USUARIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoWeb.PizzasServiceReference.EMPLEADOS EMPLEADOSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoWeb.PizzasServiceReference.PIZZAS PIZZASField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal IDORDEN {
            get {
                return this.IDORDENField;
            }
            set {
                if ((this.IDORDENField.Equals(value) != true)) {
                    this.IDORDENField = value;
                    this.RaisePropertyChanged("IDORDEN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<decimal> IDPIZZA {
            get {
                return this.IDPIZZAField;
            }
            set {
                if ((this.IDPIZZAField.Equals(value) != true)) {
                    this.IDPIZZAField = value;
                    this.RaisePropertyChanged("IDPIZZA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<System.DateTime> FECHA {
            get {
                return this.FECHAField;
            }
            set {
                if ((this.FECHAField.Equals(value) != true)) {
                    this.FECHAField = value;
                    this.RaisePropertyChanged("FECHA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<decimal> CANTIDAD {
            get {
                return this.CANTIDADField;
            }
            set {
                if ((this.CANTIDADField.Equals(value) != true)) {
                    this.CANTIDADField = value;
                    this.RaisePropertyChanged("CANTIDAD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string USUARIO {
            get {
                return this.USUARIOField;
            }
            set {
                if ((object.ReferenceEquals(this.USUARIOField, value) != true)) {
                    this.USUARIOField = value;
                    this.RaisePropertyChanged("USUARIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public ProyectoWeb.PizzasServiceReference.EMPLEADOS EMPLEADOS {
            get {
                return this.EMPLEADOSField;
            }
            set {
                if ((object.ReferenceEquals(this.EMPLEADOSField, value) != true)) {
                    this.EMPLEADOSField = value;
                    this.RaisePropertyChanged("EMPLEADOS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public ProyectoWeb.PizzasServiceReference.PIZZAS PIZZAS {
            get {
                return this.PIZZASField;
            }
            set {
                if ((object.ReferenceEquals(this.PIZZASField, value) != true)) {
                    this.PIZZASField = value;
                    this.RaisePropertyChanged("PIZZAS");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EMPLEADOS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class EMPLEADOS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string USUARIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CLAVEField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string USUARIO {
            get {
                return this.USUARIOField;
            }
            set {
                if ((object.ReferenceEquals(this.USUARIOField, value) != true)) {
                    this.USUARIOField = value;
                    this.RaisePropertyChanged("USUARIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string CLAVE {
            get {
                return this.CLAVEField;
            }
            set {
                if ((object.ReferenceEquals(this.CLAVEField, value) != true)) {
                    this.CLAVEField = value;
                    this.RaisePropertyChanged("CLAVE");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzasServiceReference.PizzasWSSoap")]
    public interface PizzasWSSoap {
        
        // CODEGEN: Generating message contract since element name ListarResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        ProyectoWeb.PizzasServiceReference.ListarResponse Listar(ProyectoWeb.PizzasServiceReference.ListarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoWeb.PizzasServiceReference.ListarResponse> ListarAsync(ProyectoWeb.PizzasServiceReference.ListarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Listar", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoWeb.PizzasServiceReference.ListarRequestBody Body;
        
        public ListarRequest() {
        }
        
        public ListarRequest(ProyectoWeb.PizzasServiceReference.ListarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListarRequestBody {
        
        public ListarRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoWeb.PizzasServiceReference.ListarResponseBody Body;
        
        public ListarResponse() {
        }
        
        public ListarResponse(ProyectoWeb.PizzasServiceReference.ListarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoWeb.PizzasServiceReference.PIZZAS[] ListarResult;
        
        public ListarResponseBody() {
        }
        
        public ListarResponseBody(ProyectoWeb.PizzasServiceReference.PIZZAS[] ListarResult) {
            this.ListarResult = ListarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PizzasWSSoapChannel : ProyectoWeb.PizzasServiceReference.PizzasWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzasWSSoapClient : System.ServiceModel.ClientBase<ProyectoWeb.PizzasServiceReference.PizzasWSSoap>, ProyectoWeb.PizzasServiceReference.PizzasWSSoap {
        
        public PizzasWSSoapClient() {
        }
        
        public PizzasWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzasWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzasWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzasWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoWeb.PizzasServiceReference.ListarResponse ProyectoWeb.PizzasServiceReference.PizzasWSSoap.Listar(ProyectoWeb.PizzasServiceReference.ListarRequest request) {
            return base.Channel.Listar(request);
        }
        
        public ProyectoWeb.PizzasServiceReference.PIZZAS[] Listar() {
            ProyectoWeb.PizzasServiceReference.ListarRequest inValue = new ProyectoWeb.PizzasServiceReference.ListarRequest();
            inValue.Body = new ProyectoWeb.PizzasServiceReference.ListarRequestBody();
            ProyectoWeb.PizzasServiceReference.ListarResponse retVal = ((ProyectoWeb.PizzasServiceReference.PizzasWSSoap)(this)).Listar(inValue);
            return retVal.Body.ListarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoWeb.PizzasServiceReference.ListarResponse> ProyectoWeb.PizzasServiceReference.PizzasWSSoap.ListarAsync(ProyectoWeb.PizzasServiceReference.ListarRequest request) {
            return base.Channel.ListarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb.PizzasServiceReference.ListarResponse> ListarAsync() {
            ProyectoWeb.PizzasServiceReference.ListarRequest inValue = new ProyectoWeb.PizzasServiceReference.ListarRequest();
            inValue.Body = new ProyectoWeb.PizzasServiceReference.ListarRequestBody();
            return ((ProyectoWeb.PizzasServiceReference.PizzasWSSoap)(this)).ListarAsync(inValue);
        }
    }
}
