using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DominioEntidades.SisReservas;
using SisReservasAgenteServicio;


namespace SisReservasPresentacion.Sitio
{

    public partial class RegistroPersona : Form
    {
        private readonly SisReservasAgenteServicio.ServicioReportes.IServicioReportes servicioReportes =
                LocalizadorProxy.ServicioReportes();
        private readonly SisReservasAgenteServicio.ServicioGestion.IServicioGestion servicioGestion = LocalizadorProxy.ServicioGestion();
        private const string strCredencial= "EBF8FDEFA7ED24CF8C47EE0B149FD4F5";
        public RegistroPersona()
        {
            InitializeComponent();
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre != null && txtNombre.Text != "" ? txtNombre.Text: "" ;
            var genero = getGenero();
            var documento = getDocumento();
            var tipoPersona = 2;//El usuario 2 representa al tipo cliente
            if(nombre!=""){
                if (txtCi.Text != "")
                {
                    registrarPersona(nombre, documento, genero,tipoPersona);
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
                if (rdoMasculino.Checked)
                {
                    genero = 1;
                }
                else if(rdoFemenino.Checked)
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
                if (rdoCi.Checked)
                {
                    documento = 1;
                }
                else if (rdoNit.Checked)
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
        public void registrarPersona(string nombre, decimal documento,decimal genero,decimal tipoPersona)
        {
            try
            {


                var oPersona = new O_LISTAR_PERSONA();
                oPersona.NOMBRE = nombre;
                oPersona.ID_GENERO = Convert.ToDecimal(genero);
                oPersona.ID_TIPO_PERSONA = tipoPersona;
                oPersona.AUD_ESTADO = 1;
                var strMensajeError = "";
                var rstRegistroPersona = servicioGestion.RegistrarPersona(strCredencial, oPersona, ref strMensajeError);

                if (rstRegistroPersona == null || rstRegistroPersona[0].ID_TABLA < 0)
                {
                    throw new Exception(rstRegistroPersona == null
                        ? "No se registro la persona"
                        : rstRegistroPersona[0].MENSAJE_ERROR);
                }
                else
                {
                    var idUltimaPersona = rstRegistroPersona[0].ID_TABLA;
                    var oDocumento = new O_LISTAR_DOCUMENTO();
                    oDocumento.ID_TIPO_DOCUMENTO = documento;
                    oDocumento.ID_PERSONA = idUltimaPersona;
                    var rstDocumento = servicioGestion.RegistrarDocumento(strCredencial, oDocumento, ref strMensajeError);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error 600: " + ex.Message);
            }
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void crear_menu()
        {
            
        }


        
    }
}
