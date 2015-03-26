using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using ProyectoEstilos.Dominio;
using ProyectoEstilos.Persistencia;
using ProyectoEstilos.Excepciones;

namespace ProyectoEstilos
{

    public class Estilos : IEstilos
    {

        private EstilosDAO dao = new EstilosDAO();

        /***************ESTABLECIMIENTO**********************/
        public List<Establecimiento> ObtenerListaEstablecimiento()
        {
            List<Establecimiento> listaEstablecimiento = dao.ListarEstablecimiento();

            if (listaEstablecimiento != null && listaEstablecimiento.Count > 0)
                return listaEstablecimiento;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No hay establecimientos registrados" }, HttpStatusCode.InternalServerError);
            }
        }
        public Establecimiento ObtenerEstablecimiento(string codEstablecimiento)
        {
            Establecimiento establecimiento = dao.ObtenerEstablecimiento(int.Parse(codEstablecimiento));

            if (establecimiento != null && establecimiento.idEstablecimiento != 0)
                return establecimiento;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No existe establecimiento" }, HttpStatusCode.InternalServerError);
            }
        }

        public Establecimiento BuscarEstablecimiento(string latitud, string longitud)
        {
            Establecimiento establecimiento = dao.BuscarEstablecimiento(latitud,longitud);

            if (establecimiento != null && establecimiento.idEstablecimiento != 0)
                return establecimiento;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No existe establecimiento" }, HttpStatusCode.InternalServerError);
            }
        }

        /***************ESTILISTA**********************/
        public List<Estilista> ObtenerListaEstilistaEstablecimiento(string codEstablecimiento)
        {
            List<Estilista> listaEstilistas = dao.ObtenerListaEstilistaEstablecimiento(int.Parse(codEstablecimiento));

            if (listaEstilistas != null && listaEstilistas.Count > 0)
                return listaEstilistas;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No hay estilistas para dicho establecimiento" }, HttpStatusCode.InternalServerError);
            }
        }

        /***************SERVICIO**********************/
        public List<Servicio> ObtenerListaServicioEstablecimiento(string codEstablecimiento)
        {
            List<Servicio> listaServicios = dao.ObtenerListaServicioEstablecimiento(int.Parse(codEstablecimiento));

            if (listaServicios != null && listaServicios.Count > 0)
                return listaServicios;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No hay servicios para dicho establecimiento" }, HttpStatusCode.InternalServerError);
            }
        }

        /***************USUARIO**********************/
        public Usuario AutenticarUsuario(string correo, string pass)
        {
            Usuario usuario = dao.AutenticarUsuario(correo, pass);

            if (usuario != null && usuario.idUsuario != 0)
                return usuario;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "Autenticacion fallida" }, HttpStatusCode.InternalServerError);
            }
        }

        public Usuario RegistrarUsuario(string nombre, string correo, string pass)
        {
            Usuario usuario = dao.RegistrarUsuario(nombre,correo,pass);

            if (usuario != null && usuario.idUsuario != 0)
                return usuario;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "Registro no realizado" }, HttpStatusCode.InternalServerError);
            }
        }

        /***************FAVORITO**********************/
        public List<Favorito> ObtenerListaFavoritoUsuario(string codUsuario)
        {
            List<Favorito> listaFavoritos = dao.ListarFavoritoUsuario(int.Parse(codUsuario));

            if (listaFavoritos != null && listaFavoritos.Count > 0)
                return listaFavoritos;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No tiene favoritos registrados" }, HttpStatusCode.InternalServerError);
            }
        }

        public Favorito AgregrarFavorito(string codUsuario, string codEstablecimiento)
        {
            Favorito favorito = dao.AgregrarFavorito(int.Parse(codUsuario), int.Parse(codEstablecimiento));

            if (favorito != null && favorito.idFavorito != 0)
                return favorito;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No se pudo agregar favorito" }, HttpStatusCode.InternalServerError);
            }
        }

        public Favorito EliminarFavorito(string codFavorito)
        {
            Favorito favorito = dao.EliminarFavorito(int.Parse(codFavorito));

            if (favorito != null && favorito.idFavorito != 0)
                return favorito;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "Borrado satisfactoriamente" }, HttpStatusCode.InternalServerError);
            }
        }

        /***************RESERVA**********************/
        public List<Reserva> ObtenerListaReservaUsuario(string codUsuario)
        {
            List<Reserva> listaReservas = dao.ListarReservaUsuario(int.Parse(codUsuario));

            if (listaReservas != null && listaReservas.Count > 0)
                return listaReservas;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "No tiene reservas registradas" }, HttpStatusCode.InternalServerError);
            }
        }

        public Reserva RegistrarReserva(string codUsuario, string codEstablecimiento, string codEstilista, string codServicio, string hora)
        {
            Reserva reserva = dao.RegistrarReserva(int.Parse(codUsuario), int.Parse(codEstablecimiento), int.Parse(codEstilista), int.Parse(codServicio), hora);

            if (reserva != null && reserva.idReserva != 0)
                return reserva;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "Horario ya reservados" }, HttpStatusCode.InternalServerError);
            }
        }

        public Reserva CancelarReserva(string codReserva)
        {
            Reserva reserva = dao.CancelarReserva(int.Parse(codReserva));

            if (reserva != null && reserva.idReserva != 0)
                return reserva;
            else
            {
                throw new WebFaultException<Excepcion>(new Excepcion() { Mensaje = "Cancelado satisfactoriamente" }, HttpStatusCode.InternalServerError);
            }
        }

    }
}
