using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHotel_BE;

namespace ProyHotel_GUI
{
    public partial class FrmDetalleReserva : Form
    {
        ReservaBE reservaBE;
        public FrmDetalleReserva(ReservaBE reservaBE)
        {
            InitializeComponent();
            this.reservaBE = reservaBE;
        }

        private void botonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            FrmAgregarReservaHabitacion agregarReservaHabitacion = new();
            agregarReservaHabitacion.Show();
        }

        private void botonAgregarServicio_Click(object sender, EventArgs e)
        {
            FrmAgregarServicioReserva seleccionarServicio = new();
            seleccionarServicio.Show();
        }

        private void FrmDetalleReserva_Load(object sender, EventArgs e)
        {
            labelResultadoId.Text = reservaBE.reservaId.ToString();
            labelResultadoDocumento.Text = reservaBE.usuarioDni;
            labelResultadoNombre.Text = reservaBE.reservaNombre;
            labelResultadoTelefono.Text = reservaBE.usuarioTelefono;
        }
    }
}
