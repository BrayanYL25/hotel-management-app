using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHotel_ADO;
using ProyHotel_BE;

namespace ProyHotel_BL
{
    public class ReservaServicioBL
    {
        ReservaServicioADO reservaServicioADO = new ReservaServicioADO();

        public DataTable ListarReservaServicioPorIdReserva (int reservaId)
        {
            return reservaServicioADO.ListarReservaServicioPorIdReserva(reservaId);
        }

        public bool AgregarServicioReserva(int reservaId, int cantidad, ServicioBE servicioBE)
        {
            return reservaServicioADO.AgregarServicioReserva(reservaId, cantidad, servicioBE);
        }
    }
}
