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
    public partial class FrmActualizarReserva : Form
    {
        ReservasBL objReservasBL = new ReservasBL();
        ReservaBE objReservaBE = new ReservaBE();
        public int Codigo { get; set; }

        public FrmActualizarReserva()
        {
            InitializeComponent();
        }

        private void FrmActualizarReserva_Load(object sender, EventArgs e)
        {
            try
            {
                objReservaBE = objReservasBL.ConsultarReserva(Codigo);
                txtNombre.Text = objReservaBE.reservaNombre;
                txtDNI.Text = objReservaBE.usuarioDni;
                txtTelefono.Text = objReservaBE.usuarioTelefono;
                chkActivo.Checked = objReservaBE.reservaEstado;
                chkPagado.Checked = objReservaBE.estadoPago;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mostrar datos: ", ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTelefono.Text.Trim().Length != 9 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El campo de teléfono tiene que tener 9 dígitos y solo números.", "Validación de Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objReservaBE.reservaNombre = txtNombre.Text.Trim();
            objReservaBE.usuarioTelefono = txtTelefono.Text.Trim();
            objReservaBE.usuarioDni = txtDNI.Text.Trim();
            objReservaBE.reservaEstado = chkActivo.Checked;
            objReservaBE.estadoPago = chkPagado.Checked;
            objReservaBE.usuarioUltimaModificacion = clsCredenciales.id;

            try
            {
                if (objReservasBL.ActualizarReserva(objReservaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("no se realizo la actualizacion, contacta con el soporte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back);

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back);

        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = txtDNI.Text.Trim().Length != 8;
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = txtTelefono.Text.Trim().Length != 9;
        }

        private void FrmActualizarReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
