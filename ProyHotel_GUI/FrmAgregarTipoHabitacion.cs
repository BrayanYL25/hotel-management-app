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
    public partial class FrmAgregarTipoHabitacion : Form
    {
        TipoHabitacionBE objTipoHabitacionBE = new TipoHabitacionBE();
        TipoHabitacionesBL objTipoHabitacionBL = new TipoHabitacionesBL();

        public FrmAgregarTipoHabitacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAgregarTipoHabitacion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo del nombre es obligatorio");
                }
                if (precioTipoHabitacion.Value <= 0 || precioTipoHabitacion.Value > 100000)
                {
                    throw new Exception("El campo del precio debe de ser correcto");
                }

                objTipoHabitacionBE.tipo_habitacion_descripcion = txtNombre.Text.Trim();
                objTipoHabitacionBE.tipo_habitacion_precio = Convert.ToInt16(precioTipoHabitacion.Value);

                if (objTipoHabitacionBL.InsertarTipoHabitacion(objTipoHabitacionBE)==true)
                {
                    this.Close ();
                }
                else
                {
                    throw new Exception("No se realizo la insercion consulte a soporte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error:  {ex.Message}");
            }
        }

    }
}
