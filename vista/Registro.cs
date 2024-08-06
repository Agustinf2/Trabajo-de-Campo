using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace vista
{
    public partial class Registro : Form
    {
        int id=0;
        public Registro(int valor)
        {
            InitializeComponent();
            this.id = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool valicontra()
        {
            if (txtpass.Text == txtpass2.Text&& txtpass.Text!="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                txtpass.Text = "";
                txtpass2.Text = "";
                return false;                
            }
            
        }
       /* (txtdni.Text.Length == 8)*/
        public bool valdni()
        {
            bool validador = false;
            if (!int.TryParse(txtdni.Text, out int dni) || txtdni.Text is null)
            {
                MessageBox.Show("Debe ingresar el DNI del cliente");
                txtdni.Focus();
                validador = false;
                return false;
            }
            else
            {
                validador = true;
            }

            if(txtdni.Text.All(char.IsDigit)&&validador==true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El DNI ingresado debe poseer 8 numeros");
                return false;
            }

        }

        public bool valitel()
        {            
            if (txtphone.Text.All(char.IsDigit)&&txtphone.Text!="")
                
            {
                return true;
            }
            else
            {
                MessageBox.Show("Deben ser solo numeros en el telefono");                
                return false;
            }
        }

        public bool valinom()
        {
            if(txtname.Text.All(char.IsLetter)&&txtname.Text!="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("El nombre ingresado debe poseer unicamente letras");
                txtname.Focus();
                return false;
            }
        }

        static public bool ValidacionEMAIL(string Mail)
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    MessageBox.Show("esta mal la direccion Email");                    
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                MessageBox.Show("El campo email es un campo obligatorio");
                //no es correcta, esta vacia
                return false;
            }

        }

       /* public bool existmail()
        {
            string CMD = string.Format("select count(Email) from Usuarios where Email='{0}'",txtmail.Text);
            DataSet DS = Controladora.sql_consulta.Ejecutar(CMD);
            int validador = Convert.ToInt32(DS.Tables[0].Rows[0][0]);

            if (validador==0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ya existe un usuario creado con ese mail");
                return false;
            }
        }*/

        private void button1_Click(object sender, EventArgs e )
        {
            string CMD = string.Format("select count(Email) from Usuarios where Email='{0}'", txtmail.Text);
            DataSet DA = Controladora.sql_consulta.Ejecutar(CMD);
            int validador = Convert.ToInt32(DA.Tables[0].Rows[0][0]);

            //Valida Datos Cliente
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente","Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            if (!int.TryParse(txtdni.Text, out int dni) || txtdni.Text is null)
            {
                MessageBox.Show("Debe ingresar el DNI del cliente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmail.Text) )
            {
                MessageBox.Show("Debe ingresar el email del cliente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Valida Email Cliente
            if (validador != 0)
            {
                MessageBox.Show("El mail ingresado ya existe", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Valida Telefono cliente
            if (!int.TryParse(txtphone.Text, out int telefono) || txtphone.Text is null)
            {
                MessageBox.Show("Debe ingresar el telefono del cliente", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Valida Contraseña cliente
            if (txtpass.Text != txtpass2.Text || txtpass.Text == "")
            {
                MessageBox.Show("Las contraseñas no coinciden", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ;
            }
            if (txtpass.Text.Length <= 8)
            {
                MessageBox.Show("Las contraseñas deben ser de 8 caracteres minimo", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (valinom()&&valitel()&&valdni()&& ValidacionEMAIL(txtmail.Text)&& existmail() && valicontra())
            //{ 
            Contexto.Usuario usuario = new Contexto.Usuario();
                usuario.Nombre = txtname.Text;
                usuario.DNI = txtdni.Text;
                usuario.Email = txtmail.Text;             
                usuario.Contraseña = txtpass.Text;
                usuario.Telefono = txtphone.Text;
                usuario.PerfilId = id;
                Controladora.usuarios.obtener_instancia().Agregar_Usuario(usuario);

                string cmd =string.Format("select max(Id) FROM Usuarios");
                DataSet DS= Controladora.sql_consulta.Ejecutar(cmd);
                id = Convert.ToInt32(DS.Tables[0].Rows[0][0]);

                cmd = string.Format("update Usuarios set Contraseña =ENCRYPTBYPASSPHRASE('contraseña','{0}') where Id="+id,txtpass.Text);
                Controladora.sql_consulta.Ejecutar(cmd);

                MessageBox.Show("Usuario creado con exito");
                this.Close();
            //}

        }
    }
}
