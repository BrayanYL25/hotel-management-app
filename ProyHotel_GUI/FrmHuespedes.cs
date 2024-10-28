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
            //mostrar los datos por defecto

            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objHuespedBL.listarHuesped());
            dtv.RowFilter = "Nombre like '%" + strFiltro + "%'";

            //relacion form cod
            dgtDatosHuesped.DataSource = dtv;
            lblRegistroHuesped.Text = dgtDatosHuesped.Rows.Count.ToString();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                //codigo
                //instanciamos
                FrmrAgregarHuesped objAgregarHabitacion = new FrmrAgregarHuesped();
                objAgregarHabitacion.ShowDialog();//evita que habras mas ventanas 

                //despues de cerrar actualizar
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                ////codigo
                ////instanciamos
                //FrmActualizarHuesped objAgregarHuesped = new FrmActualizarHuesped();
                //objAgregarHuesped.Codigo = dgtDatosHuesped.CurrentRow.Cells[0].Value.ToString();
                //objAgregarHuesped.ShowDialog();//evita que habras mas ventanas 

                ////despues de cerrar actualizar
                //CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}