using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyHotel_BE;
using ProyHotel_ADO;
using System.Data;

namespace ProyHotel_BL
{
    public class ServicioBL
    {
        ServicioADO servicio = new ServicioADO();

        /// <summary>
        /// Obtiene una lista de servicios desde la base de datos.
        /// </summary>
        /// <remarks>
        /// Este método ejecuta un procedimiento almacenado llamado "usp_listar_tb_servicio" para 
        /// recuperar los datos de la tabla de servicios y los carga en un DataTable dentro de un DataSet.
        /// </remarks>
        /// <returns>
        /// Un <see cref="DataTable"/> que contiene los registros de servicios obtenidos de la base de datos.
        /// </returns>
        /// <exception cref="Exception">
        /// Lanza una excepción si ocurre un error en la consulta SQL, propagando el mensaje del <see cref="SqlException"/> original.
        /// </exception>
        public DataTable ListarServicio()
        {
            return servicio.ListarServicio();
        }

        /// <summary>
        /// Consulta un producto en la base de datos utilizando su identificador y devuelve su información.
        /// </summary>
        /// <param name="id">El identificador del servicio que se desea consultar.</param>
        /// <returns>
        /// Un objeto <see cref="ServicioBE"/> que contiene la información del servicio consultado.
        /// Si no se encuentra el servicio, se devolverá un objeto vacío.
        /// </returns>
        /// <exception cref="Exception">Se lanza si ocurre un error al ejecutar el procedimiento almacenado o al establecer la conexión.</exception>
        public ServicioBE ConsultarServicio(int id)
        {
            return servicio.ConsultarProducto(id);
        }

        /// <summary>
        /// Crea un nuevo servicio en la base de datos utilizando un procedimiento almacenado.
        /// </summary>
        /// <param name="servicio">Una instancia de <see cref="ServicioBE"/> que contiene la información del servicio a crear.</param>
        /// <returns>
        /// Devuelve <c>true</c> si el servicio se creó exitosamente; de lo contrario, se lanza una excepción.
        /// </returns>
        /// <exception cref="Exception">Se lanza si ocurre un error al ejecutar el procedimiento almacenado o al establecer la conexión.</exception>
        public bool CrearServicio(ServicioBE servicioBE)
        {
            return servicio.CrearServicio(servicioBE);
        }

        /// <summary>
        /// Actualiza un servicio existente en la base de datos utilizando un procedimiento almacenado.
        /// </summary>
        /// <param name="servicio">Una instancia de <see cref="ServicioBE"/> que contiene la información del servicio a actualizar.</param>
        /// <returns>
        /// Devuelve <c>true</c> si el servicio se actualizó exitosamente; de lo contrario, se lanza una excepción.
        /// </returns>
        /// <exception cref="Exception">Se lanza si ocurre un error al ejecutar el procedimiento almacenado o al establecer la conexión.</exception>
        public bool ActualizarServicio(ServicioBE servicioBE)
        {
            return servicio.ActualizarServicio(servicioBE);
        }

        /// <summary>
        /// Elimina un servicio de la base de datos utilizando un procedimiento almacenado.
        /// </summary>
        /// <param name="id">El identificador del servicio que se desea eliminar.</param>
        /// <returns>
        /// Devuelve <c>true</c> si el servicio se eliminó exitosamente; de lo contrario, se lanza una excepción.
        /// </returns>
        /// <exception cref="Exception">Se lanza si ocurre un error al ejecutar el procedimiento almacenado o al establecer la conexión.</exception>
        public bool BorrarServicio(int id)
        {
            return servicio.BorrarServicio(id);
        }
    }
}