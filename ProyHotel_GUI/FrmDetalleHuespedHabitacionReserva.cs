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
    public partial class FrmDetalleHuespedHabitacionReserva : Form
    {
        private ReservaHabitacionHuespedBL reservaHabitacionHuespedBL = new();
        public int reservaId;
        public int habitacionId;
        public string habitacionNombre;
        public FrmDetalleHuespedHabitacionReserva(int reservaId, int habitacionId, string habitacionNombre)
        {
            InitializeComponent();
            this.reservaId = reservaId;
            this.habitacionId = habitacionId;
            this.habitacionNombre = habitacionNombre;
        }

        private void CargarDatos()
        {
            DataView dataView = new DataView(reservaHabitacionHuespedBL.ListarReservaHabitacionHuesped(5, 1));
            gridHuespedes.AutoGenerateColumns = false;
            gridHuespedes.DataSource = dataView;
        }

        private void FrmDetalleHuespedHabitacionReserva_Load(object sender, EventArgs e)
        {
            CargarDatos();
            labelNombreHabitacion.Text = habitacionNombre;
            labelIdReserva.Text = reservaId.ToString();
        }
    }
}
