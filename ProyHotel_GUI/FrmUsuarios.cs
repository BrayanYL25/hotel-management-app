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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        UsuarioBL objusuario = new UsuarioBL();
        private void Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }

        }

        private void CargarDatos(string filtro)
        {
            DataView dataview = new DataView(objusuario.ListarUsuarios());
            dataview.RowFilter = "Usuario LIKE '%" + filtro + "%'";
            dtgUsuarios.DataSource = dataview;
            labelResultados.Text = dtgUsuarios.Rows.Count.ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frmAgregarUsuario = new FrmAgregarUsuario();
            frmAgregarUsuario.ShowDialog();
            CargarDatos("");
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro de Editar los datos de la fila Selecciona", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FrmActualizarUsuario frm1 = new FrmActualizarUsuario();
                frm1.idUsuario = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
                frm1.ShowDialog();
                CargarDatos("");
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtNombre.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}");
            }
        }
    }
}
