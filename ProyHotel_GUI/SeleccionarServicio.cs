using ProyHotel_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyHotel_GUI
{
    public partial class SeleccionarServicio : Form
    {
        ServicioBL servicioBusiness = new();

        public SeleccionarServicio()
        {
            InitializeComponent();
        }

        private void CargarDatos(string filtro)
        {
            DataView dataView = new DataView(servicioBusiness.ListarServicio());

        }

        private void SeleccionarServicio_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
    }
}
