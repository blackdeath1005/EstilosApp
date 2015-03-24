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
    public class Estilista
    {
        [DataMember]
        public int idEstilista { get; set; }
        [DataMember]
        public string noEstilista { get; set; }
        [DataMember]
        public string especialidad { get; set; }
        [DataMember]
        public string comentario { get; set; }
        [DataMember]
        public string foto { get; set; }
        [DataMember]
        public int idEstablecimiento { get; set; }
    }
}