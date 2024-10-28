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
    public class ReservasBL
    {
        ReservaADO objReserva = new ReservaADO();

        public DataTable ListarReserva()
        {
            return objReserva.ListarReserva();
        }
        public ReservaBE ConsultarReserva(int idReserva)
        {
            return objReserva.ConsultarReserva(idReserva);

        }
        public Boolean InsertarReserva(ReservaBE reserva)
        {
            return objReserva.InsertarReserva(reserva);
        }
        public Boolean ActualizarReserva(ReservaBE reserva)
        {
            return objReserva.ActualizarReserva(reserva);
        }
        public Boolean EliminarReserva(Int16 idReserva)
        {
            return objReserva.EliminarReserva(idReserva);
        }
    }
}
