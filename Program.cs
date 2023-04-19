using System;

namespace Gerenciamento_de_estoque
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();
            Produtos i = new Produtos("oi",001,300,300);

            i.CadastroDeProduto();
            i.ListaDeProdutos();
        }
    }
}
