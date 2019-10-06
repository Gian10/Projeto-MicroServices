using Dapper;
using ServiceBoxOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceBoxOffice.DAO
{
    public class BilheteriaDAO : DAO
    {

        public IEnumerable<Bilheteria> Listar()
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                return sqlConnection.Query<Bilheteria>(@"select Id, Ano, Nome, Valor from bilheteria");
            }
        }

        public void Salvar(Bilheteria bilheteria)
        {
            using (var sqlConnection = GetMySqlConnection())
            {
                var query = @"insert into bilheteria (Ano, Nome, Valor) values (@Ano, @Nome, @Valor)";
                sqlConnection.Execute(query, bilheteria);
            }
        }

    }
}