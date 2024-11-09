using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyHotel_BE;


namespace ProyHotel_ADO
{
    public class HabitacionADO
    {
        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarHabitacion()
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_habitacion";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Habitaciones");

                return dts.Tables["Habitaciones"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarHabitacionTipo(int tipoHabitacionId)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_habitacion_tipo_id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_habitacion_id", tipoHabitacionId);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new();

                ada.Fill(dts, "HabitacionTipoId");
                return dts.Tables["HabitacionTipoId"];
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
        public HabitacionBE ConsultarHabitacion(String strCodigo)
        {
            try
            {
                HabitacionBE objHabitacionBE = new HabitacionBE();


                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_habitacion_id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@habitacion_id", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objHabitacionBE.habitacion_id = Convert.ToInt16(dtr["habitacion_id"]);
                    objHabitacionBE.tipo_habitacion_id = Convert.ToInt16(dtr["tipo_habitacion_id"]);
                    objHabitacionBE.habitacion_aforo = Convert.ToInt16(dtr["habitacion_aforo"]);
                    objHabitacionBE.estado_habitacion = Convert.ToInt16(dtr["estado_habitacion"]);
                    objHabitacionBE.habitacion_nombre = dtr["habitacion_nombre"].ToString();
                }
                dtr.Close();
                return objHabitacionBE;
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
        public Boolean InsertarHabitacion(HabitacionBE objHabitacionBE)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_habitacion_id", objHabitacionBE.tipo_habitacion_id);
                cmd.Parameters.AddWithValue("@habitacion_nombre", objHabitacionBE.habitacion_nombre);
                cmd.Parameters.AddWithValue("@habitacion_aforo", objHabitacionBE.habitacion_aforo);
                cmd.Parameters.AddWithValue("@estado_habitacion", objHabitacionBE.estado_habitacion);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean ActualizarHabitacion(HabitacionBE objHabitacionBE, int usuarioId)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@habitacion_id", objHabitacionBE.habitacion_id);
                cmd.Parameters.AddWithValue("@habitacion_nombre", objHabitacionBE.habitacion_nombre);
                cmd.Parameters.AddWithValue("@habitacion_aforo", objHabitacionBE.habitacion_aforo);
                cmd.Parameters.AddWithValue("@usuario_ult_modificacion", usuarioId);
                cmd.Parameters.AddWithValue("@tipo_habitacion_id", objHabitacionBE.tipo_habitacion_id);
                cmd.Parameters.AddWithValue("@estado_habitacion", objHabitacionBE.estado_habitacion);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean EliminarHabitacion(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@habitacion_id", strCodigo);


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
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
