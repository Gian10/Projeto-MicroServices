using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceBoxOffice.Models
{
    public class Bilheteria
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Nome { get; set; }
        public double Valor  { get; set; }
    }
}