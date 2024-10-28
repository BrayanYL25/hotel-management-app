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
    public partial class FrmReserva : Form
    {
        public int usuarioId;
        ReservasBL reservasBL = new();

        public FrmReserva()
        {
            InitializeComponent();
        }

        private void CargarDatos(string filtro)
        {
            DataView dataView = new DataView(reservasBL.ListarReserva());
            dataView.RowFilter = $"[DNI] like '%{filtro}%'";
            gridReservas.AutoGenerateColumns = false;
            gridReservas.DataSource = dataView;
            labelResultado.Text = gridReservas.RowCount.ToString();
        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos(textboxBuscar.Text.Trim());
        }

        private void botonRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            FrmCrearReserva frmCrearReserva = new();
            frmCrearReserva.Show();
        }
    }
}
