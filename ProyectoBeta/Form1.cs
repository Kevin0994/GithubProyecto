using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using ProyectoBeta.Entidades;
using Entidades.Cache_usuario;
using ProyectoBeta.Inventario;
using ProyectoBeta.Seguridad;
using ProyectoBeta.Facturacion;
using Logica.Seguridad;

namespace ProyectoBeta
{
    public partial class Form1 : Form
    {
        UsuarioLN op = new UsuarioLN();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form1(string Usuario,string Contraseña)
        {
            InitializeComponent();
            DesigngPanel();
            PintarUsuario();
            //Permisos();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,40);
            panelMenu.Controls.Add(leftBorderBtn);        
        }

        private void DesigngPanel()
        {
            PaSubmenuAlmacen.Visible = false;
            PaSubmenuCompras.Visible = false;
            PaSubmenuMantenimiento.Visible = false;
            PaSubmenuVentas.Visible = false;
            PaSubmenuUsuarios.Visible = false;
        }

        private void HidePanel()
        {
            if (PaSubmenuAlmacen.Visible == true)   
                PaSubmenuAlmacen.Visible = false;
            if (PaSubmenuCompras.Visible == true)
                PaSubmenuCompras.Visible = false;
            if (PaSubmenuMantenimiento.Visible == true)
                PaSubmenuMantenimiento.Visible = false;
            if (PaSubmenuVentas.Visible == true)
                PaSubmenuVentas.Visible = false;
            if (PaSubmenuUsuarios.Visible == true)
                PaSubmenuUsuarios.Visible = false;
        }

        private void ShowPanel(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HidePanel();
                submenu.Visible = true;

            }
            else
                submenu.Visible = false;
        }

        private void PintarUsuario()
        {
            labelRol.Text = "Rol: "+LoginCache.ListaUsuario[0].Rol;
            labelCorreo.Text = "Correo: "+LoginCache.ListaUsuario[0].Email;
        }


        /*private void Permisos()
        {
            if (LoginCache.BuscarModulo("Clientes"))
            {
                btnClientes.Enabled = true;
            }
            else
            {
                btnClientes.Enabled = false;
            }

            if (LoginCache.BuscarModulo("Productos"))
            {
                btnProductos.Enabled = true;
               
            }
            else
            {
                btnProductos.Enabled = false;
            }

            if (LoginCache.BuscarModulo("Vehiculos"))
            {
                btnVehiculos.Enabled = true;
            }
            else
            {
                btnVehiculos.Enabled = false;

            }

            if (LoginCache.BuscarModulo("Proveedores"))
            {
                btnProveedores.Enabled = true;
            }
            else
            {
                btnProveedores.Enabled = false;

            }

            if (LoginCache.BuscarModulo("Compras"))
            {
                btnCompras.Enabled = true;
            }
            else
            {
                btnCompras.Enabled = false;
            }

            if (LoginCache.BuscarModulo("Empleados"))
            {
                btnEmpleado.Enabled = true;
            }
            else
            {
                btnEmpleado.Enabled = false;

            }

            if (LoginCache.BuscarModulo("Facturacion"))
            {
                btnFactura.Enabled = true;
            }
            else
            {
                btnFactura.Enabled = false;
            }



        */



        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
        }

        private void ActivateButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(64,60,60);
                currentBtn.ForeColor = Color.FromArgb(172, 126, 241);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(172, 126, 241);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconForm.IconChar = currentBtn.IconChar;
                iconForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 244)
            {
                panelMenu.Width = 75;
            }
            else
            {
                panelMenu.Width = 244;
            }

        }

        private Form activateForm = null;
        private void AbrirFrmPanel(Form Formhijo)
        {
            if (activateForm != null)
                activateForm.Close();                   
            activateForm = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            Formhijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(Formhijo);
            panelContenedor.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();
            Tituloform.Text = Formhijo.Text;
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            AbrirFrmPanel(new frmClientes());       

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmProductos());
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconForm.IconChar = IconChar.Home;
            iconForm.IconColor = Color.Gainsboro;
            Tituloform.Text = "Home";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconForm_Click_1(object sender, EventArgs e)
        {
            activateForm.Close();
            Reset();
        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que quiere cerrar sesion?", "Atencion",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmVistaVehiculos());
        }


        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFrmPanel(new frmEmpleados());
        }

      
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ShowPanel(PaSubmenuUsuarios);
            ActivateButton(sender, RGBColors.color1);
        }
   

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ShowPanel(PaSubmenuCompras);
            ActivateButton(sender, RGBColors.color1);
        }

       
        private void iconButton7_Click(object sender, EventArgs e)
        {
            
            AbrirFrmPanel(new frmProveedores());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFrmPanel(new frmVistaVehiculos());
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
          
            AbrirFrmPanel(new frmClientes());
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            ShowPanel(PaSubmenuVentas);
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            ShowPanel(PaSubmenuMantenimiento);
            ActivateButton(sender, RGBColors.color1);           
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmOrden("Pendiente"));
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmCompra());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ShowPanel(PaSubmenuAlmacen);
            ActivateButton(sender, RGBColors.color1);        
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            HidePanel();
            ActivateButton(sender, RGBColors.color1);          
            AbrirFrmPanel(new frmEmpleados());
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmOrden(""));
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmNOrden());
           
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmUsuariosPermisos());
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new frmUsuarios());
        }
    }
}
