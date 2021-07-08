using Entidades.Cache_usuario;
using Logica.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBeta
{
    public partial class Login : Form
    {
        string user;
        string password;
        UsuarioLN op = new UsuarioLN();
        public Login()
        {
            InitializeComponent();
            labelX1.Visible = false;
        }

      
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="USUARIO  O  CORREO")
            {
                textBox1.Text = "";
            }
            else
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.Text = "CONTRASEÑA";
                }
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "CONTRASEÑA")
            {
                textBox2.Text = "";
            }
            else
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = "USUARIO  O  CORREO";
                }
            }
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "USUARIO  O  CORREO" || textBox2.Text != "CONTRASEÑA")
            {
                if (textBox1.Text != "USUARIO  O  CORREO")
                {
                    if (textBox2.Text != "CONTRASEÑA")
                    {            
                        try
                        {
                            user = op.MostrarUsuariosFitro(textBox1.Text)[0].Email;
                            password = op.MostrarUsuariosVistaFitro(textBox2.Text)[0].Password;
                            if (user.CompareTo(textBox1.Text) == 0 && password.CompareTo(textBox2.Text) == 0)
                            {
                                RellenarUser();                  
                                Form1 frm = new Form1(user,password);
                                frm.Show();
                                frm.FormClosed += Logout;
                                this.Hide();
                            }
                            else msError(" nombre de usuario o contraseña incorrectos");
                        }
                        catch (Exception)
                        {
                            msError(" nombre de usuario o contraseña incorrectos");
                        }
                    }
                    else msError("Por favor ingre una contraseña");
                }
                else msError("Por favor ingrese un nombre de usuario");
            }
            else msError("Por favor ingresa un nombre de usuario y contraseña");
            
        }

        private void RellenarUser()
        {
            foreach (var item in op.MostrarUsuariosVistaFitro(""))
            {
                LoginCache.insert(item);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "USUARIO  O  CORREO";
            textBox2.Text = "CONTRASEÑA";
            labelX1.Visible = false;
            this.Show();
            
        }

        private void msError(string msg)
        {
            labelX1.Text = msg;
            labelX1.Visible= true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Text = "kevin_jpm@hotmail.com";
            textBox2.Text = "Pa@0985837708";
            
        }
    }
}
