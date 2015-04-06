using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisReservasPresentacion.Sitio;

namespace SisReservasPresentacion
{
    public partial class main : Form
    {
        private int childFormNumber = 0;

        public main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void main_Load(object sender, EventArgs e)
        {

        }
        private void seleccionDeAsientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registroPersona = new RegistroPersona();
            registroPersona.MdiParent = this;
            registroPersona.Show();
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

        }

        private void verRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaAsientos = new VistaAsientos();
            vistaAsientos.MdiParent = this;
            vistaAsientos.Show();
        }


    }
}
