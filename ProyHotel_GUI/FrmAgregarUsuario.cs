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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }
        UsuarioBL objusuario = new UsuarioBL();
        UsuarioBE objusuarioEntidades = new UsuarioBE();
        private void Usuario_Ingresar_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            DataTable dt = objusuario.ListarTipoUsuario();
            DataRow dr;
            dr = dt.NewRow();
            dr["tipo_usuario_id"] = 0;
            dr["tipo_usuario_descripcion"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);
            cmbUsuario.DataSource = dt;
            cmbUsuario.ValueMember = "tipo_usuario_id";
            cmbUsuario.DisplayMember = "tipo_usuario_descripcion";



        }

        private void checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkActivo.Checked)
            {
                checkInactivo.Checked = false;
            }
        }

        private void checkInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInactivo.Checked)
            {
                checkActivo.Checked = false;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsuario.Text.Trim().Length > 0 && txtCorreo.Text.Trim().Length > 0 && txtContraseña.Text.Trim().Length > 0)
                {
                    if (cmbUsuario.SelectedIndex > 0)
                    {
                        objusuarioEntidades.usuarioTipoId = Convert.ToInt16(cmbUsuario.SelectedValue);
                        objusuarioEntidades.usuarioNombre = txtUsuario.Text.Trim();
                        objusuarioEntidades.usuarioContraseña = txtContraseña.Text.Trim();
                        if (checkActivo.Checked)
                        {
                            objusuarioEntidades.usuarioEstado = true;
                        }
                        else
                        {
                            objusuarioEntidades.usuarioEstado = false;
                        }
                        objusuarioEntidades.usuarioCorreo = txtCorreo.Text.Trim();
                        if (objusuario.InsertarUsuario(objusuarioEntidades) == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("No se inserto el registro contactar con TI");
                        }
                    }
                    else
                    {
                        throw new Exception("Debe seleccionar un tipo de Usuario");
                    }
                    
                }
                else
                {
                    throw new Exception("Debe llenar los campos correctamente");
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            

        }
    }
}
