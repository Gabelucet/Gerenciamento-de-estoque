class Menu
{
    

    Produtos MenuProdutos = new Produtos();

    public void MenuGeral()
    {
        Console.WriteLine("Seja bem vindo a loja do Gabe");
        Console.WriteLine("Me informe se você é:");
        Console.WriteLine("1 - Para Cliente");
        Console.WriteLine("2 - Para Funcionario");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        switch (resposta)
        {
            case 1:
                Thread.Sleep(1500);
                Cliente();
                break;
            case 2:
                Thread.Sleep(1500);
                Funcionario();
                break;

            default:
                Thread.Sleep(1500);
                Console.WriteLine("Escolha errada ... Voltando para o Menu inicial");
                MenuGeral();
                break;
        }
    }

    private void Funcionario()
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo :-)");
        Console.WriteLine("O que deseja fazer hoje? ");
        Console.WriteLine("1 - Cadastrar Novos produtos");
        Console.WriteLine("2 - Consultar lista de produtos");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        switch (resposta)
        {
            case 1:
                Thread.Sleep(1500);
                Console.Clear();
                MenuProdutos.CadastroDeProduto();
                break;
            case 2:
                Thread.Sleep(1500);
                Console.Clear();
                MenuProdutos.ListaDeProdutos();
                break;
            default:
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine("Escolha errada ... Voltando para o Menu");
                Funcionario();
                break;
        }
    }

    private void Cliente() { }

    public void VoltarAoMenu()
    {
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("Você Deseja: ");
        Console.WriteLine("1 - Voltar ao Menu Geral");
        Console.WriteLine("2 - Voltar ao Menu do Funcionario");
        Console.WriteLine("3 - Voltar ao Menu do Cliente");
        Console.WriteLine("0 - Encerrar o programa");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        switch (resposta)
        {
            case 1:
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Indo para o Menu Inicial");
                MenuGeral();
                Thread.Sleep(1500);
                break;
            case 2:
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("indo para o Menu do Funcionario");
                Funcionario();
                Thread.Sleep(1500);
                break;
            case 3:
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Indo para o Menu do Cliente");
                Thread.Sleep(1500);
                Cliente();
                break;
            case 0:
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Saindo do programa ... ");
                Thread.Sleep(1500);
                System.Environment.Exit(0);
                break;
            default:
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Escolha incorreta, encerrando o programa");
                Thread.Sleep(1500);
                System.Environment.Exit(0);
                break;
        }
    }
}
