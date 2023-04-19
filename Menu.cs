class Menu
{
    Produtos MenuProdutos = new Produtos("1", 1, 1, 1);

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
                Funcionario();
                break;
            case 2:
                Thread.Sleep(1500);
                Cliente();
                break;

            default:
                Thread.Sleep(1500);
                Console.WriteLine("Escolha errada ... Voltando para o Menu inicial");
                MenuGeral();
                break;
        }
    }

    public void Funcionario()
    {
        Console.WriteLine("Seja bem vindo :-)");
        Console.WriteLine("O que deseja fazer hoje? ");
        Console.WriteLine("1 - Cadastrar Novos produtos");
        Console.WriteLine("2 - Consultar lista de produtos");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        switch (resposta)
        {
            case 1:
                Thread.Sleep(1500);Console.Clear();
                MenuProdutos.CadastroDeProduto();
                break;
            case 2:
                Thread.Sleep(1500);Console.Clear();
                MenuProdutos.ListaDeProdutos();
                break;
            default:
                Thread.Sleep(1500);Console.Clear();
                Console.WriteLine("Escolha errada ... Voltando para o Menu");
                Funcionario();
                break;
        }
    }

    public void Cliente() { }
}
