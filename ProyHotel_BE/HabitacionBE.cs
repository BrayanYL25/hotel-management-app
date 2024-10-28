using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class HabitacionBE
    {
        //definimos la entidad de negocio Habitacion, con todas
        //las propiedades de la tabla tb_habitaciones


        public Int16 habitacion_id { get; set; }
        public Int16 tipo_habitacion_id { get; set; }//id tipo_habitacion
        public Single precio_noche { get; set; }
        public Int16 habitacion_aforo { get; set; }
        public Int16 estado_habitacion { get; set; }
        public String habitacion_nombre { get; set; }
        public String tipo_habitacion_descripcion { get; set; }// descripcion


    }
}
