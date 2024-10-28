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
//agregar
using ProyHotel_BE;
using ProyHotel_BL;


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

        //recibe la referencia para poder editar el procucto
        public String Codigo { get; set; }

        private void FrmActualizarHabitacion_Load(object sender, EventArgs e)
        {
            try
            {
                //codigo
                DataTable dt = objTipoHabitacionesBL.ListarTipoHabitaciones();
                DataRow dr;


                dr = dt.NewRow();
                dr["tipo_habitacion_id"] = 0;
                dr["tipo_habitacion_descripcion"] = "--seleccione--";
                dt.Rows.InsertAt(dr, 0);

                cboTipo.DataSource = dt;
                cboTipo.ValueMember = "tipo_habitacion_id";
                cboTipo.DisplayMember = "tipo_habitacion_descripcion";


                //mas codigo para mostrar los datos que obtenemos del codigo del id seleccionado
                //consultamos el procucto



                objHabitacionBE = objHabitacionBL.ConsultarHabitacion(Codigo);

                //mostramos los datos del producto
                lblIdHabitacion.Text = objHabitacionBE.habitacion_id.ToString();
                lblIdTipoHabitacion.Text = objHabitacionBE.tipo_habitacion_id.ToString();
                txtPrecio.Text = objHabitacionBE.precio_noche.ToString();
                txtAforo.Text = objHabitacionBE.habitacion_aforo.ToString();
                txtNombre.Text = objHabitacionBE.habitacion_nombre.ToString();
                chkActivo.Checked = Convert.ToBoolean(objHabitacionBE.estado_habitacion);
                cboTipo.SelectedValue = objHabitacionBE.tipo_habitacion_id;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:kugfut " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //codigo 
                //validamos

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo de nombre es obligatoria");
                }
                if (cboTipo.SelectedIndex == 0)
                {
                    throw new Exception("El campo de Tipo es obligatoria");
                }
                if (txtPrecio.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Precio es obligatorio");
                }

                //si todo esta OK .. . cargamos el obj 
                objHabitacionBE.habitacion_id = Convert.ToInt16(lblIdHabitacion.Text);
                objHabitacionBE.habitacion_nombre = txtNombre.Text.Trim();
                objHabitacionBE.tipo_habitacion_id = Convert.ToInt16(cboTipo.SelectedIndex);
                objHabitacionBE.precio_noche = Convert.ToSingle(txtPrecio.Text);
                objHabitacionBE.estado_habitacion = Convert.ToInt16(chkActivo.Checked);
                objHabitacionBE.habitacion_aforo = Convert.ToInt16(txtAforo.Text);


                //usuario que registro
                //objHabitacionBE.Usuario_registro = "cbrayan";
                if (objHabitacionBL.ActualizarHabitacion(objHabitacionBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("no se realizo la insercion contactate con soporte");
                }





            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: asdasdasd " + ex.Message);
            }
        }
    }
}
