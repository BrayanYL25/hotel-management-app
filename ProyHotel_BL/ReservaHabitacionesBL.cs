using ProyHotel_ADO;
using ProyHotel_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BL
{
    public class ReservaHabitacionesBL
    {
        ReservaHabitacionADO reservaHabitacionADO = new ReservaHabitacionADO();
        public DataTable ListarReservaHabitacionPorIdReserva(int reservaId)
        {
            return reservaHabitacionADO.ListarReservaHabitacionPorIdReserva(reservaId);
        }
        public ReservaHabitacionBE ConsultarHabitacionServicio(int reservaId, int habitacionId)
        {
            return reservaHabitacionADO.ConsultarReservaHabitacion(reservaId, habitacionId);
        }

        public bool AgregarHabitacionReserva(ReservaHabitacionBE reservaHabitacionBE)
        {
            return reservaHabitacionADO.AgregarHabitacionReserva(reservaHabitacionBE);
        }
        public bool ActualizarHabitacionReserva(int reservaId, int habitacionId, DateTime fechaCheckIn, DateTime fechaCheckOut)
        {
            return reservaHabitacionADO.ActualizarHabitacionReserva(reservaId, habitacionId, fechaCheckIn, fechaCheckOut);
        }
        public bool BorrarHabitacionReserva(int reservaId, int habitacionId)
        {
            return reservaHabitacionADO.BorrarHabitacionReserva(reservaId, habitacionId);
        }
    }
}
