using ProyHotel_BE;
using ProyHotel_BL;
using ProyVentas_GUI;
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
    public partial class FrmCrearReserva : Form
    {
        ReservasBL reservasBL = new();
        public FrmCrearReserva()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaBE reservaBE = new();
                reservaBE.usuarioId = clsCredenciales.id;
                reservaBE.reservaNombre = textboxNombre.Text;
                reservaBE.usuarioDni = textboxDNI.Text;
                reservaBE.usuarioTelefono = textboxTelefono.Text;

                ReservaBE reservaRealizada = reservasBL.InsertarReserva(reservaBE);

                FrmDetalleReserva frmDetalleReserva = new FrmDetalleReserva(reservaRealizada);
                frmDetalleReserva.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Creando Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
