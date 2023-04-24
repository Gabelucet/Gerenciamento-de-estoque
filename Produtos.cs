/*1 - Cadastro de produtos: o usuário deve poder cadastrar um novo produto no sistema, informando o nome, preço e quantidade em estoque.

2 - Listagem de produtos: o usuário deve poder listar todos os produtos cadastrados no sistema, exibindo o nome, preço e quantidade em estoque de cada produto.

3 - Edição de produtos: o usuário deve poder editar as informações de um produto cadastrado, como o nome, preço e quantidade em estoque.

4 - Exclusão de produtos: o usuário deve poder excluir um produto cadastrado no sistema*/


class Produtos
{
    public int QuantidadeNoEstoque { get; set; }
    public string NomeDoProduto { get; set; }
    public int ID { get; set; }
    public double PrecoDoProduto { get; set; }

    public static List<Produtos> produtos = new List<Produtos>();

    /*public Produtos(
        string NomeDoProduto,
        int CodigoDoProduto,
        double PrecoDoProduto,
        int QuantidadeNoEstoque
    )
    {
        this.NomeDoProduto = NomeDoProduto;
        this.CodigoDoProduto = CodigoDoProduto;
        this.PrecoDoProduto = PrecoDoProduto;
        this.QuantidadeNoEstoque = QuantidadeNoEstoque;
    }*/

    /*Esse método está mostra para a minha classe e minha lista como deve mostrar os objetos na tela.
    Sem a definição do método ToString(), o C# não sabe como converter um objeto da classe Produtos em uma string para ser impressa no console. É por isso que você estava vendo apenas o nome completo da classe Produtos impresso na tela em vez dos detalhes do produto.
    Ao implementar o método ToString() dentro da classe Produtos, você está especificando como um objeto Produtos deve ser convertido em uma string para impressão no console. Com a implementação do método ToString(), agora quando você chama Console.WriteLine(item), o C# sabe como converter o objeto item em uma string que pode ser impressa no console com os detalhes do produto. */
    public override string ToString()
    {
        return $"ID: {ID}, Nome do produto: {NomeDoProduto}, Preço: {PrecoDoProduto}, Quantidade em Estoque: {QuantidadeNoEstoque}";
    }

    public void CadastroDeProduto()
    {
        Produtos novosProdutos = new Produtos
        {
            NomeDoProduto = "Gelo",
            ID = 001,
            PrecoDoProduto = 3.99,
            QuantidadeNoEstoque = 999
        };

        Produtos novosProdutos1 = new Produtos
        {
            NomeDoProduto = "Água",
            ID = 002,
            PrecoDoProduto = 2.99,
            QuantidadeNoEstoque = 99
        };

        Produtos novosProdutos2 = new Produtos
        {
            NomeDoProduto = "Cerveja",
            ID = 003,
            PrecoDoProduto = 5.99,
            QuantidadeNoEstoque = 999
        };

        Produtos.produtos.Add(novosProdutos);
        Produtos.produtos.Add(novosProdutos1);
        Produtos.produtos.Add(novosProdutos2);

        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }

        /* string continuar = "s";
 
         while (continuar == "s")
         {
             Console.Write("Me informe o nome do produto\nR: ");
             NomeDoProduto = Console.ReadLine();
 
             Console.Write("Me informe o codigo do produto\nR: ");
             CodigoDoProduto = int.Parse(Console.ReadLine());
 
             Console.Write("Me informe o preço do produto\nR: ");
             PrecoDoProduto = double.Parse(Console.ReadLine());
 
             Console.Write("Me informe a quantidade em estoque do produto\nR: ");
             QuantidadeNoEstoque = int.Parse(Console.ReadLine());
 
             Produtos novosProdutos = new Produtos(
                 NomeDoProduto,
                 CodigoDoProduto,
                 PrecoDoProduto,
                 QuantidadeNoEstoque
             );
             produtos.Add(novosProdutos);
 
             Console.Write("Deseja continuar:\nS - SIM\nN - NÃO\nR:");
             string resposta = Console.ReadLine();
 
             continuar = resposta.ToLower();
             Console.Clear();
         }
 
         if (continuar == "n")
         {
             Console.WriteLine("Os produtos cadastrados foram:");
             foreach (var item in produtos)
             {
                 Console.WriteLine(item);
             }
         }*/
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    public void ListaDeProdutos()
    {
        Console.WriteLine("Os produtos atuais que temos no estoque são: ");

        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }
        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    public void EdicaoDeProdutos()
    {
        Console.WriteLine("Atualmente temos esses itens");
        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }

        Console.WriteLine("Me informe o código do produto que deseja Editar");
        Console.Write("R: ");
        int resposta = int.Parse(Console.ReadLine());

        Produtos produtoParaeditar = produtos.Find(p => p.ID == resposta);

        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("Me informe o que deseja editar: ");
        Console.WriteLine("1 - Para editar Preço do produto");
        Console.WriteLine("2 - Para editar a quantidade em estoque");
        Console.Write("R: ");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Thread.Sleep(1500);
                Console.Clear();
                Console.Write("Me informe o novo valor do produto: ");
                double novoValor = double.Parse(Console.ReadLine());
                produtoParaeditar.PrecoDoProduto = novoValor;
                Console.WriteLine($"O valor foi alterado para R$ {novoValor}");
                Console.WriteLine(produtoParaeditar);
                Thread.Sleep(5000);
                break;
            case 2:
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("Me informe a quantidade no estoque do produto: ");
                int novaQuantidadeEstoque = int.Parse(Console.ReadLine());
                produtoParaeditar.QuantidadeNoEstoque = novaQuantidadeEstoque;
                Console.WriteLine($"A nova quantidade no estoque é {novaQuantidadeEstoque}");
                Console.WriteLine(produtoParaeditar);
                Thread.Sleep(5000);
                break;
            default:
                Console.WriteLine("Opção invalida. Voltando ao Menu");
                Thread.Sleep(1500);
                Console.Clear();
                break;
        }

        Menu novo = new Menu();
        novo.VoltarAoMenu();
    }

    public void ExclusaoDeProdutos()
    {
        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }

        Console.WriteLine("Me informe o código do produto que deseja excluir");

        int resposta = int.Parse(Console.ReadLine());

        // encontra o produto correspondente ao ID informado
        Produtos produtoParaExcluir = produtos.Find(p => p.ID == resposta);

        if (produtoParaExcluir != null)
        {
            // remove o produto da lista
            produtos.Remove(produtoParaExcluir);

            Console.WriteLine("Produto excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado. Nenhum produto foi excluído.");
        }

        foreach (var item in produtos)
        {
            Console.WriteLine(item);
            Console.WriteLine("\n");
        }
    }
}
