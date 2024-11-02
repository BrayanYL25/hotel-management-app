using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHotel_ADO;

namespace ProyHotel_BL
{
    public class ReservaHabitacionHuespedBL
    {
        ReservaHabitacionHuespedADO reservaHabitacionHuespedADO = new();

        public DataTable ListarReservaHabitacionHuesped(int reservaId, int habitacionId)
        {
            return reservaHabitacionHuespedADO.ListarReservaHabitacionHuesped(reservaId, habitacionId);
        }
    }
}
