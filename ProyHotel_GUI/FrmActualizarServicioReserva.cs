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
    public partial class FrmActualizarServicioReserva : Form
    {
        ReservaServicioBE reservaServicioBE;
        ReservaServicioBL reservaServicioBL = new();
        int cantidadInicial;

        public FrmActualizarServicioReserva(ReservaServicioBE reservaServicioBE)
        {
            InitializeComponent();
            this.reservaServicioBE = reservaServicioBE;
        }

        private void CargarServicioReservado()
        {
            reservaServicioBE = reservaServicioBL.ConsultarReservaServicio(reservaServicioBE.reservaId, reservaServicioBE.servicioId);
            cantidadInicial = reservaServicioBE.cantidad;
            labelIdReservaRes.Text = reservaServicioBE.reservaId.ToString();
            labelIdServicioRes.Text = reservaServicioBE.servicioId.ToString();
            labelServicioNombresRes.Text = reservaServicioBE.servicioDescripcion.ToString();
            labelPrecioTotal.Text = reservaServicioBE.precioTotal.ToString("C2");
            numericoCantidad.Value = reservaServicioBE.cantidad;
        }

        private void FrmActualizarServicioReserva_Load(object sender, EventArgs e)
        {
            CargarServicioReservado();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (numericoCantidad.Value == cantidadInicial)
            {
                MessageBox.Show("Ya habias reservado la misma cantidad antes.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }
            bool modificado = reservaServicioBL.ActualizarServicioReserva(reservaServicioBE.reservaId, reservaServicioBE.servicioId, Convert.ToInt16(numericoCantidad.Value));

            if (modificado)
            {
                MessageBox.Show("Servicio Reservado Modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Servicio Reservado Modificado Sin Exito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void numericoCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (numericoCantidad.Value == 0)
            {
                numericoCantidad.Value = 1;
            }

            if (reservaServicioBE.servicioPrecio != null)
            {
                float precio = (reservaServicioBE.servicioPrecio ?? 0);
                labelPrecioTotal.Text = ((float) numericoCantidad.Value * precio).ToString("C2");
            }
            else
            {
                labelPrecioTotal.Text = "0";
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
