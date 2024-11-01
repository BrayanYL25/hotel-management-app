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
using ProyHotel_BE;

namespace ProyHotel_GUI
{
    public partial class FrmAgregarServicioReserva : Form
    {
        ServicioBL servicioBusiness = new();
        ReservaServicioBL reservaServicioBL = new();
        List<ServicioBE> servicioLista;
        public int reservaId;

        public FrmAgregarServicioReserva(int reservaId)
        {
            InitializeComponent();
            this.reservaId = reservaId;
        }

        private void AgreagarSevicio(int reservaId, int cantidad, ServicioBE servicioBE)
        {
            try
            {
                bool result = reservaServicioBL.AgregarServicioReserva(reservaId, cantidad, servicioBE);
                if (!result)
                {
                    throw new Exception("Error de falso");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error agregando servicio", MessageBoxButtons.OK);
            }
        }
        private List<ServicioBE> CargarServicios()
        {
            servicioLista = new List<ServicioBE>();
            DataTable dataTable = servicioBusiness.ListarServicio();
            DataRow dataRow = dataTable.NewRow();
            dataRow["Id"] = "0";
            dataRow["Servicio Descripcion"] = "--Seleccione--";
            dataRow["Precio"] = 0;
            dataTable.Rows.InsertAt(dataRow, 0);
            foreach (DataRow row in dataTable.Rows)
            {
                ServicioBE servicio = new ServicioBE();
                servicio.servicioId = Convert.ToInt16(row["Id"]);
                servicio.servicioDescripcion = row["Servicio Descripcion"].ToString();
                servicio.servicioPrecio = Convert.ToSingle(row["Precio"].ToString());
                servicioLista.Add(servicio);
            }

            return servicioLista;
        }

        private void SeleccionarServicio_Load(object sender, EventArgs e)
        {
            labelResultadoReservaId.Text = reservaId.ToString();
            comboboxServicios.DataSource = CargarServicios();
            comboboxServicios.DisplayMember = "servicioDescripcion";
            comboboxServicios.ValueMember = "servicioId";
        }

        private void numericoCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (numericoCantidad.Value == 0)
            {
                numericoCantidad.Value = 1;

            }

            if (comboboxServicios.SelectedItem is ServicioBE servicioSeleccionado)
            {
                labelPrecioTotal.Text = (servicioSeleccionado.servicioPrecio * (int)numericoCantidad.Value).ToString("C2");
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboboxServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxServicios.SelectedItem is ServicioBE servicioSeleccionado)
            {
                labelPrecioTotal.Text = (servicioSeleccionado.servicioPrecio * (int)numericoCantidad.Value).ToString("C2");
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (comboboxServicios.SelectedItem is ServicioBE servicioSeleccionado)
            {
                AgreagarSevicio(this.reservaId, (int)numericoCantidad.Value, servicioSeleccionado);
                //MessageBox.Show($"{servicioSeleccionado.servicioId} - {this.reservaId} - {(int)numericoCantidad.Value}");
            }
            this.Close();
        }
    }
}
