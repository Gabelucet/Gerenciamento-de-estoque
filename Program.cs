using System;

namespace Gerenciamento_de_estoque
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();
            Produtos i = new Produtos();

            i.CadastroDeProduto();
        }
    }
}
