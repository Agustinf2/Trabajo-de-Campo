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
    public partial class VerCarrito : Form
    {
        public VerCarrito()
        {
            InitializeComponent();
            string CMD = string.Format("select Articulos.nombre,cantidad,ArticulosId from Detalle_ventas inner join Articulos on Articulos.Id = ArticulosId");
            dgvCarrito.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
            datagridinterfaz();
        }
        public void datagridinterfaz()
        {
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AllowUserToResizeRows = false;

            dgvCarrito.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvCarrito.BackgroundColor = Color.Gray;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvCarrito.ReadOnly = true;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCarrito.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dgvCarrito.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCarrito.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Beige;
            dgvCarrito.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Green;
            dgvCarrito.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarrito.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCarrito.Font, FontStyle.Bold);
            dgvCarrito.ColumnHeadersDefaultCellStyle.Font = new Font("Oxygen", 12);
            dgvCarrito.ColumnHeadersHeight = 40;
            dgvCarrito.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;

            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.RowHeadersVisible = false;
        }
        private void VerCarrito_Load(object sender, EventArgs e)
        {

        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
