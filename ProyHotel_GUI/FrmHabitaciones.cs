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
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objHabitacionesBL.listarHabitacion());
            dtv.RowFilter = $"[Habitacion Nombre] like '%{strFiltro}%'";
            dgtDatosHabitaciones.AutoGenerateColumns = false;
            dgtDatosHabitaciones.DataSource = dtv;
            lblRegistroHabitaciones.Text = dgtDatosHabitaciones.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarHabitacion objAgregarHabitacion = new FrmAgregarHabitacion();
                objAgregarHabitacion.ShowDialog();
                CargarDatos(txtFiltroHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmActualizarHabitacion objAgregarHabitacion = new FrmActualizarHabitacion();
                objAgregarHabitacion.Codigo = dgtDatosHabitaciones.CurrentRow.Cells[0].Value.ToString();
                objAgregarHabitacion.ShowDialog();
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("¿Seguro que quiere eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    String strCodigo = dgtDatosHabitaciones.CurrentRow.Cells[0].Value.ToString();
                    if (objHabitacionesBL.EliminarHabitacion(strCodigo))
                    {
                        CargarDatos("");
                    }
                    else
                    {
                        throw new Exception("No se logro la ejecucion consulte a soporte");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltroHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }
    }
}
