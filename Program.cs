using System;

namespace Gerenciamento_de_estoque
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();
            Produtos i = new Produtos("novo", 8, 98, 100);

            i.CadastroDeProduto();
        }
    }
}
