using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DominioEntidades.SisReservas;
using MahApps.Metro.Controls;
using SisReservasAgenteServicio;
using SisReservasPresentacion.Clases;
using SisReservasPresentacion.Sitio;

namespace SisReservasPresentacion
{
    /// <summary>
    /// Lógica de interacción para uiMain.xaml
    /// </summary>
    public partial class uiMain : MetroWindow
    {
        private readonly SisReservasAgenteServicio.ServicioReportes.IServicioReportes servicioReportes = LocalizadorProxy.ServicioReportes();
        private readonly SisReservasAgenteServicio.ServicioGestion.IServicioGestion servicioGestion = LocalizadorProxy.ServicioGestion();
        private static readonly string strCredencial = MiscGlobales.getCredencial();
        public uiMain()
        {
            InitializeComponent();
            llenarCiudad();
            mostrarHorario();
        }

        void llenarCiudad()
        {
            try
            {
                var strMensajeError = "";
                var oListarCiudad = new O_CIUDAD();

                var lstCiudad = servicioReportes.ListarCiudad(strCredencial, oListarCiudad, ref strMensajeError);

                var lstCiudades = (from ciudad in lstCiudad
                                   orderby ciudad.CIUDAD
                                           select new
                                           {
                                               idCiudad=ciudad.ID_CIUDAD,
                                               ciudad=ciudad.CIUDAD
                                           }

                                     );
                dgvCiudad.ItemsSource = lstCiudades.ToList();
                //dgvCiudad.DataBind();
            }
            catch (Exception e)
            {
                
                throw new Exception("Error 600: "+ e.Message);
            }
        }

        private void mostrarHorario()
        {
            try
            {
                var strMensajeError = "";
                var oRutaCompleto = new O_LISTAR_RUTA_COMPLETO();
                var lstRutaCompleto = servicioReportes.ListarRutaCompleto(strCredencial, oRutaCompleto, ref strMensajeError);
                var nro = 0;
                var lstRutaLinq=(from ruta in lstRutaCompleto
                                     select new
                                     {
                                        nro=++nro,
                                        horario=ruta.HORA,
                                        idRuta=ruta.ID_RUTA
                                     });
                dgvHorario.ItemsSource = lstRutaLinq.ToList();

            }
            catch (Exception e)
            {

                throw new Exception("Error 600: " + e.Message);
            }
        }
        private void rtglRutas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //var main = this.MdiParent;
                var registroPersona = new RegistrarPersona();

                //registroPersona.MdiParent = this;


                registroPersona.Show();
                this.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("Error 600: " + ex.Message);
            }
        }
    }
}
