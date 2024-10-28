using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//agregar
using ProyHotel_BL;



namespace ProyHotel_GUI
{
    public partial class FrmHabitaciones : Form
    {
        //instancias 
        HabitacionesBL objHabitacionesBL = new HabitacionesBL();
        DataView dtv;


        public FrmHabitaciones()
        {
            InitializeComponent();
        }
        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            //mostrar los datos por defecto al momento de cargar el formulario

            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objHabitacionesBL.listarHabitacion());
            dtv.RowFilter = "[habitacion nombre] like '%" + strFiltro + "%'";

            //relacion form cod
            dgtDatosHabitaciones.DataSource = dtv;
            lblRegistroHabitaciones.Text = dgtDatosHabitaciones.Rows.Count.ToString();


        }
        private void txtFiltroHabitacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltroHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }





        //cerrar el formulario
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                //codigo
                //instanciamos
                FrmAgregarHabitacion objAgregarHabitacion = new FrmAgregarHabitacion();
                objAgregarHabitacion.ShowDialog();//evita que habras mas ventanas 

                //despues de cerrar actualizar
                CargarDatos(txtFiltroHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //codigo
                //instanciamos
                FrmActualizarHabitacion objAgregarHabitacion = new FrmActualizarHabitacion();
                objAgregarHabitacion.Codigo = dgtDatosHabitaciones.CurrentRow.Cells[0].Value.ToString();
                objAgregarHabitacion.ShowDialog();//evita que habras mas ventanas 

                //despues de cerrar actualizar
                CargarDatos(txtFiltroHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("Seguro que quiere eliminar este registro", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    String strCodigo = dgtDatosHabitaciones.CurrentRow.Cells[0].Value.ToString();
                    if(objHabitacionesBL.EliminarHabitacion(strCodigo) == true)
                    {
                        CargarDatos(txtFiltroHabitacion.Text.Trim());
                    }
                    else
                    {
                        throw new Exception("No se logro la ejecucion consulte a soporte");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
            }
        }
    }
}
