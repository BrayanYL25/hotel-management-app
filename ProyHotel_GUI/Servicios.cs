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
    public partial class Servicios : Form
    {
        ServicioBL servicioBusiness = new();
        DataView dataView;

        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            gridServicios.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(string filtro)
        {
            dataView = new DataView(servicioBusiness.ListarServicio());
            dataView.RowFilter = $"[Servicio Descripcion] like '%{filtro}%'";
            gridServicios.DataSource = dataView;
            recordsCount.Text = gridServicios.Rows.Count.ToString();

        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            CrearServicio crearServicio = new();
            crearServicio.Show();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            EditarServicio editarServicio = new();
            editarServicio.id = Convert.ToInt16(gridServicios.CurrentRow.Cells[0].Value.ToString());
            editarServicio.Show();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            ServicioBL servicioBL = new();
            int id = Convert.ToInt16(gridServicios.CurrentRow.Cells[0].Value.ToString());
            servicioBL.BorrarServicio(id);
            CargarDatos("");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos(buscarServicioTextbox.Text);
        }

        private void botonRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos("");
        }
    }
}
