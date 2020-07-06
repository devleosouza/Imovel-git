using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using MySql.Data.MySqlClient;

namespace CadastroImoveisAPI.Controllers
{
    public class CadastroImoveisController : ApiController
    {
        [HttpPost]
        [ActionName("insertCadastro")]
        public void insertCadastro(string Descricao, string Nome_Rua, string Bairro, string Cidade, decimal Preco_Venda, int Categoria_id)
        {
            try
            {                
                string queryString = $"INSERT INTO imovel(Descricao,Nome_Rua,Bairro,Cidade,Preco_Venda,Categoria_id) VALUES('{Descricao}','{Nome_Rua}','{Bairro}','{Cidade}','{Preco_Venda}','{Categoria_id}');";
                var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringMySql"].ConnectionString;
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
            }
        }

        //[HttpGet]
        //[ActionName("setCategoria")]

        //public string setCategoria()
        //{

        //    return 
        //}

    }
}
