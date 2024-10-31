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
        HabitacionesBL habitacionesBL = new();
        public FrmAgregarReservaHabitacion()
        {
            InitializeComponent();
        }

        private List<TipoHabitacionBE> CargarTipoHabitacion()
        {
            DataTable dataTable = tipoHabitacionesBL.ListarTipoHabitaciones();
            List<TipoHabitacionBE> listaHabitacion = new List<TipoHabitacionBE>();
            DataRow dataRow = dataTable.NewRow();
            dataRow["tipo_habitacion_id"] = "0";
            dataRow["tipo_habitacion_descripcion"] = "--Seleccione--";
            dataTable.Rows.InsertAt(dataRow, 0);
            foreach (DataRow row in dataTable.Rows)
            {
                TipoHabitacionBE tipoHabitacionBE = new();
                tipoHabitacionBE.tipo_habitacion_id = Convert.ToInt16(row["tipo_habitacion_id"]);
                tipoHabitacionBE.tipo_habitacion_descripcion = row["tipo_habitacion_descripcion"].ToString();

                listaHabitacion.Add(tipoHabitacionBE);
            }
            return listaHabitacion;
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

        // Evento On Value Changed
        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AgregarReservaHabitacion_Load(object sender, EventArgs e)
        {
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
        }
    }
}
