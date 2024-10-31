using ProyHotel_BE;
using ProyHotel_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyHotel_GUI
{
    public partial class FrmAgregarHuesped : Form
    {
        HuespedBL objHuespedBL = new HuespedBL();
        HuespedBE objHuespedBE = new HuespedBE();
        public FrmAgregarHuesped()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // + codigo
                //mostrar fecha de referencia para que el usuario sepa que tambien se registra la fecha
                lblFechaaaa.Text = "Fecha actual: " + DateTime.Now;

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
                if (TxtDni.Text.Trim() == String.Empty)
                {
                    throw new Exception("El DNI es obligatorio");
                }
                else if (TxtDni.Text.Trim().Length != 8 || !txtTelefono.Text.All(char.IsDigit))
                {
                    throw new Exception("El campo de DNI tiene que tener 8 digitos");
                }
                #endregion 

                //si todo esta OK .. . cargamos el obj 
                objHuespedBE.huesped_nombre = txtNombre.Text.Trim();
                objHuespedBE.huesped_telefono = Convert.ToInt32(txtTelefono.Text).ToString();
                objHuespedBE.huesped_dni = Convert.ToInt32(TxtDni.Text).ToString();
                objHuespedBE.fecha_creacion = DateTime.Now;//asigna la fecha de hoy 


                //usuario que registro
                //objHabitacionBE.Usuario_registro = "vincent";
                if (objHuespedBL.InsertarHuesped(objHuespedBE) == true)
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
        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (TxtDni.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmrAgregarHuesped_Load(object sender, EventArgs e)
        {
            lblFechaaaa.Text = "Fecha actual: " + DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
