namespace ProyectoBeta.Inventario
{
    partial class frmMantenimiento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminHerramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminReToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.adminActividadesToolStripMenuItem,
            this.adminHerramientaToolStripMenuItem,
            this.adminReToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.administrarToolStripMenuItem.Text = "Admin Planes";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // adminActividadesToolStripMenuItem
            // 
            this.adminActividadesToolStripMenuItem.Name = "adminActividadesToolStripMenuItem";
            this.adminActividadesToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.adminActividadesToolStripMenuItem.Text = "Admin Actividades";
            // 
            // adminHerramientaToolStripMenuItem
            // 
            this.adminHerramientaToolStripMenuItem.Name = "adminHerramientaToolStripMenuItem";
            this.adminHerramientaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.adminHerramientaToolStripMenuItem.Text = "Admin Herramienta";
            // 
            // adminReToolStripMenuItem
            // 
            this.adminReToolStripMenuItem.Name = "adminReToolStripMenuItem";
            this.adminReToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.adminReToolStripMenuItem.Text = "Admin Recurso";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 533);
            this.panel1.TabIndex = 1;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMantenimiento";
            this.Text = "frmMantenimiento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminHerramientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminReToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}