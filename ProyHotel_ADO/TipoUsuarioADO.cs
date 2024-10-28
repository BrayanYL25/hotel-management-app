using ProyHotel_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHotel_BE;

namespace ProyHotel_ADO
{
    public class TipoUsuarioADO
    {
        ConexionADO MiConexion = new();
        SqlConnection cnx = new();
        SqlCommand cmd = new();
        SqlDataReader dtr;

        public DataTable ListarTipoUsuario()
        {
            try
            {
                DataSet listadoTipoUsuarios = new DataSet();
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_tipo_usuario";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(listadoTipoUsuarios, "Tipos de Usuario");
                return listadoTipoUsuarios.Tables["Tipos de Usuario"];
            }
            catch (Exception ex)
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

        public TipoUsuarioBE ConsultarTipoUsuario(int id)
        {
            try
            {
                //codigo
                TipoUsuarioBE tipoUsuarioBE = new();

                //conexion
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_habitacion_id";//llamar al store 
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@habitacion_id", id);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    tipoUsuarioBE.tipoUsuarioId = Convert.ToInt16(dtr["Tipo Usuario Id"]);
                    tipoUsuarioBE.tipoUsuarioDescripcion = dtr["Descripcion Tipo de Usuario"].ToString();
                }
                dtr.Close();
                return tipoUsuarioBE;
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

        public Boolean CrearTipoUsuario(TipoUsuarioBE tipoUsuarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_tipo_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_usuario_descripcion", tipoUsuarioBE.tipoUsuarioDescripcion);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarTipoUsuario(TipoUsuarioBE tipoUsuarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_tipo_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_usuario_id", tipoUsuarioBE.tipoUsuarioId);
                cmd.Parameters.AddWithValue("@tipo_usuario_descripcion", tipoUsuarioBE.tipoUsuarioDescripcion);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean BorrarTipoUsuario(int id)
        {
            try
            {
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_tipo_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_usuario_id", id);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
