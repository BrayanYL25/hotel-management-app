using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyHotel_BE;
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
            DataView dataView = new DataView(reservaHabitacionHuespedBL.ListarReservaHabitacionHuesped(this.reservaId, this.habitacionId));
            gridHuespedes.AutoGenerateColumns = false;
            gridHuespedes.DataSource = dataView;
        }

        private void FrmDetalleHuespedHabitacionReserva_Load(object sender, EventArgs e)
        {
            CargarDatos();
            labelNombreHabitacion.Text = habitacionNombre;
            labelIdReserva.Text = reservaId.ToString();
        }

        private void botonBorrarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridHuespedes.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("La celda seleccionada está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cellValue = gridHuespedes.SelectedCells[0].OwningRow.Cells[0].Value ?? throw new Exception("No se hallo el valor seleccionado.");
                var huespedId = Convert.ToInt16(cellValue);

                DialogResult confirmarBorrado = MessageBox.Show("¿Seguro que desea eliminar este huésped?", "Eliminar Huesped de Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarBorrado == DialogResult.Yes)
                {
                    reservaHabitacionHuespedBL.BorrarReservaHabitacionHuesped(reservaId, habitacionId, huespedId);
                    CargarDatos();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show($"Hubo un error {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
