using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProyectoEstilos.Persistencia
{
    public class ConexionBD
    {
        public static string ObtenerCadena()
        {

            //return "Data Source=(local); Initial Catalog=ESTILOS;Integrated Security=SSPI;";
            return "Data Source=ca1f4488-4788-4772-a030-a4650048d468.sqlserver.sequelizer.com; Initial Catalog=dbca1f448847884772a030a4650048d468; User Id=kdsnkwrwgpyesynr; Password=4MqqGx7CmhsctJmM7uzFhiDHwczTCoXCzQ3NBTkbjourHNHMzsnxF8HThQ2D6ma6; ";

        }
    }
}