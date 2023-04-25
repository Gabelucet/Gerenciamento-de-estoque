using System.Diagnostics;

class Cliente
{
    public void ConsultaCliente()
    {
        Console.Clear();
        Console.WriteLine("Você deseja consultar por:");
        Console.WriteLine("1 - Para Código do produto");
        Console.WriteLine("2 - Nome do produto");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        switch (resposta)
        {
            case 1:
                Thread.Sleep(1500);
                ConsultaPorCodigo();
                break;
            case 2:
                Thread.Sleep(1500);
                ConsultaPorNome();
                break;
            default:
                Console.WriteLine("Opção Invalida. Voltando para o Menu");
                Thread.Sleep(1200);
                break;
        }
    }

    private void ConsultaPorCodigo()
    {
        Console.Clear();
        Console.Write("Me informe o código do produto que deseja: ");
        int resposta = int.Parse(Console.ReadLine());

        Produtos produtoParaExibir = Produtos.produtos.Find(p => p.ID == resposta);
        if (produtoParaExibir != null)
        {
            Console.WriteLine(
                $"Essas são as informações do produto solicitado: \n---------------------------------\n{produtoParaExibir}\n"
            );
        }
        else
        {
            Console.WriteLine(
                "Produto não encontrado. Vamos mostrar as informações de todos os produtos\n"
            );

            foreach (var item in Produtos.produtos)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------");
            }
        }
        Thread.Sleep(2500);
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    private void ConsultaPorNome()
    {
        Console.Clear();
        Console.Write("Me informe o nome do produto que deseja: ");
        string resposta = Console.ReadLine();

        Produtos produtoParaExibir = Produtos.produtos.Find(p => p.NomeDoProduto == resposta);
        if (produtoParaExibir != null)
        {
            Console.WriteLine(
                $"Essas são as informações do produto solicitado: \n---------------------------------\n{produtoParaExibir}\n"
            );
        }
        else
        {
            Console.WriteLine(
                "Produto não encontrado. Vamos mostrar as informações de todos os produtos\n"
            );

            foreach (var item in Produtos.produtos)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------");
            }
        }
        Thread.Sleep(2500);
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    public void Compras()
    {
        Console.Clear();

        Console.Write("Me informe o código do produto que deseja comprar: ");
        int resposta = int.Parse(Console.ReadLine());
        Console.Write("Me informe a quantidade que deseja comprar: ");
        int quantidadeDeProdutos = int.Parse(Console.ReadLine());

        Produtos CompraDeProduto = Produtos.produtos.Find(p => p.ID == resposta);

        if (CompraDeProduto != null)
        {
            Thread.Sleep(2000);
            Console.Clear();
            double valorTotalDaCompra = quantidadeDeProdutos * CompraDeProduto.PrecoDoProduto;
            Console.WriteLine(
                $"O produto que deseja comprar é {CompraDeProduto.NomeDoProduto}\nO valor do produto é R$ {CompraDeProduto.PrecoDoProduto}. Como você comprou {quantidadeDeProdutos}, o valor total da compra deu R$ {valorTotalDaCompra}");

                Produtos quantidadeComprada = new Produtos();
                quantidadeComprada.QuantidadeNoEstoque = CompraDeProduto.QuantidadeNoEstoque - quantidadeDeProdutos;

                Console.WriteLine(quantidadeComprada.QuantidadeNoEstoque);

               
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
            Console.WriteLine("Voltando para o inicio");
            Thread.Sleep(2000);
            Compras();
        }

        Thread.Sleep(2500);
        Console.WriteLine("Voltando para o Menu Inicial");
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }
}
