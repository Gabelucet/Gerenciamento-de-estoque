using System;

namespace Gerenciamento_de_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Produtos novosProdutos = new Produtos
            {
                NomeDoProduto = "Gelo",
                ID = 001,
                PrecoDoProduto = 3.99,
                QuantidadeNoEstoque = 999
            };

            Produtos novosProdutos1 = new Produtos
            {
                NomeDoProduto = "Água",
                ID = 002,
                PrecoDoProduto = 2.99,
                QuantidadeNoEstoque = 99
            };

            Produtos novosProdutos2 = new Produtos
            {
                NomeDoProduto = "Cerveja",
                ID = 003,
                PrecoDoProduto = 5.99,
                QuantidadeNoEstoque = 999
            };

            Produtos.produtos.Add(novosProdutos);
            Produtos.produtos.Add(novosProdutos1);
            Produtos.produtos.Add(novosProdutos2);

            Venda i = new Venda();
            i.Compras();
        }
    }
}
