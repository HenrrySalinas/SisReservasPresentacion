﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisReservasAgenteServicio.ServicioGestion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioGestion.IServicioGestion")]
    public interface IServicioGestion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestion/RegistrarGenero", ReplyAction="http://tempuri.org/IServicioGestion/RegistrarGeneroResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_RESULTADO> RegistrarGenero(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_GENERO oGenero, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestion/RegistrarPersona", ReplyAction="http://tempuri.org/IServicioGestion/RegistrarPersonaResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_RESULTADO> RegistrarPersona(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_PERSONA oPersona, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGestion/RegistrarDocumento", ReplyAction="http://tempuri.org/IServicioGestion/RegistrarDocumentoResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_RESULTADO> RegistrarDocumento(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioGestionChannel : SisReservasAgenteServicio.ServicioGestion.IServicioGestion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioGestionClient : System.ServiceModel.ClientBase<SisReservasAgenteServicio.ServicioGestion.IServicioGestion>, SisReservasAgenteServicio.ServicioGestion.IServicioGestion {
        
        public ServicioGestionClient() {
        }
        
        public ServicioGestionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioGestionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGestionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGestionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_RESULTADO> RegistrarGenero(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_GENERO oGenero, ref string strMensajeError) {
            return base.Channel.RegistrarGenero(strCredencial, oGenero, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_RESULTADO> RegistrarPersona(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_PERSONA oPersona, ref string strMensajeError) {
            return base.Channel.RegistrarPersona(strCredencial, oPersona, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_RESULTADO> RegistrarDocumento(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError) {
            return base.Channel.RegistrarDocumento(strCredencial, oDocumento, ref strMensajeError);
        }
    }
}
