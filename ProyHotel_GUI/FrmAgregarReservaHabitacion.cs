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
    public partial class FrmAgregarReservaHabitacion : Form
    {
        TipoHabitacionesBL tipoHabitacionesBL = new();
        List<TipoHabitacionBE> listaTipoHabitacion;
        HabitacionesBL habitacionesBL = new();
        int reservaId;
        public FrmAgregarReservaHabitacion(int reservaId)
        {
            InitializeComponent();
            this.reservaId = reservaId;
        }

        private List<TipoHabitacionBE> CargarTipoHabitacion()
        {
            DataTable dataTable = tipoHabitacionesBL.ListarTipoHabitaciones();
            listaTipoHabitacion = [];
            DataRow dataRow = dataTable.NewRow();
            dataRow["tipo_habitacion_id"] = "0";
            dataRow["costo_noche"] = "0";
            dataRow["tipo_habitacion_descripcion"] = "--Seleccione--";
            dataTable.Rows.InsertAt(dataRow, 0);
            foreach (DataRow row in dataTable.Rows)
            {
                TipoHabitacionBE tipoHabitacionBE = new();
                tipoHabitacionBE.tipo_habitacion_id = Convert.ToInt16(row["tipo_habitacion_id"]);
                tipoHabitacionBE.tipo_habitacion_precio = Convert.ToSingle(row["costo_noche"]);
                tipoHabitacionBE.tipo_habitacion_descripcion = row["tipo_habitacion_descripcion"].ToString();

                listaTipoHabitacion.Add(tipoHabitacionBE);
            }
            return listaTipoHabitacion;
        }

        public List<HabitacionBE> CargarHabitaciones(int tipoHabitacionId)
        {
            DataTable dataTable = habitacionesBL.ListarHabitacionTipo(tipoHabitacionId);
            List<HabitacionBE> listaHabitacion = new List<HabitacionBE>();
            DataRow dataRow = dataTable.NewRow();
            dataRow["Habitacion Id"] = "0";
            dataRow["Habitacion Nombre"] = "--Seleccione--";
            dataTable.Rows.InsertAt(dataRow, 0);
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Estado Numero"].ToString().Equals("0"))
                {
                    continue;
                }
                HabitacionBE habitacionBE = new();
                habitacionBE.habitacion_id = Convert.ToInt16(row["Habitacion Id"]);
                habitacionBE.habitacion_nombre = row["Habitacion Nombre"].ToString();
                listaHabitacion.Add(habitacionBE);
            }
            return listaHabitacion;
        }

        private void AgregarReservaHabitacion_Load(object sender, EventArgs e)
        {
            dtpCheckIn.ShowUpDown = false;
            dtpCheckOut.ShowUpDown = false;
            lblReservaId.Text = reservaId.ToString();
            cbxTipoHabitacion.DataSource = CargarTipoHabitacion();
            cbxTipoHabitacion.DisplayMember = "tipo_habitacion_descripcion";
            cbxTipoHabitacion.ValueMember = "tipo_habitacion_id";
        }

        private void cbxTipoHabitacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboboxHabitacion.Enabled = true;
            comboboxHabitacion.DataSource = CargarHabitaciones(Convert.ToInt16(cbxTipoHabitacion.SelectedValue));
            comboboxHabitacion.DisplayMember = "habitacion_nombre";
            comboboxHabitacion.ValueMember = "habitacion_id";
            lblPrecioEstadia.Text = "S/";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de entrada", "Error");
                dtpCheckOut.Value = dtpCheckIn.Value;
            }
            TimeSpan diferencia = dtpCheckOut.Value - dtpCheckIn.Value;
            if (cbxTipoHabitacion.SelectedItem is TipoHabitacionBE tipoHabitacionBE)
            {
                lblPrecioEstadia.Text = (tipoHabitacionBE.tipo_habitacion_precio * (int)diferencia.Days).ToString("C2");
            }
        }

        private void cbxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPrecioNoche.Text = listaTipoHabitacion[cbxTipoHabitacion.SelectedIndex].tipo_habitacion_precio.ToString("C2");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpCheckIn.Value.Date.Add(new TimeSpan(14, 0, 0));
            DateTime checkOut = dtpCheckOut.Value.Date.Add(new TimeSpan(12, 0, 0));
            try
            {
                if (comboboxHabitacion.SelectedItem is not HabitacionBE || comboboxHabitacion.SelectedIndex == 0)
                {
                    throw new Exception("No seleccionaste una habitacion");
                }
                int habitacionId = ((HabitacionBE)comboboxHabitacion.SelectedItem).habitacion_id;
                ReservaHabitacionBE reservaHabitacionBE = new();
                reservaHabitacionBE.reservaId = this.reservaId;
                reservaHabitacionBE.habitacionId = habitacionId;
                reservaHabitacionBE.fechaEntrada = checkIn;
                reservaHabitacionBE.fechaSalida = checkOut;
                ReservaHabitacionesBL reservaHabitacionesBL = new();

                bool confirmado = reservaHabitacionesBL.AgregarHabitacionReserva(reservaHabitacionBE);
                if (confirmado)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                DateTime reference = dtpCheckIn.Value;
                dtpCheckOut.Value = reference.Date.AddDays(2);
            }
            TimeSpan diferencia = dtpCheckOut.Value - dtpCheckIn.Value;
            if (cbxTipoHabitacion.SelectedItem is TipoHabitacionBE tipoHabitacionBE)
            {
                lblPrecioEstadia.Text = (tipoHabitacionBE.tipo_habitacion_precio * (int)diferencia.Days).ToString("C2");
            }
        }
    }
}
