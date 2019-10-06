using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceMovies.Models
{
    public class Movies
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
    }
}