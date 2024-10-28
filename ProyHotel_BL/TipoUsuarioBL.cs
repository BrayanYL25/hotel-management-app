using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHotel_ADO;
using ProyHotel_BE;

namespace ProyHotel_BL
{
    public class TipoUsuarioBL
    {
        TipoUsuarioADO tipoUsuarioADO = new();

        public DataTable ListarTipoUsuario()
        {
            return tipoUsuarioADO.ListarTipoUsuario();
        }

        public TipoUsuarioBE ConsultarTipoUsuario(int id)
        {
            return tipoUsuarioADO.ConsultarTipoUsuario(id);
        }

        public bool CrearTipoUsuario(TipoUsuarioBE tipoUsuarioBE)
        {
            return tipoUsuarioADO.CrearTipoUsuario(tipoUsuarioBE);
        }

        public bool ActualizarTipoUsuario(TipoUsuarioBE tipoUsuarioBE)
        {
            return tipoUsuarioADO.ActualizarTipoUsuario(tipoUsuarioBE);
        }

        public bool BorrarTipoUsuario(int id)
        {
            return tipoUsuarioADO.BorrarTipoUsuario(id);
        }
    }
}
