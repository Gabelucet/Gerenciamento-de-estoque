//Essa é a classe de Menu. Aqui temos apenas os menu's dos clientes e funcionarios.
class Menu
{
    Produto MenuProdutos = new Produto();
    Venda MenuVenda = new Venda();

    //Variaveis responsáveis por controlar o tempo do Thread.Sleep do código, pois a cada comando, coloquei uma pausa, para o usuário não trocar apenas de tela ou mensagem
    int pausaDoPrograma = 1500;
    int pausaDoProgramaCasoErro = 3000;

    //Método do menu Geral, onde questiona se é cliente ou funcionário e direciona, para ele para o menu correto.
    public void MenuGeral()
    {
        Console.WriteLine("Seja bem vindo a loja do Gabe");
        Console.WriteLine("\nVocê é:");
        Console.WriteLine("1 - Para Cliente");
        Console.WriteLine("2 - Para Funcionario");
        Console.Write("R: ");
        //Tratamento de exceção ou erro caso o usuário digite uma letra ou inves do número
        try
        {
            int resposta = int.Parse(Console.ReadLine());
            //fluxo para verificar qual foi a escolha do usuário e direcionar ele adequadamente
            switch (resposta)
            {
                case 1:
                    Thread.Sleep(pausaDoPrograma);
                    Cliente();
                    break;
                case 2:
                    Thread.Sleep(pausaDoPrograma);
                    Funcionario();
                    break;

                default:
                    Thread.Sleep(pausaDoPrograma);
                    Console.WriteLine("Escolha errada ... Voltando para o Menu inicial");
                    MenuGeral();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            Thread.Sleep(pausaDoProgramaCasoErro);
            Console.Clear();
            MenuGeral();
        }
    }

    //Método do Menu do funcionário
    private void Funcionario()
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo :-)");
        Console.WriteLine("O que deseja fazer hoje? ");
        Console.WriteLine("1 - Consultar lista de produtos");
        Console.WriteLine("2 - Editar Produtos");
        Console.WriteLine("3 - Excluir Produtos");
        Console.Write("R: ");
        //Tratamento de exceção ou erro caso o usuário digite uma letra ou inves do número
        try
        {
            int resposta = int.Parse(Console.ReadLine());
            //fluxo para verificar qual foi a escolha do usuário e direcionar ele adequadamente
            switch (resposta)
            {
                case 1:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    MenuProdutos.ListaDeProdutos();
                    break;
                case 2:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    MenuProdutos.EdicaoDeProdutos();
                    break;
                case 3:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    MenuProdutos.ExclusaoDeProdutos();
                    break;
                default:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("Escolha errada ... Voltando para o Menu");
                    Funcionario();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            Thread.Sleep(pausaDoProgramaCasoErro);
            Console.Clear();
            Funcionario();
        }
    }

    // Método do Menu do cliente
    private void Cliente()
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo :-)");
        Console.WriteLine("O que deseja fazer hoje? ");
        Console.WriteLine("\n1 - Consultar Produtos");
        Console.WriteLine("2 - Comprar um item");
        Console.Write("R: ");
        //Tratamento de exceção ou erro caso o usuário digite uma letra ou inves do número
        try
        {
            int resposta = int.Parse(Console.ReadLine());
            //fluxo para verificar qual foi a escolha do usuário e direcionar ele adequadamente
            switch (resposta)
            {
                case 1:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    MenuVenda.ConsultaCliente();
                    break;
                case 2:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    MenuVenda.Compras();
                    break;
                default:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("Escolha errada ... Voltando para o Menu");
                    Funcionario();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            Thread.Sleep(pausaDoProgramaCasoErro);
            Console.Clear();
            Cliente();
        }
    }

    //Método do para verificar se o cliente ou funcionario desejam voltar ao menu anterior.
    public void VoltarAoMenu()
    {
        Thread.Sleep(pausaDoProgramaCasoErro);
        Console.Clear();
        Console.WriteLine("Você Deseja: ");
        Console.WriteLine("1 - Voltar ao Menu Geral");
        Console.WriteLine("2 - Voltar ao Menu do Funcionario");
        Console.WriteLine("3 - Voltar ao Menu do Cliente");
        Console.WriteLine("0 - Encerrar o programa");
        Console.Write("R: ");
        //Tratamento de exceção ou erro caso o usuário digite uma letra ou inves do número
        try
        {
            int resposta = int.Parse(Console.ReadLine());
            //fluxo para verificar qual foi a escolha do usuário e direcionar ele adequadamente
            switch (resposta)
            {
                case 1:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("Indo para o Menu Inicial");
                    MenuGeral();
                    Thread.Sleep(pausaDoPrograma);
                    break;
                case 2:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("indo para o Menu do Funcionario");
                    Funcionario();
                    Thread.Sleep(pausaDoPrograma);
                    break;
                case 3:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("Indo para o Menu do Cliente");
                    Thread.Sleep(pausaDoPrograma);
                    Cliente();
                    break;
                case 0:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("Saindo do programa ... ");
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Thread.Sleep(pausaDoPrograma);
                    Console.Clear();
                    Console.WriteLine("Escolha incorreta, encerrando o programa");
                    Thread.Sleep(pausaDoPrograma);
                    System.Environment.Exit(0);
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            Thread.Sleep(pausaDoProgramaCasoErro);
            Console.Clear();
            VoltarAoMenu();
        }
    }
}
