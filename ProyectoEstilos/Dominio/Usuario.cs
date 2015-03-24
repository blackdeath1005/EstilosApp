using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Serialization;

namespace ProyectoEstilos.Dominio
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public string noUsuario { get; set; }
        [DataMember]
        public string correoUsuario { get; set; }
        [DataMember]
        public string passwordUsuario { get; set; }
    }
}