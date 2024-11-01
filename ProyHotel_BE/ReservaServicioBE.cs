using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class ReservaServicioBE
    {
        public int reservaId {  get; set; }
        public int servicioId { get; set; }
        public int cantidad {  get; set; }
        public float precioTotal {  get; set; }
        public DateTime fechaCreacion {  get; set; }
        public DateTime fechaUltimaModificacion { get; set; }
    }
}
