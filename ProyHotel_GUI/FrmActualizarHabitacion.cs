using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHotel_BE;
using ProyHotel_BL;
using ProyVentas_GUI;


namespace ProyHotel_GUI
{
    public partial class FrmActualizarHabitacion : Form
    {
        HabitacionesBL objHabitacionBL = new HabitacionesBL();
        HabitacionBE objHabitacionBE = new HabitacionBE();
        TipoHabitacionesBL objTipoHabitacionesBL = new TipoHabitacionesBL();

        public FrmActualizarHabitacion()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void FrmActualizarHabitacion_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objTipoHabitacionesBL.ListarTipoHabitaciones();
                DataRow dr;


                dr = dt.NewRow();
                dr["tipo_habitacion_id"] = 0;
                dr["tipo_habitacion_descripcion"] = "--seleccione--";
                dt.Rows.InsertAt(dr, 0);

                cboTipo.DataSource = dt;
                cboTipo.ValueMember = "tipo_habitacion_id";
                cboTipo.DisplayMember = "tipo_habitacion_descripcion";


                objHabitacionBE = objHabitacionBL.ConsultarHabitacion(Codigo);

                lblIdHabitacion.Text = objHabitacionBE.habitacion_id.ToString();
                numericoAforo.Value = objHabitacionBE.habitacion_aforo;
                txtNombre.Text = objHabitacionBE.habitacion_nombre.ToString();
                chkActivo.Checked = Convert.ToBoolean(objHabitacionBE.estado_habitacion);
                cboTipo.SelectedValue = objHabitacionBE.tipo_habitacion_id;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:kugfut " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo de nombre es obligatoria");
                }
                if (cboTipo.SelectedIndex == 0)
                {
                    throw new Exception("El campo de Tipo es obligatoria");
                }


                objHabitacionBE.habitacion_id = Convert.ToInt16(lblIdHabitacion.Text);
                objHabitacionBE.habitacion_nombre = txtNombre.Text.Trim();
                objHabitacionBE.tipo_habitacion_id = Convert.ToInt16(cboTipo.SelectedIndex);
                objHabitacionBE.estado_habitacion = Convert.ToInt16(chkActivo.Checked);
                objHabitacionBE.habitacion_aforo = Convert.ToInt16(numericoAforo.Value);

                bool ok = objHabitacionBL.ActualizarHabitacion(objHabitacionBE, clsCredenciales.id);
                if (ok)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }

        private void numericoAforo_ValueChanged(object sender, EventArgs e)
        {
            if (numericoAforo.Value == 0)
            {
                numericoAforo.Value = 1;
            }
        }
    }
}
