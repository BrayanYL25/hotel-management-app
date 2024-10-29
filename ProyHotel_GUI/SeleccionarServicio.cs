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
    public partial class SeleccionarServicio : Form
    {
        ServicioBL servicioBusiness = new();

        public SeleccionarServicio()
        {
            InitializeComponent();
        }

        private List<ServicioBE> CargarServicios()
        {
            List<ServicioBE> servicioLista = new List<ServicioBE>();
            DataTable dataTable = servicioBusiness.ListarServicio();
            foreach (DataRow row in dataTable.Rows)
            {
                ServicioBE servicio = new ServicioBE();
                servicio.servicioId = Convert.ToInt16(row["Id"]);
                servicio.servicioDescripcion = row["Servicio Descripcion"].ToString();
                servicioLista.Add(servicio);
            }

            return servicioLista;
        }

        private void SeleccionarServicio_Load(object sender, EventArgs e)
        {
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
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
