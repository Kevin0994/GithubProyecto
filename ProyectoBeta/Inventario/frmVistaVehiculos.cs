using Logica.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBeta.Inventario
{
    public partial class frmVistaVehiculos : Form
    {
        VehiculoLN op = new VehiculoLN();
        public frmVistaVehiculos()
        {
            InitializeComponent();
        }

        private void frmVistaVehiculos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.MostrarVehiculosFitro("");
        }
    }
}
