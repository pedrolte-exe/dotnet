using System;
using System.Collections.Generic;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{

    class Conexao
    {

        string dadosConexao = "server=localhost;user=root;database=test_ti42;port=3306;password=";

        public void BuscaProdutos()
        {

            //abrir conexão com o banco
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            Console.WriteLine("Conexão realizada com sucesso!");

            // Rodar o SQL dentro do banco
            string sql = "SELECT * FROM produtos;";
            MySqlCommand comando= new MySqlCommand( sql, conexao );
            MySqlDataReader dados = comando.ExecuteReader();

            while( dados.Read() )
            {
                //Console.WriteLine("ID: "+dados[0]+" | Nome: "+dados[1]+" | Preço "+dados[2]);

                Produto p = new Produto();
                p.id = dados.GetInt32("id");
                p.nome = dados.GetString("nome");
                p.preco = dados.GetFloat("preco");
                p.registro = dados.GetDateTime("registro");

            }

            conexao.Close();
  
        }

    }

}