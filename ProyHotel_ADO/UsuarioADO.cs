using ProyHotel_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_ADO
{
    public class UsuarioADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarUsuarios()
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_usuario";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "usuario");
                return dts.Tables["usuario"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarTipoUsuario()
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_tipo_usuario";
                cmd.Parameters.Clear();
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                miada.Fill(dts, "tipo_usuario");
                return dts.Tables["tipo_usuario"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UsuarioBE ConsultarUsuario(Int16 idusuario)
        {
            try
            {
                UsuarioBE usuario = new UsuarioBE();
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_usuario_id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@usuario_id", idusuario);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    usuario.usuarioId = Convert.ToInt16(dtr["usuario_id"].ToString());
                    usuario.usuarioTipoId = Convert.ToInt16(dtr["tipo_usuario_id"].ToString());
                    usuario.usuarioNombre = dtr["usuario_nombre"].ToString();
                    usuario.usuarioContraseña = dtr["usuario_password"].ToString();
                    usuario.usuarioCorreo = dtr["usuario_correo"].ToString();
                    usuario.usuarioEstado = Convert.ToBoolean(dtr["usuario_estado"].ToString());
                    dtr.Close();
                }

                return usuario;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarUsuario(UsuarioBE usuario)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_usuario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_usuario_id", usuario.usuarioTipoId);
                cmd.Parameters.AddWithValue("@usuario_nombre", usuario.usuarioNombre);
                cmd.Parameters.AddWithValue("@usuario_correo", usuario.usuarioCorreo);
                cmd.Parameters.AddWithValue("@usuario_password", usuario.usuarioContraseña);
                cmd.Parameters.AddWithValue("@usuario_estado", usuario.usuarioEstado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean BloquearUsuario(int id)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_estado_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open) { cnx.Close(); }
            }
        }

        public Boolean ActualizarUsuario(UsuarioBE usuario)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario_id", usuario.usuarioId);
                cmd.Parameters.AddWithValue("@tipo_usuario_id", usuario.usuarioTipoId);
                cmd.Parameters.AddWithValue("@usuario_nombre", usuario.usuarioNombre);
                cmd.Parameters.AddWithValue("@usuario_correo", usuario.usuarioCorreo);
                cmd.Parameters.AddWithValue("@usuario_password", usuario.usuarioContraseña);
                cmd.Parameters.AddWithValue("@estado_usuario", usuario.usuarioEstado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open) { cnx.Close(); }
            }

        }

        public Boolean EliminarUsuario(Int16 idUsuario)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_desactivar_tb_usuario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@usuario_id", idUsuario);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open) { cnx.Close(); }
            }

        }

        public UsuarioBE IngresoUsuario(string nombreUsuario, string password)
        {
            try
            {
                UsuarioBE usuario = new UsuarioBE();
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ingreso_tb_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario_nombre", nombreUsuario);
                cmd.Parameters.AddWithValue("@usuario_password", password);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    usuario.usuarioId = Convert.ToInt16(dtr["usuario_id"]);
                    usuario.usuarioNombre = dtr["usuario_nombre"].ToString();
                    usuario.usuarioContraseña = dtr["usuario_password"].ToString();
                    usuario.usuarioEstado = Convert.ToBoolean(dtr["usuario_estado"]);
                }
                dtr.Close();
                return usuario;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


    }
}
