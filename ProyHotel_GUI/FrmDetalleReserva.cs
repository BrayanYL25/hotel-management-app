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
    public partial class FrmDetalleReserva : Form
    {
        ReservaBE reservaBE;
        ReservasBL reservasBL = new();
        ReservaServicioBL reservaServicioBL = new();
        ReservaHabitacionesBL reservaHabitacionesBL = new();


        public FrmDetalleReserva(ReservaBE reservaBE)
        {
            InitializeComponent();
            this.reservaBE = reservaBE;
        }

        private void CargarTodo()
        {
            //  Carga los servicios asignados a la reserva
            DataView dataView = new DataView(reservaServicioBL.ListarReservaServicioPorIdReserva(reservaBE.reservaId));
            gridServiciosReserva.AutoGenerateColumns = false;
            gridServiciosReserva.DataSource = dataView;

            //  Carga las habitaciones reservadas
            DataView dataViewHabitaciones = new DataView(reservaHabitacionesBL.ListarReservaHabitacionPorIdReserva(reservaBE.reservaId));
            gridHabitaciones.AutoGenerateColumns = false;
            gridHabitaciones.DataSource = dataViewHabitaciones;
        }

        private void RefrescarDatosReserva()
        {
            reservaBE = reservasBL.ConsultarReserva(reservaBE.reservaId);
            labelResultadoId.Text = reservaBE.reservaId.ToString();
            labelResultadoDocumento.Text = reservaBE.usuarioDni;
            labelResultadoNombre.Text = reservaBE.reservaNombre;
            labelResultadoTelefono.Text = reservaBE.usuarioTelefono;
            labelResultadoPrecioTotal.Text = reservaBE.precioTotal.ToString("C2");
        }

        private void botonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            FrmAgregarReservaHabitacion agregarReservaHabitacion = new(reservaBE.reservaId);
            agregarReservaHabitacion.ShowDialog();
            CargarTodo();
            RefrescarDatosReserva();
        }

        private void botonAgregarServicio_Click(object sender, EventArgs e)
        {
            FrmAgregarServicioReserva seleccionarServicio = new FrmAgregarServicioReserva(reservaBE.reservaId);
            seleccionarServicio.ShowDialog();
            CargarTodo();
            RefrescarDatosReserva();
        }

        private void FrmDetalleReserva_Load(object sender, EventArgs e)
        {
            CargarTodo();
            labelResultadoId.Text = reservaBE.reservaId.ToString();
            labelResultadoDocumento.Text = reservaBE.usuarioDni;
            labelResultadoNombre.Text = reservaBE.reservaNombre;
            labelResultadoTelefono.Text = reservaBE.usuarioTelefono;
            labelResultadoPrecioTotal.Text = reservaBE.precioTotal.ToString("C2");
        }

        private void gridHabitaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult abrirDetalleHuesped = MessageBox.Show("¿Desea abrir ver los huespedes de esta habitacion?", "Huespedes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (abrirDetalleHuesped == DialogResult.Yes)
                {
                    int habitacionId = Convert.ToInt16(gridHabitaciones.Rows[e.RowIndex].Cells[0].Value);
                    string habitacionNombre = gridHabitaciones.Rows[e.RowIndex].Cells[1].Value.ToString();
                    FrmDetalleHuespedHabitacionReserva frmDetalleHuespedHabitacionReserva = new(reservaBE.reservaId, habitacionId, habitacionNombre);
                    frmDetalleHuespedHabitacionReserva.Show();
                }
            }
        }

        private void botonBorrarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridServiciosReserva.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("La celda seleccionada está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cellValue = gridServiciosReserva.SelectedCells[0].OwningRow.Cells[0].Value ?? throw new Exception("No se hallo el valor seleccionado.");
                int servicioId = Convert.ToInt16(cellValue);
                DialogResult confirmarBorrado = MessageBox.Show("¿Seguro que desea eliminar este servicio?", "Eliminar Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    reservaServicioBL.BorrarServicioReserva(reservaBE.reservaId, servicioId);
                    CargarTodo();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show($"Hubo un error {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEditarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridServiciosReserva.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("La celda seleccionada está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cellId = gridServiciosReserva.SelectedCells[0].OwningRow.Cells[0].Value ?? throw new Exception("No se hallo el id seleccionado.");
                var cellNombre = gridServiciosReserva.SelectedCells[0].OwningRow.Cells[1].Value.ToString() ?? throw new Exception("No se hallo el nombre del servicio seleccionado.");
                int servicioId = Convert.ToInt16(cellId);
                DialogResult confirmarEdicion = MessageBox.Show("¿Seguro que desea editar este servicio?", "Editar Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmarEdicion == DialogResult.Yes)
                {
                    ReservaServicioBE reservaServicioBE = new ReservaServicioBE();
                    reservaServicioBE.reservaId = reservaBE.reservaId;
                    reservaServicioBE.servicioId = servicioId;
                    FrmActualizarServicioReserva frmActualizarServicioReserva = new(reservaServicioBE);
                    frmActualizarServicioReserva.ShowDialog();
                    CargarTodo();
                    RefrescarDatosReserva();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show($"Hubo un error {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEditarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridHabitaciones.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("La celda seleccionada está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cellId = gridHabitaciones.SelectedCells[0].OwningRow.Cells[0].Value ?? throw new Exception("No se hallo el id seleccionado.");
                var cellNombre = gridHabitaciones.SelectedCells[0].OwningRow.Cells[1].Value.ToString() ?? throw new Exception("No se hallo el nombre del servicio seleccionado.");
                int habitacionId = Convert.ToInt16(cellId);

                DialogResult confirmarEdicion = MessageBox.Show("¿Seguro que desea editar esta habitación?", "Editar Habitación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmarEdicion == DialogResult.Yes)
                {
                    ReservaHabitacionBE reservaHabitacionBE = new ReservaHabitacionBE();
                    reservaHabitacionBE.reservaId = reservaBE.reservaId;
                    reservaHabitacionBE.habitacionId = habitacionId;
                    FrmActualizarHabitacionReserva frmActualizarHabitacionReserva = new(reservaHabitacionBE);
                    frmActualizarHabitacionReserva.ShowDialog();
                    CargarTodo();
                    RefrescarDatosReserva();
                }


            }
            catch (Exception er)
            {
                MessageBox.Show($"Hubo un error {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonBorrarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridHabitaciones.SelectedCells.Count <= 0)
                {
                    MessageBox.Show("La celda seleccionada está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cellValue = gridHabitaciones.SelectedCells[0].OwningRow.Cells[0].Value ?? throw new Exception("No se hallo el valor seleccionado.");
                int habitacionId = Convert.ToInt16(cellValue);
                DialogResult confirmarBorrado = MessageBox.Show("¿Seguro que desea eliminar esta habitación?", "Eliminar Habitación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmarBorrado == DialogResult.Yes)
                {
                    reservaHabitacionesBL.BorrarHabitacionReserva(reservaBE.reservaId, habitacionId);
                    CargarTodo();
                    RefrescarDatosReserva();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show($"Hubo un error {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
