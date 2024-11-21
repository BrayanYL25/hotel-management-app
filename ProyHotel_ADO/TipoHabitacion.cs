using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//usar
using ProyHotel_BE;

namespace ProyHotel_ADO
{
    public class TipoHabitacion
    {
        //instancias

        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        //listar
        public DataTable ListarTipoHabitacion()
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_tipo_habitacion"; 
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();


                ada.Fill(dts, "TipoHabitaciones");

                return dts.Tables["TipoHabitaciones"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        //consultar - obtener
        public TipoHabitacionBE ConsultarTipoHabitacion(String strCodigo)
        {
            try
            {
                TipoHabitacionBE ojbTipoHabitacionBE = new TipoHabitacionBE();
                
                cnx.ConnectionString= Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_habitacion_tipo_id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_habitacion_id", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if ( dtr.HasRows == true)
                {
                    dtr.Read();
                    ojbTipoHabitacionBE.tipo_habitacion_id = Convert.ToUInt16(dtr["Id"]);
                    ojbTipoHabitacionBE.tipo_habitacion_descripcion = dtr["Habitacion Descripcion"].ToString();
                    ojbTipoHabitacionBE.tipo_habitacion_precio = Convert.ToUInt16(dtr["Precio"]);
                }
                dtr.Close();
                return ojbTipoHabitacionBE;



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

        //insertar - crear

        public Boolean InsertarTipoHabitacion(TipoHabitacionBE objTipoHabitacionBE)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_tipo_habitacion";
                cmd.Parameters.Clear();

                //cmd.Parameters.AddWithValue("@tipo_habitacion_id", objTipoHabitacionBE.tipo_habitacion_id);
                cmd.Parameters.AddWithValue("@tipo_habitacion_descripcion", objTipoHabitacionBE.tipo_habitacion_descripcion);
                cmd.Parameters.AddWithValue("@costo_noche", objTipoHabitacionBE.tipo_habitacion_precio);

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
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        //Actualizar 

        public Boolean ActualizarTipoHabitaciones(TipoHabitacionBE objtipoHabitacionBE)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_tipo_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_habitacion_id", objtipoHabitacionBE.tipo_habitacion_id);
                cmd.Parameters.AddWithValue("@tipo_habitacion_descripcion", objtipoHabitacionBE.tipo_habitacion_descripcion);
                cmd.Parameters.AddWithValue("@costo_noche", objtipoHabitacionBE.tipo_habitacion_precio);

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
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        //Eliminar
        public Boolean EliminarTipoHabitacion(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_tipo_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_habitacion_id", strCodigo);

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
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
