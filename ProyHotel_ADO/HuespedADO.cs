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
    public class HuespedADO
    {
        //instancias

        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        
        //listo
        public DataTable ListarHuesped()
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_huesped";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "huesped");
                return dts.Tables["huesped"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public HuespedBE ConsultarHuesped(String idhuesped)
        {
            try
            {
                HuespedBE huesped = new HuespedBE();
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_huesped_id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@huesped_id", idhuesped);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();//poner tal cual esta en la db
                    huesped.huesped_id = Convert.ToInt16(dtr["id"].ToString());
                    huesped.huesped_nombre= dtr["Nombre"].ToString();
                    huesped.huesped_telefono = dtr["telefono"].ToString();
                    huesped.huesped_dni = dtr["DNI"].ToString();
                    huesped.fecha_creacion = Convert.ToDateTime(dtr["Fecha Creacion"]);
                    //huesped.fecha_ult_modificacion = Convert.ToDateTime(dtr["Fecha Ultima Modificacion"]);

                    if (!dtr.IsDBNull(dtr.GetOrdinal("Fecha Ultima Modificacion")))
                    {
                        huesped.fecha_ult_modificacion = Convert.ToDateTime(dtr["Fecha Ultima Modificacion"]);
                    }
                    dtr.Close();
                }

                return huesped;

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

        public Boolean InsertarHuesped(HuespedBE huesped)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_huesped";
                cmd.Parameters.Clear();

                //poner los parametros que recibe
                cmd.Parameters.AddWithValue("@huesped_nombre", huesped.huesped_nombre);
                cmd.Parameters.AddWithValue("@huesped_telefono", huesped.huesped_telefono);
                cmd.Parameters.AddWithValue("@huesped_dni", huesped.huesped_dni);


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

        public Boolean ActualizarHuesped(HuespedBE huesped)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_huesped";
                cmd.Parameters.Clear();

                //poner los parametros que recibe
                
                cmd.Parameters.AddWithValue("@huesped_id", huesped.huesped_id);
                cmd.Parameters.AddWithValue("@huesped_nombre", huesped.huesped_nombre);
                cmd.Parameters.AddWithValue("@huesped_telefono", huesped.huesped_telefono);
                cmd.Parameters.AddWithValue("@huesped_dni", huesped.huesped_dni);
                cmd.Parameters.AddWithValue("@fecha_ult_modificacion", huesped.fecha_ult_modificacion);

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

        public Boolean EliminarHuesped(String idHuesped)
        {
            try
            {
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_huesped";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@huesped_id", idHuesped);
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















    }
}
