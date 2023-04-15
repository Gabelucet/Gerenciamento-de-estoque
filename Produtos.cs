/*1 - Cadastro de produtos: o usuário deve poder cadastrar um novo produto no sistema, informando o nome, preço e quantidade em estoque.

2 - Listagem de produtos: o usuário deve poder listar todos os produtos cadastrados no sistema, exibindo o nome, preço e quantidade em estoque de cada produto.

3 - Edição de produtos: o usuário deve poder editar as informações de um produto cadastrado, como o nome, preço e quantidade em estoque.

4 - Exclusão de produtos: o usuário deve poder excluir um produto cadastrado no sistema*/

class Produtos
{
    public int QuantidadeNoEstoque { get; set; }
    public string NomeDoProduto { get; set; }
    public int CodigoDoProduto { get; set; }
    public double PrecoDoProduto { get; set; }

    public void CadastroDeProduto(){}
    public void ListaDeProdutos(){}
    public void EdicaoDeProdutos(){}
    public void ExclusaoDeProdutos(){}


}