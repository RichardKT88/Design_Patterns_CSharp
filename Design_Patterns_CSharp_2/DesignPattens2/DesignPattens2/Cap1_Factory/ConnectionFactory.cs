using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo01
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User id=root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();

            return conexao;
        }

    }
}
