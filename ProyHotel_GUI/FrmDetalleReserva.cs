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
        ReservasBL reservasBL = new();
        ReservaServicioBL reservaServicioBL = new();
        ReservaHabitacionesBL reservaHabitacionesBL = new();

        
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
        private void CargarHabitacionReserva()
        {
            DataView dataView = new DataView(reservaHabitacionesBL.ListarReservaHabitacionPorIdReserva(reservaBE.reservaId));
            gridHabitaciones.AutoGenerateColumns = false;
            gridHabitaciones.DataSource = dataView;
        }

        private void RefrescarDatosReserva()
        {
            reservaBE = reservasBL.ConsultarReserva(reservaBE.reservaId);
            labelResultadoId.Text = reservaBE.reservaId.ToString();
            labelResultadoDocumento.Text = reservaBE.usuarioDni;
            labelResultadoNombre.Text = reservaBE.reservaNombre;
            labelResultadoTelefono.Text = reservaBE.usuarioTelefono;
            labelResultadoPrecioTotal.Text = reservaBE.precioTotal.ToString("C2");
        }

        private void botonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            FrmAgregarReservaHabitacion agregarReservaHabitacion = new();
            agregarReservaHabitacion.Show();
        }

        private void botonAgregarServicio_Click(object sender, EventArgs e)
        {
            FrmAgregarServicioReserva seleccionarServicio = new FrmAgregarServicioReserva(reservaBE.reservaId);
            seleccionarServicio.ShowDialog();
            CargarServicioReserva();
            RefrescarDatosReserva();
        }

        private void FrmDetalleReserva_Load(object sender, EventArgs e)
        {
            CargarHabitacionReserva();
            CargarServicioReserva();
            labelResultadoId.Text = reservaBE.reservaId.ToString();
            labelResultadoDocumento.Text = reservaBE.usuarioDni;
            labelResultadoNombre.Text = reservaBE.reservaNombre;
            labelResultadoTelefono.Text = reservaBE.usuarioTelefono;
            labelResultadoPrecioTotal.Text = reservaBE.precioTotal.ToString("C2");
        }
    }
}
