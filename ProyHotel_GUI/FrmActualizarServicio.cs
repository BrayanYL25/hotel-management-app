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
    public partial class FrmActualizarServicio : Form
    {
        ServicioBE servicioBE;
        ServicioBL servicioBL = new();
        public int id { get; set; }

        public FrmActualizarServicio()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxPrecio.Text.Trim() == String.Empty || textboxServicio.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("No se puede omitir ningun campo", "Campos Invaidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ServicioBE servicioBE = new ServicioBE(
                    Convert.ToInt16(labelId.Text),
                    textboxServicio.Text,
                    Convert.ToSingle(textboxPrecio.Text),
                    checkboxDisponible.Checked);

                servicioBL.ActualizarServicio(servicioBE);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Contacte con Soporte tecnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EditarServicio_Load(object sender, EventArgs e)
        {
            ServicioBE servicioBE = servicioBL.ConsultarServicio(this.id);
            labelId.Text = servicioBE.servicioId.ToString();
            textboxServicio.Text = servicioBE.servicioDescripcion.ToString();
            textboxPrecio.Text = servicioBE.servicioPrecio.ToString();
            checkboxDisponible.Checked = servicioBE.servicioEstado;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
