using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contexto;
using Controladora;

namespace vista
{
    public partial class AgregarProv : Form
    {
        public AgregarProv()
        {
            InitializeComponent();
        }

        private void btnnewprov_Click(object sender, EventArgs e)
        {
            {
                Contexto.Proveedores proveedor = new Contexto.Proveedores();
                proveedor.nombre_prov = txtname.Text;
                proveedor.id_proveedor = Int32.Parse(txtnum.Text);
                proveedor.saldo = txtsaldo.Text;
                proveedor.id_articulo = Int32.Parse(txtarticulo.Text);
                Controladora.Proveedor.obtener_instancia().Agregar_Proveedor(proveedor);

                string cmd = string.Format("select max(Id) FROM Proveedores");
                DataSet DS = Controladora.sql_consulta.Ejecutar(cmd);
                int id = Convert.ToInt32(DS.Tables[0].Rows[0][0]);

                cmd = string.Format("update Proveedores" );
                Controladora.sql_consulta.Ejecutar(cmd);

                MessageBox.Show("Proveedor creado con exito");
                this.Close();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProv_Load(object sender, EventArgs e)
        {

        }
    }
}
