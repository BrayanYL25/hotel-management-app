using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHotel_BL;

namespace ProyHotel_GUI
{
    public partial class FrmTipoUsuario : Form
    {
        TipoUsuarioBL tipoUsuarioBL = new();

        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void CargarDatos(string filtro)
        {
            DataView dataView = new DataView(tipoUsuarioBL.ListarTipoUsuario());
            dataView.RowFilter = "[tipo_usuario_descripcion] like '%" + filtro + "%'";

            gridTipoUsuario.DataSource = dataView;
            labelCantidadRegistros.Text = gridTipoUsuario.Rows.Count.ToString();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos(textboxTipoUsuario.Text);
        }
    }
}
