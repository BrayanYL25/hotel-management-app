using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_BE
{
    public class UsuarioBE
    {
        public Int16 usuarioId {  get; set; }
        public Int16 usuarioTipoId { get; set; }
        public String usuarioNombre { get; set; }
        public String usuarioCorreo { get; set; }
        public String usuarioContraseña { get; set; }
        public Boolean usuarioEstado { get; set; }
    }
}
