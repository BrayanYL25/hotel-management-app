using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class ServicioBE
    {
        public int servicioId { get; set; }
        public string servicioDescripcion { get; set; }
        public float servicioPrecio { get; set; }
        public DateTime servicioFechaCreacion { get; set; }
        public bool servicioEstado { get; set; }

        public ServicioBE(int servicioId, string servicioDescripcion, float servicioPrecio, DateTime servicioFechaCreacion, bool servicioEstado)
        {
            this.servicioId = servicioId;
            this.servicioDescripcion = servicioDescripcion;
            this.servicioPrecio = servicioPrecio;
            this.servicioFechaCreacion = servicioFechaCreacion;
            this.servicioEstado = servicioEstado;
        }

        public ServicioBE(string servicioDescripcion, float servicioPrecio, bool servicioEstado)
        {
            this.servicioDescripcion = servicioDescripcion;
            this.servicioPrecio = servicioPrecio;
            this.servicioEstado = servicioEstado;
        }

        public ServicioBE(int servicioId, string servicioDescripcion, float servicioPrecio, bool servicioEstado)
        {
            this.servicioId = servicioId;
            this.servicioDescripcion = servicioDescripcion;
            this.servicioPrecio = servicioPrecio;
            this.servicioEstado = servicioEstado;
        }

        public ServicioBE()
        {
        }
    }
}