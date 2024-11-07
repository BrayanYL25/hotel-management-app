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
    public partial class FrmHuespedes : Form
    {

        HuespedBL objHuespedBL = new HuespedBL();
        DataView dtv;

        public FrmHuespedes()
        {
            InitializeComponent();
        }

        private void FrmHuespedes_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objHuespedBL.listarHuesped());
            dtv.RowFilter = $"Nombre like '%{strFiltro}%'";
            dgtDatosHuesped.DataSource = dtv;
            lblRegistroHuesped.Text = dgtDatosHuesped.Rows.Count.ToString();
        }

        private void btnAgregarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarHuesped objAgregarHabitacion = new FrmAgregarHuesped();
                objAgregarHabitacion.ShowDialog();
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }

        private void btnActualizarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                FrmActualizarHuesped objActualizarHuesped = new FrmActualizarHuesped();
                objActualizarHuesped.Codigo = dgtDatosHuesped.CurrentRow.Cells[0].Value.ToString();
                objActualizarHuesped.ShowDialog();
                CargarDatos("");
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
                    String strCodigo = dgtDatosHuesped.CurrentRow.Cells[0].Value.ToString();
                    if (objHuespedBL.EliminarHuesped(strCodigo) == true)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }
    }
}