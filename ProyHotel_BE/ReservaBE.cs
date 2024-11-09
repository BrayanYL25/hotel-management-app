using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class ReservaBE
    {
        public int reservaId { get; set; }
        public int usuarioUltimaModificacion { get; set; }
        public string reservaNombre { get; set; }
        public int usuarioId { get; set; }
        public string usuarioDni { get; set; }
        public string usuarioTelefono { get; set; }
        public float precioTotal { get; set; }
        public bool reservaEstado { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaModificacion { get; set; }
        public DateTime fechaPago { get; set; }
        public bool estadoPago { get; set; }
    }
}
