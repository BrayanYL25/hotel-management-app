using ProyHotel_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_ADO
{
    public class ReservaServicioADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarReservaServicioPorIdReserva(int reservaId)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_reserva_servicio_reserva";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "ReservaServicio");
                return dts.Tables["ReservaServicio"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public ReservaServicioBE ConsultarReservaServicio(int reservaId, int servicioId)
        {
            try
            {
                ReservaServicioBE reservaServicio = new();
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_reserva_servicio_id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                cmd.Parameters.AddWithValue("@servicio_id", servicioId);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    reservaServicio.reservaId = Convert.ToInt16(dtr["reserva_id"]);
                    reservaServicio.servicioId = Convert.ToInt16(dtr["servicio_id"]);
                    reservaServicio.servicioDescripcion = dtr["servicio_descripcion"].ToString();
                    reservaServicio.servicioPrecio = Convert.ToSingle(dtr["servicio_precio"]);
                    reservaServicio.cantidad = Convert.ToInt16(dtr["cantidad"]);
                    reservaServicio.precioTotal = Convert.ToSingle(dtr["precio_total"]);

                }
                return reservaServicio;
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

        public bool AgregarServicioReserva(int reservaId, int cantidad, ServicioBE servicioBE)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_reserva_servicio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                cmd.Parameters.AddWithValue("@servicio_id", servicioBE.servicioId);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

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
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public bool BorrarServicioReserva(int reservaId, int servicioId)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_reserva_servicio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                cmd.Parameters.AddWithValue("@servicio_id", servicioId);

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

        public bool ActualizarServicioReserva(int reservaId, int servicioId, int cantidad)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_reserva_servicio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@reserva_id", reservaId);
                cmd.Parameters.AddWithValue("@servicio_id", servicioId);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

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
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
