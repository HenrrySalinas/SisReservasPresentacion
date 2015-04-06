using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SisReservasAgenteServicio.ServicioReportes;
using SisReservasAgenteServicio.ServicioGestion;

namespace SisReservasAgenteServicio
{
    public class LocalizadorProxy
    {
        public static new ServicioReportes.IServicioReportes ServicioReportes()
        {
            return new ServicioReportesClient("SisReservasReportesEndPoint");
        }
        public static new ServicioGestion.IServicioGestion ServicioGestion()
        {
            return new ServicioGestionClient("SisReservasGestionEndPoint");
        }
    }
}