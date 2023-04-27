class Produto
{
    public int QuantidadeNoEstoque { get; set; }
    public string NomeDoProduto { get; set; }
    public int ID { get; set; }
    public double PrecoDoProduto { get; set; }

    //Variavel responsáveis por controlar o tempo do Thread.Sleep do código, pois a cada comando, coloquei uma pausa, para o usuário não trocar apenas de tela ou mensagem
    int pausaDoPrograma = 2500;

    public static List<Produto> produtos = new List<Produto>();

    /*Esse método está mostra para a minha classe e minha lista como deve mostrar os objetos na tela.
    Sem a definição do método ToString(), o C# não sabe como converter um objeto da classe Produtos em uma string para ser impressa no console. É por isso que você estava vendo apenas o nome completo da classe Produtos impresso na tela em vez dos detalhes do produto.
    Ao implementar o método ToString() dentro da classe Produtos, você está especificando como um objeto Produtos deve ser convertido em uma string para impressão no console. Com a implementação do método ToString(), agora quando você chama Console.WriteLine(item), o C# sabe como converter o objeto item em uma string que pode ser impressa no console com os detalhes do produto. */
    public override string ToString()
    {
        return $"Código: {ID}\nNome do produto: {NomeDoProduto}\nPreço: {PrecoDoProduto}\nQuantidade em Estoque: {QuantidadeNoEstoque}\n";
    }

    //Método que mostra para o usuário todos os produtos que temos cadastrado
    public void ListaDeProdutos()
    {
        Console.WriteLine("Os produtos atuais que temos no estoque são: ");

        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }
        Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
        Console.ReadKey();
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    //método para editar algum produto que temos cadastrado
    public void EdicaoDeProdutos()
    {
        Console.WriteLine("Atualmente temos esses itens");
        foreach (var item in produtos)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Me informe o código do produto que deseja Editar");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        Produto produtoParaeditar = produtos.Find(p => p.ID == resposta);

        Thread.Sleep(pausaDoPrograma);
        Console.Clear();

        Console.WriteLine("Me informe o que deseja editar: ");
        Console.WriteLine("1 - Para editar Preço do produto");
        Console.WriteLine("2 - Para editar a quantidade em estoque");
        Console.Write("R: ");
        int escolha = int.Parse(Console.ReadLine());
        
        //fluxo para verificar qual foi a escolha do usuário e direcionar ele adequadamente
        switch (escolha)
        {
            case 1:
                Thread.Sleep(pausaDoPrograma);
                Console.Clear();
                Console.Write("Me informe o novo valor do produto: ");
                double novoValor = double.Parse(Console.ReadLine());
                produtoParaeditar.PrecoDoProduto = novoValor;
                Console.WriteLine($"O valor foi alterado para R$ {novoValor}");
                Console.WriteLine(produtoParaeditar);
                Thread.Sleep(pausaDoPrograma);
                break;
            case 2:
                Thread.Sleep(pausaDoPrograma);
                Console.Clear();
                Console.Write("Me informe a quantidade no estoque do produto: ");
                int novaQuantidadeEstoque = int.Parse(Console.ReadLine());
                produtoParaeditar.QuantidadeNoEstoque = novaQuantidadeEstoque;
                Console.WriteLine($"A nova quantidade no estoque é {novaQuantidadeEstoque}");
                Console.WriteLine(produtoParaeditar);
                Thread.Sleep(pausaDoPrograma);
                break;
            default:
                Console.WriteLine("Opção invalida. Voltando ao Menu");
                Thread.Sleep(pausaDoPrograma);
                EdicaoDeProdutos();
                Console.Clear();
                break;
        }

        Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
        Console.ReadKey();
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    //método para Excluir algum produto que temos cadastrado
    public void ExclusaoDeProdutos()
    {
        Console.WriteLine("Atualmente temos esses itens: \n");
        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }

        Console.WriteLine("Me informe o código do produto que deseja excluir");

        int resposta = int.Parse(Console.ReadLine());

        // encontra o produto correspondente ao ID informado
        Produto produtoParaExcluir = produtos.Find(p => p.ID == resposta);

        if (produtoParaExcluir != null)
        {
            // remove o produto da lista
            produtos.Remove(produtoParaExcluir);

            Console.WriteLine("Produto excluído com sucesso!");

            Thread.Sleep(pausaDoPrograma);
            Console.Clear();

            Console.WriteLine("Lista atualizada");

            foreach (var item in produtos)
            {
                Console.WriteLine(item);
                Console.WriteLine("\n");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado. Nenhum produto foi excluído.");
        }

        Console.WriteLine("Aperte uma tecla para pode voltar ao Menu");
        Console.ReadKey();
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }
}
