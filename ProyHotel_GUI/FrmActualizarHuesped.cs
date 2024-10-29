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
using ProyHotel_BE;
using ProyHotel_BL;

namespace ProyHotel_GUI
{
    public partial class FrmActualizarHuesped : Form
    {
        HuespedBL objHuespedBL = new HuespedBL();
        HuespedBE objHuespedBE = new HuespedBE();
        public FrmActualizarHuesped()
        {
            InitializeComponent();
        }

        //recibe la referencia para editar el producto
        public String Codigo { get; set; }

        private void FrmActualizarHuesped_Load(object sender, EventArgs e)
        {
            try
            {
                //creamos el obj para que pueda mostrarse y actualizar
                objHuespedBE = objHuespedBL.ConsultarHuesped(Codigo);

                //creamos 
                lblidHuesped.Text = "id: " + objHuespedBE.huesped_id.ToString();
                txtNombre.Text = objHuespedBE.huesped_nombre.ToString();
                txtTelefono.Text = objHuespedBE.huesped_telefono.ToString();
                txtDni.Text = objHuespedBE.huesped_dni.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mostrar datos:  " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // + codigo

                #region VALIDACIONES
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo de nombre es obligatoria");
                }
                if (txtTelefono.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo de telefono es obligatoria");
                }
                else if (txtTelefono.Text.Trim().Length != 9 || !txtTelefono.Text.All(char.IsDigit))
                {
                    throw new Exception("El campo de telefono tiene que tener 9 digitos");
                }
                if (txtDni.Text.Trim() == String.Empty)
                {
                    throw new Exception("El DNI es obligatorio");
                }
                else if (txtDni.Text.Trim().Length != 8 || !txtTelefono.Text.All(char.IsDigit))
                {
                    throw new Exception("El campo de DNI tiene que tener 8 digitos");
                }
                #endregion 

                //si todo esta OK .. . cargamos el obj 
                objHuespedBE.huesped_nombre = txtNombre.Text.Trim();
                objHuespedBE.huesped_telefono = Convert.ToInt32(txtTelefono.Text).ToString();
                objHuespedBE.huesped_dni = Convert.ToInt32(txtDni.Text).ToString();
                objHuespedBE.fecha_ult_modificacion = DateTime.Now;//asigna la fecha de hoy 


                //usuario que registro
                //objHabitacionBE.Usuario_registro = "vincent";
                if (objHuespedBL.ActualizarHuesped(objHuespedBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("no se realizo la actualizacion, contactate con soporte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtTelefono.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (txtDni.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
