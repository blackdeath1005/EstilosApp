using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProyectoEstilos.Dominio;

namespace ProyectoEstilos
{

    [ServiceContract]
    public interface IEstilos
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerListaEstablecimiento/", ResponseFormat = WebMessageFormat.Json)]
        List<Establecimiento> ObtenerListaEstablecimiento();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerEstablecimiento/{codEstablecimiento}", ResponseFormat = WebMessageFormat.Json)]
        Establecimiento ObtenerEstablecimiento(string codEstablecimiento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarEstablecimiento/?latitud={latitud}&longitud={longitud}", ResponseFormat = WebMessageFormat.Json)]
        Establecimiento BuscarEstablecimiento(string latitud, string longitud);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerListaEstilistaEstablecimiento/{codEstablecimiento}", ResponseFormat = WebMessageFormat.Json)]
        List<Estilista> ObtenerListaEstilistaEstablecimiento(string codEstablecimiento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerListaServicioEstablecimiento/{codEstablecimiento}", ResponseFormat = WebMessageFormat.Json)]
        List<Servicio> ObtenerListaServicioEstablecimiento(string codEstablecimiento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "AutenticarUsuario/?correo={correo}&pass={pass}", ResponseFormat = WebMessageFormat.Json)]
        Usuario AutenticarUsuario(string correo, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "RegistrarUsuario/?nombre={nombre}&correo={correo}&pass={pass}", ResponseFormat = WebMessageFormat.Json)]
        Usuario RegistrarUsuario(string nombre, string correo, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerListaFavoritoUsuario/{codUsuario}", ResponseFormat = WebMessageFormat.Json)]
        List<Favorito> ObtenerListaFavoritoUsuario(string codUsuario);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "AgregrarFavorito/?codUsuario={codUsuario}&codEstablecimiento={codEstablecimiento}", ResponseFormat = WebMessageFormat.Json)]
        Favorito AgregrarFavorito(string codUsuario, string codEstablecimiento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "EliminarFavorito/{codFavorito}", ResponseFormat = WebMessageFormat.Json)]
        Favorito EliminarFavorito(string codFavorito);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ObtenerListaReservaUsuario/{codUsuario}", ResponseFormat = WebMessageFormat.Json)]
        List<Reserva> ObtenerListaReservaUsuario(string codUsuario);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "RegistrarReserva/?codUsuario={codUsuario}&codEstablecimiento={codEstablecimiento}&codEstilista={codEstilista}&codServicio={codServicio}&hora={hora}", ResponseFormat = WebMessageFormat.Json)]
        Reserva RegistrarReserva(string codUsuario, string codEstablecimiento, string codEstilista, string codServicio, string hora);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CancelarReserva/{codReserva}", ResponseFormat = WebMessageFormat.Json)]
        Reserva CancelarReserva(string codReserva);

    }
}
