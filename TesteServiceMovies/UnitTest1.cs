using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceMovies.Controllers;
using ServiceMovies.Models;

namespace TesteServiceMovies
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get()
        {
            var testMovies = GetTestMovies();
            var controller = new MoviesController(testMovies);
            controller.Request = new HttpRequestMessage();

            controller.Configuration = new HttpConfiguration();
            var response = controller.Get();
            Assert.IsNotNull(response);

        }

        private List<Movies> GetTestMovies()
        {
            var testMovies = new List<Movies>();
            testMovies.Add(new Movies {Id = 1 ,Nome = "Demo1", Hora = "16:00", Data = "20/11/2019"});
            testMovies.Add(new Movies {Id = 2, Nome = "Demo2", Hora = "16:00", Data = "12/10/2019" });
            testMovies.Add(new Movies {Id = 3, Nome = "Demo3", Hora = "16:00", Data = "10/09/2019" });
            return testMovies;
        }
    }
}
