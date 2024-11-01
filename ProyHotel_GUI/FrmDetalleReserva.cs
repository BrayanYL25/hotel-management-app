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
using ProyHotel_BL;

namespace ProyHotel_GUI
{
    public partial class FrmDetalleReserva : Form
    {
        ReservaBE reservaBE;
        ReservaServicioBL reservaServicioBL = new();
        
        public FrmDetalleReserva(ReservaBE reservaBE)
        {
            InitializeComponent();
            this.reservaBE = reservaBE;
        }

        private void CargarServicioReserva()
        {
            DataView dataView = new DataView(reservaServicioBL.ListarReservaServicioPorIdReserva(reservaBE.reservaId));
            gridServiciosReserva.AutoGenerateColumns = false;
            gridServiciosReserva.DataSource = dataView;
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
            CargarServicioReserva();
            labelResultadoId.Text = reservaBE.reservaId.ToString();
            labelResultadoDocumento.Text = reservaBE.usuarioDni;
            labelResultadoNombre.Text = reservaBE.reservaNombre;
            labelResultadoTelefono.Text = reservaBE.usuarioTelefono;
        }
    }
}
