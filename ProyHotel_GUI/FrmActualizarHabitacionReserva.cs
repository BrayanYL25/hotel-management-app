using ProyHotel_ADO;
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
        int admitedChanges = 0;
        DateTime fechaCheckInInicio;
        DateTime fechaCheckOutInicio;
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
            dtpCheckIn.Value = reservaHabitacionBE.fechaEntrada;
            dtpCheckOut.Value = reservaHabitacionBE.fechaSalida;

            fechaCheckInInicio = reservaHabitacionBE.fechaEntrada;
            fechaCheckOutInicio = reservaHabitacionBE.fechaEntrada;
            admitedChanges++;
        }

        private void FrmActualizarHabitacionReserva_Load(object sender, EventArgs e)
        {
            cargarHabitacionReservada();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de entrada", "Error");
                return;
            }

            bool modificado = reservaHabitacionesBL.ActualizarHabitacionReserva(reservaHabitacionBE.reservaId, reservaHabitacionBE.habitacionId, dtpCheckIn.Value, dtpCheckOut.Value);
            if (!modificado)
            {
                MessageBox.Show("Habitación Reservada Modificada Sin Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalcularPrecioEstadia(DateTime checkin, DateTime checkout)
        {
            TimeSpan diferencia = checkout.Date - checkin.Date;
            int diasEstadia = diferencia.Days;

            if (diasEstadia < 1)
            {
                throw new Exception("La fecha de check-out debe ser al menos un día después del check-in.");
            }

            float precioNoche = reservaHabitacionBE.costoNoche;
            float precioTotal = precioNoche * diasEstadia;

            lblPrecioTotal.Text = precioTotal.ToString("C2");
            reservaHabitacionBE.precioTotal = precioTotal;
        }



        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                admitedChanges++;
                CalcularPrecioEstadia(dtpCheckIn.Value, dtpCheckOut.Value);
            }
            catch (Exception ex)
            {
                if (admitedChanges > 1)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                admitedChanges++;
                CalcularPrecioEstadia(dtpCheckIn.Value, dtpCheckOut.Value);
            }
            catch (Exception ex)
            {
                if (admitedChanges > 1)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
    }
}
