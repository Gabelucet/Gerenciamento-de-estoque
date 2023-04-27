using System;

namespace Gerenciamento_de_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Produto novosProdutos = new Produto
            {
                NomeDoProduto = "Gelo",
                ID = 001,
                PrecoDoProduto = 3.99,
                QuantidadeNoEstoque = 999
            };

            Produto novosProdutos1 = new Produto
            {
                NomeDoProduto = "Água",
                ID = 002,
                PrecoDoProduto = 2.99,
                QuantidadeNoEstoque = 99
            };

            Produto novosProdutos2 = new Produto
            {
                NomeDoProduto = "Cerveja",
                ID = 003,
                PrecoDoProduto = 5.99,
                QuantidadeNoEstoque = 999
            };

            Produto.produtos.Add(novosProdutos);
            Produto.produtos.Add(novosProdutos1);
            Produto.produtos.Add(novosProdutos2);

            Menu AcessoMenu = new Menu();
            AcessoMenu.MenuGeral();
        }
    }
}
