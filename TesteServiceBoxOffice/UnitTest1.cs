using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceBoxOffice.Controllers;
using ServiceBoxOffice.Models;

namespace TesteServiceBoxOffice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get()
        {
           var testBilheteria = GetTestBoxOffice();
           var controller = new BilheteriaController(testBilheteria);
            controller.Request = new HttpRequestMessage();

            controller.Configuration = new HttpConfiguration();
            var response = controller.Get();
            Assert.IsNotNull(response);
        }

        private List<Bilheteria> GetTestBoxOffice()
        {
            var testBilheteria = new List<Bilheteria>();
            testBilheteria.Add(new Bilheteria { Id = 1, Ano = 2019, Nome = "Demo1", Valor = 159 });
            //testBilheteria.Add(new Bilheteria { Id = 2, Ano = 2018, Nome = "Demo2", Valor = 180 });
            //testBilheteria.Add(new Bilheteria { Id = 3, Ano = 2017, Nome = "Demo3", Valor = 210 });
            return testBilheteria;
        }
    }
}
