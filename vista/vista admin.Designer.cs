namespace vista
{
    partial class vista_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vista_admin));
            this.btnuser = new System.Windows.Forms.Button();
            this.btnart = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnORCom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnuser
            // 
            this.btnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.Location = new System.Drawing.Point(10, 392);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(165, 67);
            this.btnuser.TabIndex = 0;
            this.btnuser.Text = "Gestionar Usuarios";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnart
            // 
            this.btnart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnart.Location = new System.Drawing.Point(369, 392);
            this.btnart.Name = "btnart";
            this.btnart.Size = new System.Drawing.Size(165, 67);
            this.btnart.TabIndex = 1;
            this.btnart.Text = "Gestionar Articulos";
            this.btnart.UseVisualStyleBackColor = true;
            this.btnart.Click += new System.EventHandler(this.btnart_Click);
            // 
            // btnProv
            // 
            this.btnProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProv.Location = new System.Drawing.Point(189, 392);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(165, 67);
            this.btnProv.TabIndex = 2;
            this.btnProv.Text = "Gestionar Proveedores";
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click_1);
            // 
            // btnORCom
            // 
            this.btnORCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnORCom.Location = new System.Drawing.Point(547, 392);
            this.btnORCom.Name = "btnORCom";
            this.btnORCom.Size = new System.Drawing.Size(165, 67);
            this.btnORCom.TabIndex = 3;
            this.btnORCom.Text = "Gestionar Orden De  Compra";
            this.btnORCom.UseVisualStyleBackColor = true;
            this.btnORCom.Click += new System.EventHandler(this.btnORCom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(726, 392);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(165, 67);
            this.btnVentas.TabIndex = 18;
            this.btnVentas.Text = "Gestionar Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // vista_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(903, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnORCom);
            this.Controls.Add(this.btnProv);
            this.Controls.Add(this.btnart);
            this.Controls.Add(this.btnuser);
            this.Name = "vista_admin";
            this.Text = "Modulo de Gestion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnart;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnORCom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVentas;
    }
}