using Dapper;
using ServiceMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceMovies.DAO
{
    public class MoviesDAO : DAO
    {

        public IEnumerable<Movies> Listar()
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                return sqlConnection.Query<Movies>(@"select Id, Nome, Data, Hora from movies");
            }
        }

        public void Salvar(Movies movies)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"insert into movies (Nome, Data, Hora) values (@Nome, @Data, @Hora)";
                sqlConnection.Execute(query, movies);
            }
        }
    }
}