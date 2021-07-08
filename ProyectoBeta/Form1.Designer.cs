namespace ProyectoBeta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tituloform = new System.Windows.Forms.Label();
            this.iconForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton20 = new FontAwesome.Sharp.IconButton();
            this.iconButton15 = new FontAwesome.Sharp.IconButton();
            this.PaSubmenuUsuarios = new System.Windows.Forms.Panel();
            this.iconButton18 = new FontAwesome.Sharp.IconButton();
            this.iconButton19 = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.PaSubmenuVentas = new System.Windows.Forms.Panel();
            this.iconButton14 = new FontAwesome.Sharp.IconButton();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.iconButton13 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.PaSubmenuMantenimiento = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.PaSubmenuCompras = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.PaSubmenuAlmacen = new System.Windows.Forms.Panel();
            this.iconButton17 = new FontAwesome.Sharp.IconButton();
            this.iconButton16 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Btnlogout = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconForm)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.PaSubmenuUsuarios.SuspendLayout();
            this.PaSubmenuVentas.SuspendLayout();
            this.PaSubmenuMantenimiento.SuspendLayout();
            this.PaSubmenuCompras.SuspendLayout();
            this.PaSubmenuAlmacen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Tituloform);
            this.panel1.Controls.Add(this.iconForm);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Tituloform
            // 
            resources.ApplyResources(this.Tituloform, "Tituloform");
            this.Tituloform.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tituloform.Name = "Tituloform";
            // 
            // iconForm
            // 
            this.iconForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconForm.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.iconForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconForm.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconForm.IconSize = 39;
            resources.ApplyResources(this.iconForm, "iconForm");
            this.iconForm.Name = "iconForm";
            this.iconForm.TabStop = false;
            this.iconForm.Click += new System.EventHandler(this.iconForm_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panelContenedor, "panelContenedor");
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint_1);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DimGray;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.btnProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconSize = 35;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Rotation = 0D;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.labelCorreo);
            this.panel3.Controls.Add(this.labelRol);
            this.panel3.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // labelCorreo
            // 
            resources.ApplyResources(this.labelCorreo, "labelCorreo");
            this.labelCorreo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelCorreo.Name = "labelCorreo";
            // 
            // labelRol
            // 
            resources.ApplyResources(this.labelRol, "labelRol");
            this.labelRol.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelRol.Name = "labelRol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.iconButton20);
            this.panelMenu.Controls.Add(this.iconButton15);
            this.panelMenu.Controls.Add(this.PaSubmenuUsuarios);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.PaSubmenuVentas);
            this.panelMenu.Controls.Add(this.iconButton10);
            this.panelMenu.Controls.Add(this.PaSubmenuMantenimiento);
            this.panelMenu.Controls.Add(this.iconButton11);
            this.panelMenu.Controls.Add(this.PaSubmenuCompras);
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.PaSubmenuAlmacen);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.Btnlogout);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.Name = "panelMenu";
            // 
            // iconButton20
            // 
            this.iconButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton20, "iconButton20");
            this.iconButton20.FlatAppearance.BorderSize = 0;
            this.iconButton20.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton20.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton20.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.iconButton20.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton20.IconSize = 35;
            this.iconButton20.Name = "iconButton20";
            this.iconButton20.Rotation = 0D;
            this.iconButton20.UseVisualStyleBackColor = true;
            // 
            // iconButton15
            // 
            this.iconButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton15, "iconButton15");
            this.iconButton15.FlatAppearance.BorderSize = 0;
            this.iconButton15.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton15.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton15.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.iconButton15.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton15.IconSize = 35;
            this.iconButton15.Name = "iconButton15";
            this.iconButton15.Rotation = 0D;
            this.iconButton15.UseVisualStyleBackColor = true;
            this.iconButton15.Click += new System.EventHandler(this.iconButton15_Click);
            // 
            // PaSubmenuUsuarios
            // 
            this.PaSubmenuUsuarios.Controls.Add(this.iconButton18);
            this.PaSubmenuUsuarios.Controls.Add(this.iconButton19);
            resources.ApplyResources(this.PaSubmenuUsuarios, "PaSubmenuUsuarios");
            this.PaSubmenuUsuarios.Name = "PaSubmenuUsuarios";
            // 
            // iconButton18
            // 
            this.iconButton18.BackColor = System.Drawing.Color.DimGray;
            this.iconButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton18, "iconButton18");
            this.iconButton18.FlatAppearance.BorderSize = 0;
            this.iconButton18.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton18.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton18.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton18.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton18.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton18.IconSize = 35;
            this.iconButton18.Name = "iconButton18";
            this.iconButton18.Rotation = 0D;
            this.iconButton18.UseVisualStyleBackColor = false;
            this.iconButton18.Click += new System.EventHandler(this.iconButton18_Click);
            // 
            // iconButton19
            // 
            this.iconButton19.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.iconButton19, "iconButton19");
            this.iconButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton19.FlatAppearance.BorderSize = 0;
            this.iconButton19.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton19.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton19.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton19.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconButton19.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton19.IconSize = 35;
            this.iconButton19.Name = "iconButton19";
            this.iconButton19.Rotation = 0D;
            this.iconButton19.UseVisualStyleBackColor = false;
            this.iconButton19.Click += new System.EventHandler(this.iconButton19_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnUsuarios, "btnUsuarios");
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnUsuarios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconSize = 35;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Rotation = 0D;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // PaSubmenuVentas
            // 
            this.PaSubmenuVentas.Controls.Add(this.iconButton14);
            this.PaSubmenuVentas.Controls.Add(this.iconButton12);
            this.PaSubmenuVentas.Controls.Add(this.iconButton13);
            resources.ApplyResources(this.PaSubmenuVentas, "PaSubmenuVentas");
            this.PaSubmenuVentas.Name = "PaSubmenuVentas";
            // 
            // iconButton14
            // 
            this.iconButton14.BackColor = System.Drawing.Color.DimGray;
            this.iconButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton14, "iconButton14");
            this.iconButton14.FlatAppearance.BorderSize = 0;
            this.iconButton14.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton14.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton14.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton14.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton14.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton14.IconSize = 35;
            this.iconButton14.Name = "iconButton14";
            this.iconButton14.Rotation = 0D;
            this.iconButton14.UseVisualStyleBackColor = false;
            // 
            // iconButton12
            // 
            this.iconButton12.BackColor = System.Drawing.Color.DimGray;
            this.iconButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton12, "iconButton12");
            this.iconButton12.FlatAppearance.BorderSize = 0;
            this.iconButton12.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton12.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton12.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton12.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton12.IconSize = 35;
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Rotation = 0D;
            this.iconButton12.UseVisualStyleBackColor = false;
            this.iconButton12.Click += new System.EventHandler(this.iconButton12_Click);
            // 
            // iconButton13
            // 
            this.iconButton13.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.iconButton13, "iconButton13");
            this.iconButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton13.FlatAppearance.BorderSize = 0;
            this.iconButton13.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton13.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton13.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton13.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.iconButton13.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton13.IconSize = 35;
            this.iconButton13.Name = "iconButton13";
            this.iconButton13.Rotation = 0D;
            this.iconButton13.UseVisualStyleBackColor = false;
            this.iconButton13.Click += new System.EventHandler(this.iconButton13_Click);
            // 
            // iconButton10
            // 
            this.iconButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton10, "iconButton10");
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton10.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.iconButton10.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton10.IconSize = 35;
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Rotation = 0D;
            this.iconButton10.UseVisualStyleBackColor = true;
            this.iconButton10.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // PaSubmenuMantenimiento
            // 
            this.PaSubmenuMantenimiento.Controls.Add(this.iconButton5);
            this.PaSubmenuMantenimiento.Controls.Add(this.iconButton9);
            resources.ApplyResources(this.PaSubmenuMantenimiento, "PaSubmenuMantenimiento");
            this.PaSubmenuMantenimiento.Name = "PaSubmenuMantenimiento";
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.DimGray;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton5, "iconButton5");
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconSize = 35;
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click_1);
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.iconButton9, "iconButton9");
            this.iconButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton9.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton9.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.iconButton9.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton9.IconSize = 35;
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Rotation = 0D;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // iconButton11
            // 
            this.iconButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton11, "iconButton11");
            this.iconButton11.FlatAppearance.BorderSize = 0;
            this.iconButton11.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton11.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconButton11.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton11.IconSize = 35;
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Rotation = 0D;
            this.iconButton11.UseVisualStyleBackColor = true;
            this.iconButton11.Click += new System.EventHandler(this.iconButton11_Click);
            // 
            // PaSubmenuCompras
            // 
            this.PaSubmenuCompras.Controls.Add(this.iconButton8);
            this.PaSubmenuCompras.Controls.Add(this.iconButton7);
            this.PaSubmenuCompras.Controls.Add(this.iconButton6);
            resources.ApplyResources(this.PaSubmenuCompras, "PaSubmenuCompras");
            this.PaSubmenuCompras.Name = "PaSubmenuCompras";
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.DimGray;
            this.iconButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton8, "iconButton8");
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton8.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconButton8.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton8.IconSize = 35;
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Rotation = 0D;
            this.iconButton8.UseVisualStyleBackColor = false;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.iconButton7, "iconButton7");
            this.iconButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton7.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.iconButton7.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconSize = 35;
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Rotation = 0D;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.iconButton6, "iconButton6");
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconSize = 35;
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Rotation = 0D;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton4, "iconButton4");
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconSize = 35;
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // PaSubmenuAlmacen
            // 
            this.PaSubmenuAlmacen.Controls.Add(this.iconButton17);
            this.PaSubmenuAlmacen.Controls.Add(this.iconButton16);
            this.PaSubmenuAlmacen.Controls.Add(this.iconButton3);
            this.PaSubmenuAlmacen.Controls.Add(this.iconButton2);
            this.PaSubmenuAlmacen.Controls.Add(this.btnProductos);
            resources.ApplyResources(this.PaSubmenuAlmacen, "PaSubmenuAlmacen");
            this.PaSubmenuAlmacen.Name = "PaSubmenuAlmacen";
            // 
            // iconButton17
            // 
            this.iconButton17.BackColor = System.Drawing.Color.DimGray;
            this.iconButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton17, "iconButton17");
            this.iconButton17.FlatAppearance.BorderSize = 0;
            this.iconButton17.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton17.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton17.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton17.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox;
            this.iconButton17.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton17.IconSize = 35;
            this.iconButton17.Name = "iconButton17";
            this.iconButton17.Rotation = 0D;
            this.iconButton17.UseVisualStyleBackColor = false;
            this.iconButton17.Click += new System.EventHandler(this.iconButton17_Click);
            // 
            // iconButton16
            // 
            this.iconButton16.BackColor = System.Drawing.Color.DimGray;
            this.iconButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton16, "iconButton16");
            this.iconButton16.FlatAppearance.BorderSize = 0;
            this.iconButton16.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton16.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton16.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton16.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconButton16.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton16.IconSize = 35;
            this.iconButton16.Name = "iconButton16";
            this.iconButton16.Rotation = 0D;
            this.iconButton16.UseVisualStyleBackColor = false;
            this.iconButton16.Click += new System.EventHandler(this.iconButton16_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.DimGray;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton3, "iconButton3");
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconSize = 35;
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DimGray;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton2, "iconButton2");
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Btnlogout
            // 
            this.Btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Btnlogout, "Btnlogout");
            this.Btnlogout.FlatAppearance.BorderSize = 0;
            this.Btnlogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btnlogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btnlogout.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.Btnlogout.IconColor = System.Drawing.Color.Gainsboro;
            this.Btnlogout.IconSize = 35;
            this.Btnlogout.Name = "Btnlogout";
            this.Btnlogout.Rotation = 0D;
            this.Btnlogout.UseVisualStyleBackColor = true;
            this.Btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconForm)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.PaSubmenuUsuarios.ResumeLayout(false);
            this.PaSubmenuVentas.ResumeLayout(false);
            this.PaSubmenuMantenimiento.ResumeLayout(false);
            this.PaSubmenuCompras.ResumeLayout(false);
            this.PaSubmenuAlmacen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Tituloform;
        private FontAwesome.Sharp.IconPictureBox iconForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnProductos;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Btnlogout;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel PaSubmenuAlmacen;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel PaSubmenuCompras;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Panel PaSubmenuVentas;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton13;
        private FontAwesome.Sharp.IconButton iconButton10;
        private System.Windows.Forms.Panel PaSubmenuMantenimiento;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton14;
        private FontAwesome.Sharp.IconButton iconButton16;
        private FontAwesome.Sharp.IconButton iconButton20;
        private FontAwesome.Sharp.IconButton iconButton15;
        private System.Windows.Forms.Panel PaSubmenuUsuarios;
        private FontAwesome.Sharp.IconButton iconButton18;
        private FontAwesome.Sharp.IconButton iconButton19;
        private FontAwesome.Sharp.IconButton iconButton17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelRol;
    }
}

