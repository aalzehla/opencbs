//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Octopus.GUI.SoftwareUpdate {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.octopusnetwork.org/webservice/", ConfigurationName="SoftwareUpdate.VersionServicePortType")]
    public interface VersionServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.octopusnetwork.org/webservice/#GetVersion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultat")]
        string GetVersion(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.octopusnetwork.org/webservice/#GetUpdateLink", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resultat")]
        string GetUpdateLink(string input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VersionServicePortTypeChannel : Octopus.GUI.SoftwareUpdate.VersionServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VersionServicePortTypeClient : System.ServiceModel.ClientBase<Octopus.GUI.SoftwareUpdate.VersionServicePortType>, Octopus.GUI.SoftwareUpdate.VersionServicePortType {
        
        public VersionServicePortTypeClient() {
        }
        
        public VersionServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VersionServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VersionServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VersionServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetVersion(string input) {
            return base.Channel.GetVersion(input);
        }
        
        public string GetUpdateLink(string input) {
            return base.Channel.GetUpdateLink(input);
        }
    }
}
