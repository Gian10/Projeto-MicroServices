using ServiceCinemaCatalog.DAO;
using ServiceCinemaCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ServiceCinemaCatalogo.Controllers
{
    public class FilmesCatalogoController : ApiController
    {
        FilmesCatalogDAO filmesCatalogoDAO = new FilmesCatalogDAO();

        List<FilmesCatalog> filmesCatalog = new List<FilmesCatalog>();

        public FilmesCatalogoController()
        {
        }

        public FilmesCatalogoController(List<FilmesCatalog> filmesCatalogs)
        {
            this.filmesCatalog = filmesCatalogs;
        }

        [System.Web.Http.Route("api/filmes")]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, filmesCatalogoDAO.Listar());
               //return null;
            }
            catch (Exception ex)
            {
                var mensagem = "Filmes não localizados!";
                HttpError error = new HttpError(mensagem);
                return Request.CreateResponse(HttpStatusCode.NotFound, error);
            }
        }


        [System.Web.Http.Route("api/filmes/salvar")]
        public HttpResponseMessage Post([FromBody] FilmesCatalog filmesCatalog)
        {
            try
            {
                filmesCatalogoDAO.Salvar(filmesCatalog);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                string location = Url.Link("DefaultApi", new { controller = "filmesCatalogo", id = filmesCatalog.Id });
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


        [System.Web.Http.Route("api/filmes")]
        public HttpResponseMessage Put([FromBody] FilmesCatalog filmesCatalog)
        {
            try
            {
                filmesCatalogoDAO.Atualizar(filmesCatalog);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                var mensagem = "Erro ao editar filme";
                HttpError error = new HttpError(mensagem);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, error);
            }
        }

        //[System.Web.Http.Route("api/movies")]
        //public HttpResponseMessage GetAll()
        //{
        //    try
        //    {
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        var mensagem = "Filmes não localizados!";
        //        HttpError error = new HttpError(mensagem);
        //        return Request.CreateResponse(HttpStatusCode.NotFound, error);
        //    }
        //}
    }
}