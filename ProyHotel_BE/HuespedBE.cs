using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class HuespedBE
    {
        public Int16 huesped_id { get; set; }
        public String huesped_nombre { get; set; }
        public String huesped_telefono { get; set; }
        public String huesped_dni { get; set; }
        public String huesped_correo { get; set; }
        public Char huesped_sexo { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_ult_modificacion { get; set; }
        public bool huesped_estado { get; set; }
    }
}
