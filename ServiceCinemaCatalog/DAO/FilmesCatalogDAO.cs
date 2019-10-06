using Dapper;
using ServiceCinemaCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServiceCinemaCatalog.DAO
{
    public class FilmesCatalogDAO : DAO
    {

        public IEnumerable<FilmesCatalog> Listar()
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                return sqlConnection.Query<FilmesCatalog>(@"select Id, Nome, PrecoMeia, PrecoInteira, Data from filmes");
            }
        }

        public void Salvar(FilmesCatalog filmesCatalog)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"insert into filmes (Nome, PrecoMeia, PrecoInteira, Data) values (@Nome, @PrecoMeia, @PrecoInteira, @Data)";
                sqlConnection.Execute(query, filmesCatalog);
            }
        }

        public void Atualizar(FilmesCatalog filmesCatalog)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"update filmes set Nome = @Nome where Id = @Id";
                sqlConnection.Execute(query, filmesCatalog);
            }
        }
    }
}