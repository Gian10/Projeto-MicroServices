using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceCinemaCatalog.Models
{
    public class FilmesCatalog
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int PrecoMeia { get; set; }
        public int PrecoInteira { get; set; }
        public string Data { get; set; }
    }
}