namespace vista
{
    partial class GestionarProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOO_grupo2bdDataSet = new vista.POO_grupo2bdDataSet();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.proveedoresTableAdapter = new vista.POO_grupo2bdDataSetTableAdapters.ProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOO_grupo2bdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn,
            this.nombreprovDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.idarticuloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 211);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "ID Proveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            // 
            // nombreprovDataGridViewTextBoxColumn
            // 
            this.nombreprovDataGridViewTextBoxColumn.DataPropertyName = "nombre_prov";
            this.nombreprovDataGridViewTextBoxColumn.HeaderText = "Nombre Prov";
            this.nombreprovDataGridViewTextBoxColumn.Name = "nombreprovDataGridViewTextBoxColumn";
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            // 
            // idarticuloDataGridViewTextBoxColumn
            // 
            this.idarticuloDataGridViewTextBoxColumn.DataPropertyName = "id_articulo";
            this.idarticuloDataGridViewTextBoxColumn.HeaderText = "ID Articulo";
            this.idarticuloDataGridViewTextBoxColumn.Name = "idarticuloDataGridViewTextBoxColumn";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.pOO_grupo2bdDataSet;
            // 
            // pOO_grupo2bdDataSet
            // 
            this.pOO_grupo2bdDataSet.DataSetName = "POO_grupo2bdDataSet";
            this.pOO_grupo2bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(296, 267);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(108, 37);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(176, 267);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(104, 37);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(54, 267);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 37);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // GestionarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(594, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnadd);
            this.Name = "GestionarProveedores";
            this.Text = "GestionarProveedores";
            this.Load += new System.EventHandler(this.GestionarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOO_grupo2bdDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnadd;
        private POO_grupo2bdDataSet pOO_grupo2bdDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private POO_grupo2bdDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreprovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticuloDataGridViewTextBoxColumn;
    }
}