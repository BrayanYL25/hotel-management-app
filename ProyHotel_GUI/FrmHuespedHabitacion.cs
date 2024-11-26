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

    public partial class FrmHuespedHabitacion : Form
    {
        ReservaHabitacionHuespedBL reservaHabitacionHuespedBL = new();
        int reservaId;
        int habitacionId;
        int huespedId;
        string nombre;

        public FrmHuespedHabitacion(int reservaId, int habitacionId, int huespedId, string nombre)
        {
            InitializeComponent();
            this.reservaId = reservaId;
            this.habitacionId = habitacionId;
            this.huespedId = huespedId;
            this.nombre = nombre;
        }

        private void FrmHuespedHabitacion_Load(object sender, EventArgs e)
        {
            labelCodigo.Text = huespedId.ToString();
            labelNombre.Text = nombre;
        }

        private void botonAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                bool asistencia = checkboxAsistencia.Checked;
                string comentario = textboxComentario.Text;
                reservaHabitacionHuespedBL.InsertarReservaHabitacionHuesped(reservaId, habitacionId, huespedId, asistencia, comentario);
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
