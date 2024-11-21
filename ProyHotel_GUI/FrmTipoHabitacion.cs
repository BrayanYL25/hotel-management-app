using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//usar
using ProyHotel_BL;

namespace ProyHotel_GUI
{
    public partial class FrmTipoHabitacion : Form
    {
        //instancias
        TipoHabitacionesBL objTipoHabitaciones = new TipoHabitacionesBL();
        DataView dtv;


        public FrmTipoHabitacion()
        {
            InitializeComponent();
        }

        private void FrmTipoHabitacion_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objTipoHabitaciones.ListarTipoHabitaciones());
            dtv.RowFilter = $"[tipo_habitacion_descripcion] like '%{strFiltro}%'";
            //dgtDatosTipoHabitacion.AutoGenerateColumns = false;
            dgtDatosTipoHabitacion.DataSource = dtv;
            lblRegistroTipoHabitaciones.Text = dgtDatosTipoHabitacion.Rows.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltroTipoHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }

        private void btnAgregarTipoHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarTipoHabitacion objAgregarTipoHabitacion = new FrmAgregarTipoHabitacion();
                objAgregarTipoHabitacion.ShowDialog();
                CargarDatos(txtFiltroTipoHabitacion.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("¿Seguro que quieres eliminar este registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    String strCodigo = dgtDatosTipoHabitacion.CurrentRow.Cells[0].Value.ToString();
                    if (objTipoHabitaciones.EliminarTipoHabitacion(strCodigo))
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmActualizarTipoHabitacion objAgregarTipoHabitacion = new FrmActualizarTipoHabitacion();
                objAgregarTipoHabitacion.Codigo = dgtDatosTipoHabitacion.CurrentRow.Cells[0].Value.ToString();
                objAgregarTipoHabitacion.ShowDialog();
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error {ex.Message}");
            }
        }

        private void dgtDatosTipoHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
