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
using ProyHotel_GUI;

namespace ProyHotel_GUI
{
    public partial class FrmActualizarTipoHabitacion : Form
    {
        TipoHabitacionesBL objTipoHabitacionBL = new TipoHabitacionesBL();
        TipoHabitacionBE objTipoHabitacionBE = new TipoHabitacionBE();
        public FrmActualizarTipoHabitacion()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        private void FrmActualizarTipoHabitacion_Load(object sender, EventArgs e)
        {
            try
            {
                

                objTipoHabitacionBE = objTipoHabitacionBL.ConsultarTipoHabitacion(Codigo);
                

                txtNombre.Text = objTipoHabitacionBE.tipo_habitacion_descripcion.ToString();
                precioTipoHabitacion.Value = Convert.ToInt16(objTipoHabitacionBE.tipo_habitacion_precio);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Trim()==String.Empty)
                {
                    throw new Exception("El campo de nombre es obligatorio");
                }
                if(precioTipoHabitacion.Value <= 0 || precioTipoHabitacion.Value > 100000)
                {
                    throw new Exception("El campo del precio debe de ser correcto");
                }

                objTipoHabitacionBE.tipo_habitacion_descripcion = txtNombre.Text.Trim();
                objTipoHabitacionBE.tipo_habitacion_precio = Convert.ToInt16(precioTipoHabitacion.Value);

                if (objTipoHabitacionBL.ActualizarTipoHabitacion(objTipoHabitacionBE)== true)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
