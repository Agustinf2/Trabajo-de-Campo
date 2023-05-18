namespace vista
{
    partial class AgregarOC
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
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnArt = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_OrdenCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechain_Ocom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafi_Ocom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(785, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(71, 377);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(144, 37);
            this.btneliminar.TabIndex = 28;
            this.btneliminar.Text = "Eliminar ";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Subtotal";
            // 
            // txtSub
            // 
            this.txtSub.Enabled = false;
            this.txtSub.Location = new System.Drawing.Point(345, 386);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(108, 20);
            this.txtSub.TabIndex = 26;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(662, 456);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 37);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Enviar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnArt
            // 
            this.btnArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArt.Location = new System.Drawing.Point(683, 49);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(75, 23);
            this.btnArt.TabIndex = 24;
            this.btnArt.Text = "Articulos";
            this.btnArt.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(577, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Articulo";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(424, 50);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 18;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(169, 49);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 20);
            this.txtDesc.TabIndex = 17;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(44, 50);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(107, 20);
            this.txtCod.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_OrdenCom,
            this.Id_Articulo,
            this.Proveedor,
            this.fechain_Ocom,
            this.fechafi_Ocom});
            this.dataGridView1.Location = new System.Drawing.Point(44, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(807, 267);
            this.dataGridView1.TabIndex = 15;
            // 
            // Id_OrdenCom
            // 
            this.Id_OrdenCom.HeaderText = "Id Orden Compra";
            this.Id_OrdenCom.Name = "Id_OrdenCom";
            // 
            // Id_Articulo
            // 
            this.Id_Articulo.HeaderText = "Articulo";
            this.Id_Articulo.Name = "Id_Articulo";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // fechain_Ocom
            // 
            this.fechain_Ocom.HeaderText = "Fecha Inicio";
            this.fechain_Ocom.Name = "fechain_Ocom";
            // 
            // fechafi_Ocom
            // 
            this.fechafi_Ocom.HeaderText = "Fecha Fin";
            this.fechafi_Ocom.Name = "fechafi_Ocom";
            // 
            // AgregarOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(975, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnArt);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AgregarOC";
            this.Text = "AgregarOC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_OrdenCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechain_Ocom;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafi_Ocom;
    }
}