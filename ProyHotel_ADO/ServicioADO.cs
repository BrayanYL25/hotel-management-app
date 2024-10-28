using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ProyHotel_BE;
using System.Globalization;

namespace ProyHotel_ADO
{
    public class ServicioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarServicio()
        {
            try
            {
                DataSet dataSet = new DataSet();
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_servicio";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(dataSet, "MisServicio");
                return dataSet.Tables["MisServicio"];
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
        }

        public Boolean CrearServicio(ServicioBE servicio)
        {
            try
            {
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_crear_tb_servicio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@servicio_descripcion", servicio.servicioDescripcion);
                cmd.Parameters.AddWithValue("@servicio_precio", servicio.servicioPrecio);
                cmd.Parameters.AddWithValue("@servicio_estado", servicio.servicioEstado);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);

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

        public bool ActualizarServicio(ServicioBE servicio)
        {
            try
            {
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizar_tb_servicio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@servicio_id", servicio.servicioId);
                cmd.Parameters.AddWithValue("@servicio_descripcion", servicio.servicioDescripcion);
                cmd.Parameters.AddWithValue("@servicio_precio", servicio.servicioPrecio);
                cmd.Parameters.AddWithValue("@servicio_estado", servicio.servicioPrecio);

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


        public bool BorrarServicio(int id)
        {
            try
            {
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_borrar_tb_servicio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@servicio_id", id);

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

        public ServicioBE ConsultarProducto(int id)
        {
            try
            {
                ServicioBE servicio = new();
                cnx.ConnectionString = MiConexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_obtener_tb_servicio_id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@servicio_id", id);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    string formato = "dd/MM/yyyy HH:mm:ss";
                    servicio.servicioId = Convert.ToInt16(dtr["Id"]);
                    servicio.servicioDescripcion = dtr["Servicio Descripcion"].ToString();
                    servicio.servicioPrecio = Convert.ToSingle(dtr["Precio"]);
                    servicio.servicioFechaCreacion = DateTime.ParseExact(dtr["Fecha Creacion"].ToString(), formato, CultureInfo.InstalledUICulture);
                    servicio.servicioEstado = dtr["Estado"].ToString() == "Activo";

                }
                return servicio;
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