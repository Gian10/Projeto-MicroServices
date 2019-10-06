using ServiceBoxOffice.DAO;
using ServiceBoxOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ServiceBoxOffice.Controllers
{
    public class BilheteriaController : ApiController
    {
        BilheteriaDAO bilheteriaDAO = new BilheteriaDAO();


        List<Bilheteria> bilheteria = new List<Bilheteria>();

        public BilheteriaController()
        {
        }

        public BilheteriaController(List<Bilheteria> bilheterias)
        {
            this.bilheteria = bilheterias;
        }

        [System.Web.Http.Route("api/bilheterias")]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, bilheteriaDAO.Listar());
                //return null;
            }
            catch (Exception ex)
            {
                var mensagem = "Bilheteria não localizada!";
                HttpError error = new HttpError(mensagem);
                return Request.CreateResponse(HttpStatusCode.NotFound, error);
            }
        }


        //[System.Web.Http.Route("api/bilheteria")]
        //public HttpResponseMessage Post([FromBody] Bilheteria bilheteria)
        //{
        //    try
        //    {
        //        bilheteriaDAO.Salvar(bilheteria);
        //        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
        //        string location = Url.Link("DefaultApi", new { controller = "bilheteria", id = bilheteria.Id });
        //        response.Headers.Location = new Uri(location);
        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        var mensagem = "Erro ao Visulalizar Bilheteria";
        //        HttpError error = new HttpError(mensagem);
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, error);
        //    }
        //}

    }
}