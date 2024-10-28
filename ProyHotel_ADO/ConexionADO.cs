using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel_ADO
{
    internal class ConexionADO
    {
        public string ObtenerCadenaCnx()
        {
            string strCnx =
                ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}
