﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisReservasAgenteServicio.ServicioReportes {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioReportes.IServicioReportes")]
    public interface IServicioReportes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarGenero", ReplyAction="http://tempuri.org/IServicioReportes/ListarGeneroResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_GENERO> ListarGenero(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_GENERO oListarGenero, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarPersona", ReplyAction="http://tempuri.org/IServicioReportes/ListarPersonaResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_PERSONA> ListarPersona(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_PERSONA oListarPersona, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarDocumento", ReplyAction="http://tempuri.org/IServicioReportes/ListarDocumentoResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarBoletoCompleto", ReplyAction="http://tempuri.org/IServicioReportes/ListarBoletoCompletoResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_BOLETO_COMPLETO> ListarBoletoCompleto(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_BOLETO_COMPLETO oListarBoletoCompleto, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarAsientoCompleto", ReplyAction="http://tempuri.org/IServicioReportes/ListarAsientoCompletoResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_ASIENTO_COMPLETO> ListarAsientoCompleto(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_ASIENTO_COMPLETO oListarAsientoCompleto, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarRutaCompleto", ReplyAction="http://tempuri.org/IServicioReportes/ListarRutaCompletoResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_RUTA_COMPLETO> ListarRutaCompleto(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_RUTA_COMPLETO oListarRutaCompleto, ref string strMensajeError);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioReportes/ListarCiudad", ReplyAction="http://tempuri.org/IServicioReportes/ListarCiudadResponse")]
        System.Collections.Generic.List<DominioEntidades.SisReservas.O_CIUDAD> ListarCiudad(string strCredencial, DominioEntidades.SisReservas.O_CIUDAD oCiudad, ref string strMensajeError);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioReportesChannel : SisReservasAgenteServicio.ServicioReportes.IServicioReportes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioReportesClient : System.ServiceModel.ClientBase<SisReservasAgenteServicio.ServicioReportes.IServicioReportes>, SisReservasAgenteServicio.ServicioReportes.IServicioReportes {
        
        public ServicioReportesClient() {
        }
        
        public ServicioReportesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioReportesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReportesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioReportesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_GENERO> ListarGenero(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_GENERO oListarGenero, ref string strMensajeError) {
            return base.Channel.ListarGenero(strCredencial, oListarGenero, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_PERSONA> ListarPersona(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_PERSONA oListarPersona, ref string strMensajeError) {
            return base.Channel.ListarPersona(strCredencial, oListarPersona, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError) {
            return base.Channel.ListarDocumento(strCredencial, oListarDocumento, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_BOLETO_COMPLETO> ListarBoletoCompleto(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_BOLETO_COMPLETO oListarBoletoCompleto, ref string strMensajeError) {
            return base.Channel.ListarBoletoCompleto(strCredencial, oListarBoletoCompleto, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_ASIENTO_COMPLETO> ListarAsientoCompleto(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_ASIENTO_COMPLETO oListarAsientoCompleto, ref string strMensajeError) {
            return base.Channel.ListarAsientoCompleto(strCredencial, oListarAsientoCompleto, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_LISTAR_RUTA_COMPLETO> ListarRutaCompleto(string strCredencial, DominioEntidades.SisReservas.O_LISTAR_RUTA_COMPLETO oListarRutaCompleto, ref string strMensajeError) {
            return base.Channel.ListarRutaCompleto(strCredencial, oListarRutaCompleto, ref strMensajeError);
        }
        
        public System.Collections.Generic.List<DominioEntidades.SisReservas.O_CIUDAD> ListarCiudad(string strCredencial, DominioEntidades.SisReservas.O_CIUDAD oCiudad, ref string strMensajeError) {
            return base.Channel.ListarCiudad(strCredencial, oCiudad, ref strMensajeError);
        }
    }
}
