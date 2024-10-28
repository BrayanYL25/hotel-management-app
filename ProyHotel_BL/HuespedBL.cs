
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
    public class HuespedBL
    {

        HuespedADO objHuespedADO = new HuespedADO();

        public DataTable listarHuesped()
        {
            return objHuespedADO.ListarHuesped();
        }
        //public HuespedBE ConsultarHuesped(Int16 strCodigo)
        //{
        //    return objHuespedADO.ConsultarHuesped(strCodigo);
        //}
        //public Boolean InsertarHuesped(HuespedBE objHuespedBE)
        //{
        //    return objHuespedADO.InsertarHuesped(objHuespedBE);
        //}
        //public Boolean ActualizarHuesped(HuespedBE objHuespedBE)
        //{
        //    return objHuespedADO.ActualizarHuesped(objHuespedBE);
        //}
        //public Boolean EliminarHabitacion(String strCodigo)
        //{
        //    return objHuespedADO.EliminarHuesped(strCodigo);
        //}
    }
}
