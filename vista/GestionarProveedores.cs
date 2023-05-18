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
    public partial class GestionarProveedores : Form
    {
        int fila;
        public GestionarProveedores()
        {
            InitializeComponent();
            string CMD = string.Format("select * from Proveedores");
            dataGridView1.DataSource = Controladora.sql_consulta.Ejecutar(CMD).Tables[0];
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
            datagridinterfaz();
        }

        public void datagridinterfaz()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Beige;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Oxygen", 12);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void GestionarProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pOO_grupo2bdDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.pOO_grupo2bdDataSet.Proveedores);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AgregarProv frm = new AgregarProv();
            frm.Show();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
            string cmd = string.Format(" delete from Proveedores where Id = " + id);
            Controladora.sql_consulta.Ejecutar(cmd);
            dataGridView1.Rows.RemoveAt(fila);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
