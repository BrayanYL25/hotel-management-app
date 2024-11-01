using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHotel_ADO;

namespace ProyHotel_BL
{
    public class ReservaServicioBL
    {
        ReservaServicioADO reservaServicioADO = new ReservaServicioADO();

        public DataTable ListarReservaServicioPorIdReserva (int reservaId)
        {
            return reservaServicioADO.ListarReservaServicioPorIdReserva(reservaId);
        }
    }
}
