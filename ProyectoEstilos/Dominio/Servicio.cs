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
    public class Servicio
    {
        [DataMember]
        public int idServicio { get; set; }
        [DataMember]
        public string noServicio { get; set; }
        [DataMember]
        public string desServicio { get; set; }
        [DataMember]
        public int idEstablecimiento { get; set; }
    }
}