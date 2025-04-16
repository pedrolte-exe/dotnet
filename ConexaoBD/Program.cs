using System;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {


            Conexao conexao = new Conexao();
            conexao.BuscaProdutos();


            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Olá, digite o seu nome:");
            // string nome = Console.ReadLine();
            // Console.WriteLine("Seja bem-vinde Sre "+nome);

            // Produto produto = new Produto();
            // produto.nome = "Ozzy Osbourne - Blizzard of Ozz";
            // produto.preco = 105.80f;

            // Console.WriteLine("O produto é: "+produto.nome+"e o preço é "+produto.preco);



        }
    }
}
