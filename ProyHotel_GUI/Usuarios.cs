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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        UsuarioBL objusuario = new UsuarioBL();
        DataView dtv;
        private void Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void CargarDatos(string filtro)
        {
            dtv = new DataView(objusuario.ListarUsuarios());
            dtv.RowFilter = "Usuario LIKE '%" + filtro + "%'";
            dtgUsuarios.DataSource = dtv;
            txtRegistros.Text = dtgUsuarios.Rows.Count.ToString();
        }

        private void dtgUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgUsuarios.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null & e.Value.ToString() == "ACTIVO")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;

                }
                if (e.Value != null & e.Value.ToString() == "INACTIVO")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtNombre.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuario_Ingresar frm1 = new Usuario_Ingresar();
            frm1.ShowDialog();
            CargarDatos(txtNombre.Text);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Estas seguro de Editar los datos de la fila Selecciona", "Confirmacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Actualizar_Usuario frm1 = new Actualizar_Usuario();
                    frm1.idUsuario = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    frm1.ShowDialog();
                    CargarDatos(txtNombre.Text);
                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar una fila completa");
            }
        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            int id;
            if (dtgUsuarios.SelectedRows.Count > 0)
            {
                id=Convert.ToInt16( dtgUsuarios.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Estas seguro de Bloquear los datos de la fila Selecciona", "Confirmacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (objusuario.BloquearUsuario(id) == true)
                    {
                        MessageBox.Show("Usuario Bloqueado con Exito");
                        CargarDatos(txtNombre.Text);
                    }
                    else
                    {
                        throw new Exception("No se Bloqueo el registro contactar con TI");
                    }
                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar una fila completa");
            }
        }
    }
}
