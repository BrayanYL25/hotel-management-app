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
    public partial class FrmDetalleReserva : Form
    {
        public FrmDetalleReserva()
        {
            InitializeComponent();
        }

        private void botonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            AgregarReservaHabitacion agregarReservaHabitacion = new();
            agregarReservaHabitacion.Show();
        }

        private void botonAgregarServicio_Click(object sender, EventArgs e)
        {
            SeleccionarServicio seleccionarServicio = new();
            seleccionarServicio.Show();
        }
    }
}
