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
    public partial class Actualizar_Usuario : Form
    {
        public Actualizar_Usuario()
        {
            InitializeComponent();
        }

        UsuarioBL objusuario = new UsuarioBL();
        UsuarioBE objentidades = new UsuarioBE();


        public string idUsuario { get; set; }
        int tipousuario;
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
            cmbUsuario.SelectedIndex = tipousuario;


        }

        private void Actualizar_Usuario_Load(object sender, EventArgs e)
        {
            txtId.Text = idUsuario;
            CargarDatos();
            CargarCombo();
        }
        private void CargarDatos()
        {
            objentidades = objusuario.ConsultarUsuario(Convert.ToInt16(this.idUsuario));
            txtUsuario.Text = objentidades.usuarioNombre;
            txtCorreo.Text = objentidades.usuarioCorreo;
            txtContraseña.Text = objentidades.usuarioContraseña;
            if (objentidades.usuarioEstado == true)
            {
                checkInactivo.Checked = false;
                checkActivo.Checked = true;
            }
            else
            {
                checkInactivo.Checked = true;
                checkActivo.Checked = false;
            }
            tipousuario = objentidades.usuarioTipoId;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length > 0 && txtCorreo.Text.Trim().Length > 0 && txtContraseña.Text.Trim().Length > 0)
                {
                    if (cmbUsuario.SelectedIndex > 0)
                    {
                        objentidades.usuarioId = Convert.ToInt16(txtId.Text.Trim());
                        objentidades.usuarioTipoId = Convert.ToInt16(cmbUsuario.SelectedValue);
                        objentidades.usuarioNombre = txtUsuario.Text.Trim();
                        objentidades.usuarioContraseña = txtContraseña.Text.Trim();
                        if (checkActivo.Checked)
                        {
                            objentidades.usuarioEstado = true;
                        }
                        else
                        {
                            objentidades.usuarioEstado = false;
                        }
                        objentidades.usuarioCorreo = txtCorreo.Text.Trim();
                        if (objusuario.ActualizarUsuario(objentidades) == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("No se Actualizo el registro contactar con TI");
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
    }
}
