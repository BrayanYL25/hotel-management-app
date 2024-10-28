using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar lo necesario para el funcionamiento
using System.Data;
using System.Data.SqlClient;
using ProyHotel_BE;


namespace ProyHotel_ADO
{
    public class HabitacionADO
    {
        //instancias

        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        //CRUD PA'

        public DataTable ListarHabitacion()
        {
            try
            {
                //codigo
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_habitacion";//llamar al store 
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);//se construye con el comando
                DataSet dts = new DataSet();

                ada.Fill(dts, "Habitaciones");

                return dts.Tables["Habitaciones"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public HabitacionBE ConsultarHabitacion(String strCodigo)
        {
            try
            {
                //codigo
                HabitacionBE objHabitacionBE = new HabitacionBE();

                //conexion
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_habitacion_id";//llamar al store 
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@habitacion_id", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objHabitacionBE.habitacion_id = Convert.ToInt16(dtr["habitacion_id"]);//id
                    objHabitacionBE.tipo_habitacion_id = Convert.ToInt16(dtr["tipo_habitacion_id"]);//fk 
                    objHabitacionBE.precio_noche = Convert.ToSingle(dtr["precio_noche"]);//precio
                    objHabitacionBE.habitacion_aforo = Convert.ToInt16(dtr["habitacion_aforo"]);//aforo
                    objHabitacionBE.estado_habitacion = Convert.ToInt16(dtr["estado_habitacion"]);//activo?
                    objHabitacionBE.habitacion_nombre = dtr["habitacion_nombre"].ToString();//nombre
                    //objHabitacionBE.tipo_habitacion_descripcion = dtr["tipo_habitacion_descripcion"].ToString() ;
                }
                dtr.Close();
                return objHabitacionBE;


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InsertarHabitacion(HabitacionBE objHabitacionBE)
        {
            try
            {
                //codigo
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_habitacion_id", objHabitacionBE.tipo_habitacion_id);
                cmd.Parameters.AddWithValue("@habitacion_nombre", objHabitacionBE.habitacion_nombre);
                cmd.Parameters.AddWithValue("@precio_noche", objHabitacionBE.precio_noche);
                cmd.Parameters.AddWithValue("@habitacion_aforo", objHabitacionBE.habitacion_aforo);
                cmd.Parameters.AddWithValue("@estado_habitacion", objHabitacionBE.estado_habitacion);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (SqlException x)
            {

                throw new Exception(x.Message);
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
        public Boolean ActualizarHabitacion(HabitacionBE objHabitacionBE)
        {
            try
            {
                //codigo
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_habitacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@habitacion_id", objHabitacionBE.habitacion_id);
                cmd.Parameters.AddWithValue("@tipo_habitacion_id", objHabitacionBE.tipo_habitacion_id);
                cmd.Parameters.AddWithValue("@habitacion_nombre", objHabitacionBE.habitacion_nombre);
                cmd.Parameters.AddWithValue("@precio_noche", objHabitacionBE.precio_noche);
                cmd.Parameters.AddWithValue("@habitacion_aforo", objHabitacionBE.habitacion_aforo);
                cmd.Parameters.AddWithValue("@estado_habitacion", objHabitacionBE.estado_habitacion);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
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
        public Boolean EliminarHabitacion(String strCodigo)
        {
            try
            {
                //codigo
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
                return false;
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
