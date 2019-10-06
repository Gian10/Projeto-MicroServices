using ServiceMovies.DAO;
using ServiceMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ServiceMovies.Controllers
{
    public class MoviesController : ApiController
    {

        MoviesDAO moviesDAO = new MoviesDAO();
       

        IList<Movies> movies = new List<Movies>();

        public MoviesController()
        {
        }

        public MoviesController(List<Movies> movies)
        {
            this.movies = movies;
        }

        [System.Web.Http.Route("api/movies")]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, moviesDAO.Listar());
                //return null;
                
            }
            catch (Exception ex)
            {
                var mensagem = "Filmes em Lançamento não localizados!";
                HttpError error = new HttpError(mensagem);
                return Request.CreateResponse(HttpStatusCode.NotFound, error);
            }
        }

        [System.Web.Http.Route("api/movies")]
        public HttpResponseMessage Post([FromBody] Movies movies)
        {
            try
            {
                moviesDAO.Salvar(movies);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                string location = Url.Link("DefaultApi", new { controller = "movies", id = movies.Id });
                response.Headers.Location = new Uri(location);
                return response;
            }
            catch (Exception ex)
            {
                var mensagem = "Erro ao salvar filme";
                HttpError error = new HttpError(mensagem);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, error);
            }
        }
    }
}