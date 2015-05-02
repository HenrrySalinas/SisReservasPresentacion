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
using MessageBox = System.Windows.Forms.MessageBox;

namespace SisReservasPresentacion.Sitio
{
    /// <summary>
    /// Lógica de interacción para RegistrarPersona.xaml
    /// </summary>
    public partial class RegistrarPersona : MetroWindow
    {
        private readonly SisReservasAgenteServicio.ServicioReportes.IServicioReportes servicioReportes =LocalizadorProxy.ServicioReportes();
        private readonly SisReservasAgenteServicio.ServicioGestion.IServicioGestion servicioGestion = LocalizadorProxy.ServicioGestion();
        private static readonly string strCredencial = MiscGlobales.getCredencial();

        public RegistrarPersona()
        {
            InitializeComponent();
        }

        private void btnRegistrarPersona_Click(object sender, RoutedEventArgs e)
        {
            var nombre = txtNombre != null && txtNombre.Text != "" ? txtNombre.Text : "";
            var genero = getGenero();
            var documento = getDocumento();
            
            var tipoPersona = 2;//El usuario 2 representa al tipo cliente
            if (nombre != "")
            {
                if (txtNumeroDocumento.Text != "")
                {
                    var numeroDocumento = txtNumeroDocumento.Text;
                    registrarPersona(nombre, documento, genero, tipoPersona, numeroDocumento);
                }
                else
                {
                    MessageBox.Show("Introduzca número de documento");
                }

            }
            else
            {
                MessageBox.Show("Introduzca un nombre");
            }
        }
        private decimal getGenero()
        {
            try
            {
                var genero = 0;
                if (rdoMasculino.IsChecked==true)
                {
                    genero = 1;
                }
                else if (rdoFemenino.IsChecked == true)
                {
                    genero = 2;
                }
                return genero;
            }
            catch (Exception ex)
            {

                throw new Exception("Error 600: " + ex.Message);
            }
        }
        private decimal getDocumento()
        {
            try
            {
                var documento = 0;
                if (rdoCi.IsChecked==true)
                {
                    documento = 1;
                }
                else if (rdoNit.IsChecked==true)
                {
                    documento = 2;
                }
                return documento;
            }
            catch (Exception ex)
            {

                throw new Exception("Error 600: " + ex.Message);
            }
        }
        public void registrarPersona(string nombre, decimal tipoDocumento, decimal genero, decimal tipoPersona, string numeroDocumento)
        {
            try
            {


                var oPersona = new O_LISTAR_PERSONA();
                oPersona.NOMBRE = nombre;
                oPersona.ID_GENERO = Convert.ToDecimal(genero);
                oPersona.ID_TIPO_PERSONA = tipoPersona;
                oPersona.AUD_ESTADO = 1;
                oPersona.FECHA_REGISTRO = DateTime.Now;
                var strMensajeError = "";
                var rstRegistroPersona = servicioGestion.RegistrarPersona(strCredencial, oPersona, ref strMensajeError);

                if (rstRegistroPersona == null || rstRegistroPersona[0].ID_TABLA < 0)
                {
                    throw new Exception(rstRegistroPersona == null
                        ? "No se registró la persona"
                        : rstRegistroPersona[0].MENSAJE_ERROR);
                }
                else
                {
                    var idUltimaPersona = rstRegistroPersona[0].ID_TABLA;
                    var oDocumento = new O_LISTAR_DOCUMENTO();
                    oDocumento.ID_TIPO_DOCUMENTO = tipoDocumento;
                    oDocumento.ID_PERSONA = idUltimaPersona;
                    oDocumento.NUMERO_DOCUMENTO = numeroDocumento;
                    oDocumento.FECHA_REGISTRO = DateTime.Now;
                    var rstDocumento = servicioGestion.RegistrarDocumento(strCredencial, oDocumento, ref strMensajeError);
                    if (rstDocumento == null || rstDocumento[0].ID_TABLA < 0)
                    {
                        throw new Exception(rstDocumento == null
                            ? "No se registró el documento"
                            : rstDocumento[0].MENSAJE_ERROR);
                    }else
                    {
                        limpiarControles(this);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error 600: " + ex.Message);
            }
        }

        void limpiarControles(DependencyObject obj)
        {
            var tb = obj as TextBox;
            if (tb != null)
                tb.Text = "";
            if (obj is RadioButton)
            {
                var rdo = obj as RadioButton;
                if (rdo.GroupName == "sexo" && rdo.Name == "rdoMasculino") 
                { 
                    ((RadioButton)rdo).IsChecked = true;
                }
                else if (rdo.GroupName == "documento" && rdo.Name == "rdoCi")
                {
                    ((RadioButton)rdo).IsChecked = true;
                }
            }
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++) { 
                limpiarControles(VisualTreeHelper.GetChild(obj, i));
            }
        }

       
    }
}
