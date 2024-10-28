using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregar 
using ProyHotel_ADO;

namespace ProyHotel_BL
{
    public class TipoHabitacionesBL
    {
        TipoHabitacion objTipoHabitacion = new TipoHabitacion();

        public DataTable ListarTipoHabitaciones()
        {
            return objTipoHabitacion.ListarHabitacion();
        }



    }
}
