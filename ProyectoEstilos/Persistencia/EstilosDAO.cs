using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoEstilos.Dominio;
using System.Data.SqlClient;

namespace ProyectoEstilos.Persistencia
{
    public class EstilosDAO
    {

        /***************ESTABLECIMIENTO**********************/
        public Establecimiento ObtenerEstablecimiento(int id)
        {
            Establecimiento establecimientoEncontrado = new Establecimiento();

            string sql = "SELECT * FROM establecimiento WHERE idEstablecimiento = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            establecimientoEncontrado = new Establecimiento()
                            {
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                desEstablecimiento = resultado["desEstablecimiento"].ToString(),
                                direccion = resultado["direccion"].ToString(),
                                latitud = resultado["latitud"].ToString(),
                                longitud = resultado["longitud"].ToString(),
                                telefono = resultado["telefono"].ToString(),
                                horario = resultado["horario"].ToString(),
                                correoEstablecimiento = resultado["correoEstablecimiento"].ToString(),
                                imagen = resultado["imagen"].ToString(),
                                imagen2 = resultado["imagen2"].ToString(),
                                imagen3 = resultado["imagen3"].ToString(),
                            };
                        }
                    }
                }
            }

            return establecimientoEncontrado;
        }
        public Establecimiento BuscarEstablecimiento(string lat, string lon)
        {
            Establecimiento establecimientoEncontrado = new Establecimiento();

            string sql = "SELECT * FROM establecimiento WHERE latitud = @lat and longitud = @lon";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@lat", lat));
                    com.Parameters.Add(new SqlParameter("@lon", lon));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            establecimientoEncontrado = new Establecimiento()
                            {
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                desEstablecimiento = resultado["desEstablecimiento"].ToString(),
                                direccion = resultado["direccion"].ToString(),
                                latitud = resultado["latitud"].ToString(),
                                longitud = resultado["longitud"].ToString(),
                                telefono = resultado["telefono"].ToString(),
                                horario = resultado["horario"].ToString(),
                                correoEstablecimiento = resultado["correoEstablecimiento"].ToString(),
                                imagen = resultado["imagen"].ToString(),
                                imagen2 = resultado["imagen2"].ToString(),
                                imagen3 = resultado["imagen3"].ToString(),
                            };
                        }
                    }
                }
            }

            return establecimientoEncontrado;
        }
        public List<Establecimiento> ListarEstablecimiento()
        {
            List<Establecimiento> establecimientos = new List<Establecimiento>();
            Establecimiento usuarioEstablecimiento = new Establecimiento();

            string sql = "select * from establecimiento";

            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            usuarioEstablecimiento = new Establecimiento()
                            {
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                desEstablecimiento = resultado["desEstablecimiento"].ToString(),
                                direccion = resultado["direccion"].ToString(),
                                latitud = resultado["latitud"].ToString(),
                                longitud = resultado["longitud"].ToString(),
                                telefono = resultado["telefono"].ToString(),
                                horario = resultado["horario"].ToString(),
                                correoEstablecimiento = resultado["correoEstablecimiento"].ToString(),
                                imagen = resultado["imagen"].ToString(),
                                imagen2 = resultado["imagen2"].ToString(),
                                imagen3 = resultado["imagen3"].ToString(),
                            };
                            establecimientos.Add(usuarioEstablecimiento);
                        }
                    }
                }
            }
            return establecimientos;
        }

        /***************ESTILISTA**********************/
        public List<Estilista> ObtenerListaEstilistaEstablecimiento(int id)
        {
            List<Estilista> estilistas = new List<Estilista>();
            Estilista estilistaEncontrado = new Estilista();

            string sql = "SELECT * FROM estilista WHERE idEstablecimiento = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            estilistaEncontrado = new Estilista()
                            {
                                idEstilista = int.Parse(resultado["idEstilista"].ToString()),
                                noEstilista = resultado["noEstilista"].ToString(),
                                especialidad = resultado["especialidad"].ToString(),
                                comentario = resultado["comentario"].ToString(),
                                foto = resultado["foto"].ToString(),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                            };
                            estilistas.Add(estilistaEncontrado);
                        }
                    }
                }
            }

            return estilistas;
        }
        public Estilista ObtenerEstilista(int id)
        {
            Estilista estilistaEncontrado = new Estilista();

            string sql = "SELECT * FROM estilista WHERE idEstilista = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            estilistaEncontrado = new Estilista()
                            {
                                idEstilista = int.Parse(resultado["idEstilista"].ToString()),
                                noEstilista = resultado["noEstilista"].ToString(),
                                especialidad = resultado["especialidad"].ToString(),
                                comentario = resultado["comentario"].ToString(),
                                foto = resultado["foto"].ToString(),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                            };
                        }
                    }
                }
            }

            return estilistaEncontrado;
        }


        /***************SERVICIO**********************/
        public List<Servicio> ObtenerListaServicioEstablecimiento(int id)
        {
            List<Servicio> servicios = new List<Servicio>();
            Servicio servicioEncontrado = new Servicio();

            string sql = "SELECT * FROM servicio WHERE idEstablecimiento = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            servicioEncontrado = new Servicio()
                            {
                                idServicio = int.Parse(resultado["idServicio"].ToString()),
                                noServicio = resultado["noServicio"].ToString(),
                                desServicio = resultado["desServicio"].ToString(),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                            };
                            servicios.Add(servicioEncontrado);
                        }
                    }
                }
            }

            return servicios;
        }
        public Servicio ObtenerServicio(int id)
        {
            Servicio servicioEncontrado = new Servicio();

            string sql = "SELECT * FROM servicio WHERE idServicio = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            servicioEncontrado = new Servicio()
                            {
                                idServicio = int.Parse(resultado["idServicio"].ToString()),
                                noServicio = resultado["noServicio"].ToString(),
                                desServicio = resultado["desServicio"].ToString(),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                            };
                        }
                    }
                }
            }

            return servicioEncontrado;
        }


        /***************USUARIO**********************/
        public Usuario AutenticarUsuario(string cor, string pass)
        {
            Usuario usuarioEncontrado = new Usuario();

            List<Usuario> usuarios = ListarUsuario();

            for (int i=0;i<usuarios.Count();i++) {
                if(usuarios.ElementAt(i).correoUsuario.ToString().Equals(cor)) {
                    if(usuarios.ElementAt(i).passwordUsuario.ToString().Equals(pass)) {
                        usuarioEncontrado = usuarios.ElementAt(i);
                    }
                }
            }

            return usuarioEncontrado;
        }
        public Usuario RegistrarUsuario(string nom, string cor, string pass)
        {
            Usuario usuarioCreado = new Usuario();

            string sql = "INSERT INTO usuario VALUES (@nom,@cor,@pass)";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@nom", nom));
                    com.Parameters.Add(new SqlParameter("@cor", cor));
                    com.Parameters.Add(new SqlParameter("@pass", pass));
                    com.ExecuteNonQuery();
                }
            }

            usuarioCreado = ObtenerUsuarioUltimo();

            return usuarioCreado;
        }
        public Usuario ObtenerUsuarioUltimo()
        {
            List<Usuario> usuarios = ListarUsuario();

            Usuario usuarioUltimo = usuarios.Last();

            return usuarioUltimo;
        }
        public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuarioEncontrado = new Usuario();

            string sql = "select * from usuario";

            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            usuarioEncontrado = new Usuario()
                            {
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                noUsuario = resultado["noUsuario"].ToString(),
                                correoUsuario = resultado["correoUsuario"].ToString(),
                                passwordUsuario = resultado["passwordUsuario"].ToString(),
                            };
                            usuarios.Add(usuarioEncontrado);
                        }
                    }
                }
            }
            return usuarios;
        }


        /***************FAVORITO**********************/
        public Favorito AgregrarFavorito(int idUsu, int idEst)
        {

            Establecimiento establecimientoEncontrado = new Establecimiento();

            establecimientoEncontrado = ObtenerEstablecimiento(idEst);

            Favorito favoritoCreado = new Favorito();

            string sql = "INSERT INTO favorito VALUES (@idUsu,@idEst,@noEst,@desEst,@dir,@lat,@lon,@tel,@hor,@corEst,@ima,@ima2,@ima3)";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idUsu", idUsu));
                    com.Parameters.Add(new SqlParameter("@idEst", idEst));
                    com.Parameters.Add(new SqlParameter("@noEst", establecimientoEncontrado.noEstablecimiento.ToString()));
                    com.Parameters.Add(new SqlParameter("@desEst", establecimientoEncontrado.desEstablecimiento.ToString()));
                    com.Parameters.Add(new SqlParameter("@dir", establecimientoEncontrado.direccion.ToString()));
                    com.Parameters.Add(new SqlParameter("@lat", establecimientoEncontrado.latitud.ToString()));
                    com.Parameters.Add(new SqlParameter("@lon", establecimientoEncontrado.longitud.ToString()));
                    com.Parameters.Add(new SqlParameter("@tel", establecimientoEncontrado.telefono.ToString()));
                    com.Parameters.Add(new SqlParameter("@hor", establecimientoEncontrado.horario.ToString()));
                    com.Parameters.Add(new SqlParameter("@corEst", establecimientoEncontrado.correoEstablecimiento.ToString()));
                    com.Parameters.Add(new SqlParameter("@ima", establecimientoEncontrado.imagen.ToString()));
                    com.Parameters.Add(new SqlParameter("@ima2", establecimientoEncontrado.imagen2.ToString()));
                    com.Parameters.Add(new SqlParameter("@ima3", establecimientoEncontrado.imagen3.ToString()));
                    com.ExecuteNonQuery();
                }
            }

            favoritoCreado = ObtenerFavoritoUsuarioUltimo(idUsu);

            return favoritoCreado;
        }
        public Favorito ObtenerFavoritoUsuarioUltimo(int idUsu)
        {
            List<Favorito> favoritos = ListarFavoritoUsuario(idUsu);

            Favorito favoritoUltimo = favoritos.Last();

            return favoritoUltimo;
        }
        public List<Favorito> ListarFavoritoUsuario(int idUsu)
        {
            List<Favorito> favoritos = new List<Favorito>();
            Favorito favoritoEncontrado = new Favorito();

            string sql = "select * from favorito where idUsuario = "+idUsu;

            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            favoritoEncontrado = new Favorito()
                            {
                                idFavorito = int.Parse(resultado["idFavorito"].ToString()),
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                desEstablecimiento = resultado["desEstablecimiento"].ToString(),
                                direccion = resultado["direccion"].ToString(),
                                latitud = resultado["latitud"].ToString(),
                                longitud = resultado["longitud"].ToString(),
                                telefono = resultado["telefono"].ToString(),
                                horario = resultado["horario"].ToString(),
                                correoEstablecimiento = resultado["correoEstablecimiento"].ToString(),
                                imagen = resultado["imagen"].ToString(),
                                imagen2 = resultado["imagen2"].ToString(),
                                imagen3 = resultado["imagen3"].ToString()
                            };
                            favoritos.Add(favoritoEncontrado);
                        }
                    }
                }
            }
            return favoritos;
        }
        public Favorito EliminarFavorito(int id)
        {
            Favorito favoritoEliminado = new Favorito();

            string sql = "DELETE FROM favorito where idFavorito=@id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    com.ExecuteNonQuery();
                }
            }

            favoritoEliminado = ObtenerFavorito(id);

            return favoritoEliminado;

        }
        public Favorito ObtenerFavorito(int id)
        {
            Favorito favoritoEncontrado = new Favorito();

            string sql = "SELECT * FROM favorito WHERE idFavorito = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            favoritoEncontrado = new Favorito()
                            {
                                idFavorito = int.Parse(resultado["idFavorito"].ToString()),
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                desEstablecimiento = resultado["desEstablecimiento"].ToString(),
                                direccion = resultado["direccion"].ToString(),
                                latitud = resultado["latitud"].ToString(),
                                longitud = resultado["longitud"].ToString(),
                                telefono = resultado["telefono"].ToString(),
                                horario = resultado["horario"].ToString(),
                                correoEstablecimiento = resultado["correoEstablecimiento"].ToString(),
                                imagen = resultado["imagen"].ToString(),
                                imagen2 = resultado["imagen2"].ToString(),
                                imagen3 = resultado["imagen3"].ToString(),
                            };
                        }
                    }
                }
            }

            return favoritoEncontrado;
        }


        /***************RESERVA**********************/
        public Reserva RegistrarReserva(int idUsu, int idEst, int idEstil, int idSer, string hora)
        {
            Reserva reservaCreada = new Reserva();

            if (ValidarDisponibilidadReserva(idEstil, hora))
            {
                Establecimiento establecimientoEncontrado = ObtenerEstablecimiento(idEst);
                Estilista estilistaEncontrado = ObtenerEstilista(idEstil);
                Servicio servicioEncontrado = ObtenerServicio(idSer);

                string sql = "INSERT INTO reserva VALUES (@idUsu,@idEst,@noEst,@idEstil,@noEstil,@idSer,@noSer,@hora)";
                using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.Add(new SqlParameter("@idUsu", idUsu));
                        com.Parameters.Add(new SqlParameter("@idEst", idEst));
                        com.Parameters.Add(new SqlParameter("@noEst", establecimientoEncontrado.noEstablecimiento.ToString()));
                        com.Parameters.Add(new SqlParameter("@idEstil", idEstil));
                        com.Parameters.Add(new SqlParameter("@noEstil", estilistaEncontrado.noEstilista.ToString()));
                        com.Parameters.Add(new SqlParameter("@idSer", idSer));
                        com.Parameters.Add(new SqlParameter("@noSer", servicioEncontrado.noServicio.ToString()));
                        com.Parameters.Add(new SqlParameter("@hora", hora));
                        com.ExecuteNonQuery();
                    }
                }

                reservaCreada = ObtenerReservaUsuarioUltimo(idUsu);
            }

            return reservaCreada;
        }
        public Reserva ObtenerReservaUsuarioUltimo(int idUsu)
        {
            List<Reserva> reservas = ListarReservaUsuario(idUsu);

            Reserva reservaUltimo = reservas.Last();

            return reservaUltimo;
        }
        public List<Reserva> ListarReservaUsuario(int idUsu)
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reservaEncontrado = new Reserva();

            string sql = "select * from reserva where idUsuario = "+idUsu;

            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            reservaEncontrado = new Reserva()
                            {
                                idReserva = int.Parse(resultado["idReserva"].ToString()),
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                idEstilista = int.Parse(resultado["idEstilista"].ToString()),
                                noEstilista = resultado["noEstilista"].ToString(),
                                idServicio = int.Parse(resultado["idServicio"].ToString()),
                                noServicio = resultado["noServicio"].ToString(),
                                hora = resultado["hora"].ToString(),
                            };
                            reservas.Add(reservaEncontrado);
                        }
                    }
                }
            }
            return reservas;
        }
        public List<Reserva> ListarReservaUsuarioDesc(int idUsu)
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reservaEncontrado = new Reserva();

            string sql = "select TOP 10 * from reserva where idUsuario = " + idUsu + " order by hora DESC";

            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            reservaEncontrado = new Reserva()
                            {
                                idReserva = int.Parse(resultado["idReserva"].ToString()),
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                idEstilista = int.Parse(resultado["idEstilista"].ToString()),
                                noEstilista = resultado["noEstilista"].ToString(),
                                idServicio = int.Parse(resultado["idServicio"].ToString()),
                                noServicio = resultado["noServicio"].ToString(),
                                hora = resultado["hora"].ToString(),
                            };
                            reservas.Add(reservaEncontrado);
                        }
                    }
                }
            }
            return reservas;
        }
        public Reserva CancelarReserva(int id)
        {
            Reserva reservaEliminado = new Reserva();

            string sql = "DELETE FROM reserva where idReserva=@id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    com.ExecuteNonQuery();
                }
            }

            reservaEliminado = ObtenerReserva(id);

            return reservaEliminado;

        }
        public Reserva ObtenerReserva(int id)
        {
            Reserva reservaEncontrado = new Reserva();

            string sql = "SELECT * FROM reserva WHERE idReserva = @id";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            reservaEncontrado = new Reserva()
                            {
                                idReserva = int.Parse(resultado["idFavorito"].ToString()),
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                idEstilista = int.Parse(resultado["idEstilista"].ToString()),
                                noEstilista = resultado["noEstilista"].ToString(),
                                idServicio = int.Parse(resultado["idServicio"].ToString()),
                                noServicio = resultado["noServicio"].ToString(),
                                hora = resultado["hora"].ToString(),
                            };
                        }
                    }
                }
            }

            return reservaEncontrado;
        }
        public Boolean ValidarDisponibilidadReserva(int idEstil, string hora)
        {

            Boolean validacion = true;

            Reserva reservaEncontrado = new Reserva();

            string sql = "SELECT * FROM reserva WHERE idEstilista = @idEstil and hora = @hora";
            using (SqlConnection con = new SqlConnection(ConexionBD.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEstil", idEstil));
                    com.Parameters.Add(new SqlParameter("@hora", hora));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            reservaEncontrado = new Reserva()
                            {
                                idReserva = int.Parse(resultado["idReserva"].ToString()),
                                idUsuario = int.Parse(resultado["idUsuario"].ToString()),
                                idEstablecimiento = int.Parse(resultado["idEstablecimiento"].ToString()),
                                noEstablecimiento = resultado["noEstablecimiento"].ToString(),
                                idEstilista = int.Parse(resultado["idEstilista"].ToString()),
                                noEstilista = resultado["noEstilista"].ToString(),
                                idServicio = int.Parse(resultado["idServicio"].ToString()),
                                noServicio = resultado["noServicio"].ToString(),
                                hora = resultado["hora"].ToString(),
                            };
                            validacion = false;
                        }
                    }
                }
            }

            return validacion;
        }


    }
}