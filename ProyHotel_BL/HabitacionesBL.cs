using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregar
using ProyHotel_ADO;
using ProyHotel_BE;

namespace ProyHotel_BL
{
    public class HabitacionesBL
    {
        HabitacionADO objHabitacionADO = new HabitacionADO();

        public DataTable listarHabitacion()
        {
            return objHabitacionADO.ListarHabitacion();
        }

        public DataTable ListarHabitacionTipo(int tipoHabitacionId)
        {
            return objHabitacionADO.ListarHabitacionTipo(tipoHabitacionId);
        }
        public HabitacionBE ConsultarHabitacion(String strCodigo)
        {
            return objHabitacionADO.ConsultarHabitacion(strCodigo);
        }

        public Boolean InsertarHabitacion(HabitacionBE objHabitacionBE)
        {
            return objHabitacionADO.InsertarHabitacion(objHabitacionBE);
        }
        public Boolean ActualizarHabitacion(HabitacionBE objHabitacioBE, int usuarioId)
        {
            return objHabitacionADO.ActualizarHabitacion(objHabitacioBE, usuarioId);
        }
        public Boolean EliminarHabitacion(String strCodigo)
        {
            return objHabitacionADO.EliminarHabitacion(strCodigo);
        }

    }
}
