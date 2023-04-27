class Venda
{
    int  pausaDoPrograma = 2500;
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
                Thread.Sleep(pausaDoPrograma);
                ConsultaPorCodigo();
                break;
            case 2:
                Thread.Sleep(pausaDoPrograma);
                ConsultaPorNome();
                break;
            default:
                Console.WriteLine("Opção Invalida. Voltando para o Menu");
                Thread.Sleep(pausaDoPrograma);
                break;
        }
    }

    private void ConsultaPorCodigo()
    {
        Console.Clear();
        Console.Write("Me informe o código do produto que deseja: ");
        int resposta = int.Parse(Console.ReadLine());

        Produto produtoParaExibir = Produto.produtos.Find(p => p.ID == resposta);
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

            foreach (var item in Produto.produtos)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------");
            }
        }
        Thread.Sleep(pausaDoPrograma);
        Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
        Console.ReadKey();
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    private void ConsultaPorNome()
    {
        Console.Clear();
        Console.Write("Me informe o nome do produto que deseja: ");
        string resposta = Console.ReadLine();

        Produto produtoParaExibir = Produto.produtos.Find(p => p.NomeDoProduto == resposta);
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

            foreach (var item in Produto.produtos)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------");
            }
        }
        Thread.Sleep(pausaDoPrograma);
        Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
        Console.ReadKey();
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    public void Compras()
    {
        Console.Clear();

        Console.WriteLine("Esse são os produtos que temos hoje: \n");
        foreach (var item in Produto.produtos)
        {
            Console.WriteLine(item);

            Console.WriteLine("---------------------");
        }

        Console.Write("Me informe o código do produto que deseja comprar: ");
        int resposta = int.Parse(Console.ReadLine());
        Console.Write("Me informe a quantidade que deseja comprar: ");
        int quantidadeDeProdutos = int.Parse(Console.ReadLine());

        Produto CompraDeProduto = Produto.produtos.Find(p => p.ID == resposta);

        if (CompraDeProduto != null)
        {
            Thread.Sleep(pausaDoPrograma);
            Console.Clear();
            double valorTotalDaCompra = quantidadeDeProdutos * CompraDeProduto.PrecoDoProduto;
            Console.WriteLine(
                $"O produto que deseja comprar é {CompraDeProduto.NomeDoProduto}\nO valor do produto é R$ {CompraDeProduto.PrecoDoProduto}. Como você comprou {quantidadeDeProdutos}, o valor total da compra deu R$ {valorTotalDaCompra}"
            );

            Produto quantidadeComprada = new Produto();

            CompraDeProduto.QuantidadeNoEstoque -= quantidadeDeProdutos;
        }
        else
        {
            Thread.Sleep(pausaDoPrograma);
            Console.Clear();
            Console.WriteLine("Produto não encontrado");
            Thread.Sleep(pausaDoPrograma);
            Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
            Console.ReadKey();
            Compras();
        }

        Thread.Sleep(pausaDoPrograma);
        Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
        Console.ReadKey();
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }
}
