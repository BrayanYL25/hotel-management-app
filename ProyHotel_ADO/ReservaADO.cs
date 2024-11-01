using ProyHotel_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_ADO
{
    public class ReservaADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarReserva()
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_reserva";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "reserva");
                return dts.Tables["reserva"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ReservaBE ConsultarReserva(int idReserva)
        {
            try
            {
                ReservaBE reserva = new ReservaBE();
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_reserva_id";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@reserva_id", idReserva);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    reserva.reservaId = Convert.ToInt16(dtr["reserva_id"].ToString());
                    reserva.usuarioId = Convert.ToInt16(dtr["usuario_id"].ToString());
                    reserva.reservaNombre = dtr["reserva_nombre"].ToString();
                    reserva.usuarioDni = dtr["usuario_dni"].ToString();
                    reserva.usuarioTelefono = dtr["usuario_telefono"].ToString();
                    reserva.precioTotal = Convert.ToSingle(dtr["precio_total"].ToString());
                    reserva.reservaEstado = Convert.ToBoolean(dtr["reserva_estado"]);
                    reserva.fechaRegistro = Convert.ToDateTime(dtr["fecha_registro"].ToString());
                    DateTime fechaMod;
                    DateTime fechaPago;
                    if (DateTime.TryParse(dtr["fecha_modificacion"].ToString(), out fechaMod) && DateTime.TryParse(dtr["fecha_pago"].ToString(), out fechaPago))
                    {
                        reserva.fechaModificacion = Convert.ToDateTime(dtr["fecha_modificacion"].ToString());
                        reserva.fechaPago = Convert.ToDateTime(dtr["fecha_pago"].ToString());
                    }
                    reserva.estadoPago = Convert.ToBoolean(dtr["estado_pago"].ToString());
                    dtr.Close();
                }

                return reserva;

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

        public ReservaBE InsertarReserva(ReservaBE reserva)
        {
            try
            {
                ReservaBE reservaBE = new ReservaBE();
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_reserva";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@usuario_id", reserva.usuarioId);
                cmd.Parameters.AddWithValue("@reserva_nombre", reserva.reservaNombre);
                cmd.Parameters.AddWithValue("@usuario_dni", reserva.usuarioDni);
                cmd.Parameters.AddWithValue("@usuario_telefono", reserva.usuarioTelefono);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    reservaBE.reservaId = Convert.ToInt16(dtr["reserva_id"].ToString());
                    reservaBE.reservaNombre = dtr["reserva_nombre"].ToString();
                    reservaBE.usuarioDni = dtr["usuario_dni"].ToString();
                    reservaBE.usuarioTelefono = dtr["usuario_telefono"].ToString();
                    reservaBE.precioTotal = Convert.ToSingle(dtr["precio_total"]);
                    dtr.Close();
                }

                return reservaBE;
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

        public Boolean ActualizarReserva(ReservaBE reserva)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_reserva";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@reserva_id", reserva.reservaId);
                cmd.Parameters.AddWithValue("@usuario_id", reserva.usuarioId);
                cmd.Parameters.AddWithValue("@usuario_dni", reserva.usuarioDni);
                cmd.Parameters.AddWithValue("@usuario_telefono", reserva.usuarioTelefono);
                cmd.Parameters.AddWithValue("@precio_total", reserva.precioTotal);

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

        public Boolean EliminarReserva(Int16 idReserva)
        {
            try
            {
                cnx.ConnectionString = conexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_reserva";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@reserva_id", idReserva);
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
