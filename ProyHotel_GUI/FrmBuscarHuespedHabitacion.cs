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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyHotel_GUI
{
    public partial class FrmBuscarHuespedHabitacion : Form
    {
        HuespedBL huespedBL = new();
        DataView searchedTable = new DataView();
        readonly int reservaId;
        int habitacionId;

        public FrmBuscarHuespedHabitacion(int reservaId, int habitacionId)
        {
            InitializeComponent();
            this.reservaId = reservaId;
            this.habitacionId = habitacionId;
        }

        private void ObtenerHuespedes(string filtro)
        {
            searchedTable = new DataView(huespedBL.listarHuesped());
            datagridviewHuespedes.AutoGenerateColumns = false;
            searchedTable.RowFilter = $"Nombre LIKE '%{filtro}%'";
            datagridviewHuespedes.DataSource = searchedTable;
        }

        private void FrmAsignarHuespedHabitacion_Load(object sender, EventArgs e)
        {
            ObtenerHuespedes("");
        }

        private void botonAsignar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt16(datagridviewHuespedes.CurrentRow.Cells[0].Value);
            var nombre = datagridviewHuespedes.CurrentRow.Cells[1].Value.ToString();
            FrmHuespedHabitacion frmHuespedHabitacion = new(reservaId, habitacionId, id, nombre);
            frmHuespedHabitacion.ShowDialog();
            this.Close();
        }

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            ObtenerHuespedes(textboxSearch.Text);
        }
    }
}
