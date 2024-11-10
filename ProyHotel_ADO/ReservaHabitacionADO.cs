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
    public class ReservaHabitacionADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarReservaHabitacionPorIdReserva(int reservaId)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_reserva_habitacion_reserva";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "ReservaHabitacion");
                return dts.Tables["ReservaHabitacion"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AgregarHabitacionReserva(ReservaHabitacionBE reservaHabitacionBE)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_reserva_habitacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaHabitacionBE.reservaId);
                cmd.Parameters.AddWithValue("@habitacion_id", reservaHabitacionBE.habitacionId);
                cmd.Parameters.AddWithValue("@fecha_checkin", reservaHabitacionBE.fechaEntrada);
                cmd.Parameters.AddWithValue("@fecha_checkout", reservaHabitacionBE.fechaSalida);

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
