using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class TipoUsuarioBE
    {
        public int tipoUsuarioId { get; set; }
        public string tipoUsuarioDescripcion {  get; set; }

        public TipoUsuarioBE(int tipoUsuarioId, string tipoUsuarioDescripcion)
        {
            this.tipoUsuarioId = tipoUsuarioId;
            this.tipoUsuarioDescripcion = tipoUsuarioDescripcion;
        }

        public TipoUsuarioBE() { }
    }
}
