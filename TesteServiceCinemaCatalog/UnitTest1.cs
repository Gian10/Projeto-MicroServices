using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceCinemaCatalog.Models;
using ServiceCinemaCatalogo.Controllers;

namespace TesteServiceCinemaCatalog
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get()
        {
            var testFilmesCatalog = GetTestFilmesCatalog();
            var controller = new FilmesCatalogoController(testFilmesCatalog);
            controller.Request = new HttpRequestMessage();

            controller.Configuration = new HttpConfiguration();
            var response = controller.Get();
            Assert.IsNotNull(response);
        }

        private List<FilmesCatalog> GetTestFilmesCatalog()
        {
            var testMovies = new List<FilmesCatalog>();
            testMovies.Add(new FilmesCatalog {Id = 1 ,Nome = "Teste1", PrecoMeia = 15 , PrecoInteira = 30, Data = "14/02/2019"  });
            testMovies.Add(new FilmesCatalog {Id = 2, Nome = "teste2", PrecoMeia = 15, PrecoInteira = 30, Data = "10/03/2019" });
            return testMovies;
        }
    }
}
