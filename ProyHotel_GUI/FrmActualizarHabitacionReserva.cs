using ProyHotel_BE;
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
    public partial class FrmActualizarHabitacionReserva : Form
    {
        ReservaHabitacionBE reservaHabitacionBE;
        ReservaHabitacionesBL reservaHabitacionesBL = new();
        public FrmActualizarHabitacionReserva(ReservaHabitacionBE reservaHabitacionBE)
        {
            InitializeComponent();
            this.reservaHabitacionBE = reservaHabitacionBE;
        }
        private void cargarHabitacionReservada()
        {
            reservaHabitacionBE = reservaHabitacionesBL.ConsultarHabitacionServicio(reservaHabitacionBE.reservaId, reservaHabitacionBE.habitacionId);
            lblReservaId.Text = reservaHabitacionBE.reservaId.ToString();
            lblHabitacionId.Text = reservaHabitacionBE.habitacionId.ToString();
            lblTipoHabitacion.Text = reservaHabitacionBE.tipoHabitacion.ToString();
            lblHabitacion.Text = reservaHabitacionBE.habitacionNombre.ToString();
            lblPrecioNoche.Text = reservaHabitacionBE.costoNoche.ToString("C2");
            lblPrecioTotal.Text = reservaHabitacionBE.precioTotal.ToString("C2");
        }

        private void FrmActualizarHabitacionReserva_Load(object sender, EventArgs e)
        {
            cargarHabitacionReservada();
        }
    }
}
