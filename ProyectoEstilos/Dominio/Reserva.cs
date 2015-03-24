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
    public class Reserva
    {
        [DataMember]
        public int idReserva { get; set; }
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public int idEstablecimiento { get; set; }
        [DataMember]
        public string noEstablecimiento { get; set; }
        [DataMember]
        public int idEstilista { get; set; }
        [DataMember]
        public string noEstilista { get; set; }
        [DataMember]
        public int idServicio { get; set; }
        [DataMember]
        public string noServicio { get; set; }
        [DataMember]
        public string hora { get; set; }
    }
}