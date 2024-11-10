using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class ReservaHabitacionBE
    {
        public int reservaId { get; set; }
        public int habitacionId { get; set; }
        public string? tipoHabitacion { get; set; }
        public string? habitacionNombre { get; set; }
        public float costoNoche { get; set; }
        public DateTime? fechaEntrada { get; set; }
        public DateTime? fechaSalida { get; set; }
        public float precioTotal { get; set; }
    }
}
