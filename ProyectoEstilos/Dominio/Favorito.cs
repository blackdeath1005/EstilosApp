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
    public class Favorito
    {
        [DataMember]
        public int idFavorito { get; set; }
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public int idEstablecimiento { get; set; }
        [DataMember]
        public string noEstablecimiento { get; set; }
        [DataMember]
        public string desEstablecimiento { get; set; }
        [DataMember]
        public string direccion { get; set; }
        [DataMember]
        public string latitud { get; set; }
        [DataMember]
        public string longitud { get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public string horario { get; set; }
        [DataMember]
        public string correoEstablecimiento { get; set; }
    }
}