using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_ADO
{
    public class ReservaHabitacionHuespedADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarReservaHabitacionHuesped(int reservaId, int habitacionId)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_reserva_habitacion_huesped_todo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                cmd.Parameters.AddWithValue("@habitacion_id", habitacionId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "ReservaHabitacionHuesped");
                return dts.Tables["ReservaHabitacionHuesped"];
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

        public bool EliminarReservaHabitacionHuesped(int reservaId, int habitacionId, int huespedId)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_reserva_habitacion_huesped";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                cmd.Parameters.AddWithValue("@habitacion_id", habitacionId);
                cmd.Parameters.AddWithValue("@huesped_id", huespedId);

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
