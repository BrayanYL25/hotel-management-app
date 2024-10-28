using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_ADO
{
    public class TipoHabitacion
    {
        //instancias

        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarHabitacion()
        {
            try
            {
                //codigo
                cnx.ConnectionString = Miconexion.ObtenerCadenaCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listar_tb_tipo_habitacion";//llamar al store 
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);//se construye con el comando
                DataSet dts = new DataSet();


                ada.Fill(dts, "TipoHabitaciones");

                return dts.Tables["TipoHabitaciones"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
