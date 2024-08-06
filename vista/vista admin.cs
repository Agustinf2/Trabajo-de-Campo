using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class vista_admin : Form
    {
        public vista_admin()
        {
            InitializeComponent();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            GestionarUsuarios frm = new GestionarUsuarios();
            frm.Show();
        }

        private void btnart_Click(object sender, EventArgs e)
        {
            Articulos frm = new Articulos();
            frm.Show();
        }

        private void btnprov_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProv_Click_1(object sender, EventArgs e)
        {
            GestionarProveedores frm = new GestionarProveedores();
            frm.Show();
        }

        private void btnORCom_Click(object sender, EventArgs e)
        {
            AgregarOC frm = new AgregarOC();
            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            GestionarVentas frm = new GestionarVentas();
            frm.Show();
        }
    }
}
