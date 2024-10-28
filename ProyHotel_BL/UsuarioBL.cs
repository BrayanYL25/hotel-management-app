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
    public class UsuarioBL
    {
        UsuarioADO objusuario = new UsuarioADO();

        public DataTable ListarUsuarios()
        {
            return objusuario.ListarUsuarios();
        }
        public UsuarioBE ConsultarUsuario(Int16 idusuario)
        {
            return objusuario.ConsultarUsuario(idusuario);

        }
        public Boolean InsertarUsuario(UsuarioBE usuario)
        {
            return objusuario.InsertarUsuario(usuario);
        }
        public Boolean ActualizarUsuario(UsuarioBE usuario)
        {
            return objusuario.ActualizarUsuario(usuario);
        }
        public Boolean EliminarUsuario(Int16 idUsuario)
        {
            return objusuario.EliminarUsuario(idUsuario);
        }
        public DataTable ListarTipoUsuario()
        {
            return objusuario.ListarTipoUsuario();
        }
        public UsuarioBE IngresoUsuario(string nombreUsuario, string password)
        {
            return objusuario.IngresoUsuario(nombreUsuario, password);
        }
        public Boolean BloquearUsuario(int id)
        {
            return objusuario.BloquearUsuario(id);
        }
    }
}
