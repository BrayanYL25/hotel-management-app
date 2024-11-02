using ProyHotel_ADO;
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
    }
}
