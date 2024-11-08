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
    public partial class FrmActualizarTipoUsuario : Form
    {
        TipoUsuarioBL tipoUsuarioBL = new();
        int idTipoUsuario;
        public FrmActualizarTipoUsuario(int idTipoUsuario)
        {
            InitializeComponent();
            this.idTipoUsuario = idTipoUsuario;
        }

        private void CargarTipoUsuario()
        {
            TipoUsuarioBE tipoUsuarioBE = tipoUsuarioBL.ConsultarTipoUsuario(idTipoUsuario);
            textboxTipoUsuario.Text = tipoUsuarioBE.tipoUsuarioDescripcion;
        }

        private void FrmActualizarTipoUsuario_Load(object sender, EventArgs e)
        {
            labelIdReserva.Text = idTipoUsuario.ToString();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            TipoUsuarioBE tipoUsuarioBE = new();
            tipoUsuarioBE.tipoUsuarioId = idTipoUsuario;
            tipoUsuarioBE.tipoUsuarioDescripcion = textboxTipoUsuario.Text;

            try
            {
                bool seActualizo = tipoUsuarioBL.ActualizarTipoUsuario(tipoUsuarioBE);
                if (!seActualizo)
                {
                    throw new Exception("No se actualizo correctamente");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }
    }
}
