using ProyHotel_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHotel_BL;
using ProyHotel_BE;

namespace ProyHotel_GUI
{
    public partial class FrmCrearServicio : Form
    {
        ServicioBL ServicioBL = new();
        public FrmCrearServicio()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator) || ((textboxPrecio.Text.Length > 9 && textboxPrecio.Text.Contains('.')) || (textboxPrecio.Text.Length > 8 && !textboxPrecio.Text.Contains('.')));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioBE nuevoServicio = new ServicioBE(textboxServicio.Text, Convert.ToSingle(textboxPrecio.Text), checkboxDisponible.Checked);
                bool estaCreado = ServicioBL.CrearServicio(nuevoServicio);

                if (estaCreado)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Contacte con soporte tecnico", "Error creando servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textboxServicio_Validating(object sender, CancelEventArgs e)
        {

            if (textboxServicio.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
            }
        }

        private void textboxServicio_Validating_1(object sender, CancelEventArgs e)
        {
            if (textboxServicio.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
            }
        }

        private void textboxPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (textboxPrecio.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
            }
        }
    }
}
