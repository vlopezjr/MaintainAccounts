﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaintainAccount.CASalesTax {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CASalesTax.CATaxRateAPISoap")]
    public interface CATaxRateAPISoap {
        
        // CODEGEN: Generating message contract since element name address from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTaxRateXML", ReplyAction="*")]
        MaintainAccount.CASalesTax.GetTaxRateXMLResponse GetTaxRateXML(MaintainAccount.CASalesTax.GetTaxRateXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTaxRateXML", ReplyAction="*")]
        System.Threading.Tasks.Task<MaintainAccount.CASalesTax.GetTaxRateXMLResponse> GetTaxRateXMLAsync(MaintainAccount.CASalesTax.GetTaxRateXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTaxRate", ReplyAction="*")]
        MaintainAccount.CASalesTax.GetTaxRateResponse GetTaxRate(MaintainAccount.CASalesTax.GetTaxRateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTaxRate", ReplyAction="*")]
        System.Threading.Tasks.Task<MaintainAccount.CASalesTax.GetTaxRateResponse> GetTaxRateAsync(MaintainAccount.CASalesTax.GetTaxRateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaxRateXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaxRateXML", Namespace="http://tempuri.org/", Order=0)]
        public MaintainAccount.CASalesTax.GetTaxRateXMLRequestBody Body;
        
        public GetTaxRateXMLRequest() {
        }
        
        public GetTaxRateXMLRequest(MaintainAccount.CASalesTax.GetTaxRateXMLRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTaxRateXMLRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string city;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string zip;
        
        public GetTaxRateXMLRequestBody() {
        }
        
        public GetTaxRateXMLRequestBody(string address, string city, string zip) {
            this.address = address;
            this.city = city;
            this.zip = zip;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaxRateXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaxRateXMLResponse", Namespace="http://tempuri.org/", Order=0)]
        public MaintainAccount.CASalesTax.GetTaxRateXMLResponseBody Body;
        
        public GetTaxRateXMLResponse() {
        }
        
        public GetTaxRateXMLResponse(MaintainAccount.CASalesTax.GetTaxRateXMLResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTaxRateXMLResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CPUserControls.CASalesTax.CATaxResponse GetTaxRateXMLResult;
        
        public GetTaxRateXMLResponseBody() {
        }
        
        public GetTaxRateXMLResponseBody(CPUserControls.CASalesTax.CATaxResponse GetTaxRateXMLResult) {
            this.GetTaxRateXMLResult = GetTaxRateXMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaxRateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaxRate", Namespace="http://tempuri.org/", Order=0)]
        public MaintainAccount.CASalesTax.GetTaxRateRequestBody Body;
        
        public GetTaxRateRequest() {
        }
        
        public GetTaxRateRequest(MaintainAccount.CASalesTax.GetTaxRateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTaxRateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string city;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string zip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string taxrate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string county;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string jurisdiction;
        
        public GetTaxRateRequestBody() {
        }
        
        public GetTaxRateRequestBody(string address, string city, string zip, string taxrate, string county, string jurisdiction) {
            this.address = address;
            this.city = city;
            this.zip = zip;
            this.taxrate = taxrate;
            this.county = county;
            this.jurisdiction = jurisdiction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaxRateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaxRateResponse", Namespace="http://tempuri.org/", Order=0)]
        public MaintainAccount.CASalesTax.GetTaxRateResponseBody Body;
        
        public GetTaxRateResponse() {
        }
        
        public GetTaxRateResponse(MaintainAccount.CASalesTax.GetTaxRateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTaxRateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetTaxRateResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string taxrate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string county;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string jurisdiction;
        
        public GetTaxRateResponseBody() {
        }
        
        public GetTaxRateResponseBody(int GetTaxRateResult, string taxrate, string county, string jurisdiction) {
            this.GetTaxRateResult = GetTaxRateResult;
            this.taxrate = taxrate;
            this.county = county;
            this.jurisdiction = jurisdiction;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CATaxRateAPISoapChannel : MaintainAccount.CASalesTax.CATaxRateAPISoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CATaxRateAPISoapClient : System.ServiceModel.ClientBase<MaintainAccount.CASalesTax.CATaxRateAPISoap>, MaintainAccount.CASalesTax.CATaxRateAPISoap {
        
        public CATaxRateAPISoapClient() {
        }
        
        public CATaxRateAPISoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CATaxRateAPISoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CATaxRateAPISoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CATaxRateAPISoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MaintainAccount.CASalesTax.GetTaxRateXMLResponse MaintainAccount.CASalesTax.CATaxRateAPISoap.GetTaxRateXML(MaintainAccount.CASalesTax.GetTaxRateXMLRequest request) {
            return base.Channel.GetTaxRateXML(request);
        }
        
        public CPUserControls.CASalesTax.CATaxResponse GetTaxRateXML(string address, string city, string zip) {
            MaintainAccount.CASalesTax.GetTaxRateXMLRequest inValue = new MaintainAccount.CASalesTax.GetTaxRateXMLRequest();
            inValue.Body = new MaintainAccount.CASalesTax.GetTaxRateXMLRequestBody();
            inValue.Body.address = address;
            inValue.Body.city = city;
            inValue.Body.zip = zip;
            MaintainAccount.CASalesTax.GetTaxRateXMLResponse retVal = ((MaintainAccount.CASalesTax.CATaxRateAPISoap)(this)).GetTaxRateXML(inValue);
            return retVal.Body.GetTaxRateXMLResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MaintainAccount.CASalesTax.GetTaxRateXMLResponse> MaintainAccount.CASalesTax.CATaxRateAPISoap.GetTaxRateXMLAsync(MaintainAccount.CASalesTax.GetTaxRateXMLRequest request) {
            return base.Channel.GetTaxRateXMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<MaintainAccount.CASalesTax.GetTaxRateXMLResponse> GetTaxRateXMLAsync(string address, string city, string zip) {
            MaintainAccount.CASalesTax.GetTaxRateXMLRequest inValue = new MaintainAccount.CASalesTax.GetTaxRateXMLRequest();
            inValue.Body = new MaintainAccount.CASalesTax.GetTaxRateXMLRequestBody();
            inValue.Body.address = address;
            inValue.Body.city = city;
            inValue.Body.zip = zip;
            return ((MaintainAccount.CASalesTax.CATaxRateAPISoap)(this)).GetTaxRateXMLAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MaintainAccount.CASalesTax.GetTaxRateResponse MaintainAccount.CASalesTax.CATaxRateAPISoap.GetTaxRate(MaintainAccount.CASalesTax.GetTaxRateRequest request) {
            return base.Channel.GetTaxRate(request);
        }
        
        public int GetTaxRate(string address, string city, string zip, ref string taxrate, ref string county, ref string jurisdiction) {
            MaintainAccount.CASalesTax.GetTaxRateRequest inValue = new MaintainAccount.CASalesTax.GetTaxRateRequest();
            inValue.Body = new MaintainAccount.CASalesTax.GetTaxRateRequestBody();
            inValue.Body.address = address;
            inValue.Body.city = city;
            inValue.Body.zip = zip;
            inValue.Body.taxrate = taxrate;
            inValue.Body.county = county;
            inValue.Body.jurisdiction = jurisdiction;
            MaintainAccount.CASalesTax.GetTaxRateResponse retVal = ((MaintainAccount.CASalesTax.CATaxRateAPISoap)(this)).GetTaxRate(inValue);
            taxrate = retVal.Body.taxrate;
            county = retVal.Body.county;
            jurisdiction = retVal.Body.jurisdiction;
            return retVal.Body.GetTaxRateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MaintainAccount.CASalesTax.GetTaxRateResponse> MaintainAccount.CASalesTax.CATaxRateAPISoap.GetTaxRateAsync(MaintainAccount.CASalesTax.GetTaxRateRequest request) {
            return base.Channel.GetTaxRateAsync(request);
        }
        
        public System.Threading.Tasks.Task<MaintainAccount.CASalesTax.GetTaxRateResponse> GetTaxRateAsync(string address, string city, string zip, string taxrate, string county, string jurisdiction) {
            MaintainAccount.CASalesTax.GetTaxRateRequest inValue = new MaintainAccount.CASalesTax.GetTaxRateRequest();
            inValue.Body = new MaintainAccount.CASalesTax.GetTaxRateRequestBody();
            inValue.Body.address = address;
            inValue.Body.city = city;
            inValue.Body.zip = zip;
            inValue.Body.taxrate = taxrate;
            inValue.Body.county = county;
            inValue.Body.jurisdiction = jurisdiction;
            return ((MaintainAccount.CASalesTax.CATaxRateAPISoap)(this)).GetTaxRateAsync(inValue);
        }
    }
}
