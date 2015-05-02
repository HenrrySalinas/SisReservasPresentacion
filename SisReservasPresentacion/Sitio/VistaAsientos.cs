using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisReservasPresentacion.Sitio
{
    public partial class VistaAsientos : Form
    {
        public VistaAsientos()
        {
            InitializeComponent();
            addContextMenu();
        }

        public void addContextMenu()
        {
            try
            {
                var menu = new ContextMenu();
                var menuItem = new MenuItem("vender");
                var menuItem2 = new MenuItem("reservar");
                menuItem.Click += new EventHandler(venderAsiento);
                menu.MenuItems.AddRange(new MenuItem[] { menuItem, menuItem2 });
                lblAsiento1.ContextMenu = menu;
            }
            catch (Exception ex)
            {

                throw new Exception("Error 600: " + ex.Message);
            }


            
        }

        private void venderAsiento(object  sender, EventArgs e)
        {
            try
            {
                var main = this.MdiParent;
                var registroPersona = new RegistroPersona();

                registroPersona.MdiParent = main;
                registroPersona.Show();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error 600: "+ ex.Message);
            }
        }

        private void VistaAsientos_Load(object sender, EventArgs e)
        {
            StartPosition=FormStartPosition.CenterScreen;
        }

    }
}
