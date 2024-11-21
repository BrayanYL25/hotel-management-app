using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregar 
using ProyHotel_ADO;
using ProyHotel_BE;

namespace ProyHotel_BL
{
    public class TipoHabitacionesBL
    {
        TipoHabitacion objTipoHabitacionADO = new TipoHabitacion();

        public DataTable ListarTipoHabitaciones()
        {
            return objTipoHabitacionADO.ListarTipoHabitacion();
        }


        public TipoHabitacionBE ConsultarTipoHabitacion(String strCodigo)
        {
            return objTipoHabitacionADO.ConsultarTipoHabitacion(strCodigo);
        }

        public Boolean InsertarTipoHabitacion(TipoHabitacionBE objTipoHabitacionBE)
        {
            return objTipoHabitacionADO.InsertarTipoHabitacion(objTipoHabitacionBE);
        }
        public Boolean ActualizarTipoHabitacion(TipoHabitacionBE objTipoHabitacioBE)
        {
            return objTipoHabitacionADO.ActualizarTipoHabitaciones(objTipoHabitacioBE);
        }
        public Boolean EliminarTipoHabitacion(String strCodigo)
        {
            return objTipoHabitacionADO.EliminarTipoHabitacion(strCodigo);
        }
    }
}
