using Comex.Modelos;

namespace Comex.Menus;

public class MenuCriarProduto
{
    public void CriarProduto()
    {
        Console.Clear();
        Console.WriteLine("Registro de Produto");

        Console.Write("Digite o nome do Produto: ");
        string nomeDoProduto = Console.ReadLine();
        var produto = new Produto(nomeDoProduto);

        Console.Write("Digite a descrição do Produto: ");
        string descricaoDoProduto = Console.ReadLine();
        produto.Descricao = descricaoDoProduto;

        Console.Write("Digite o preço do Produto: ");
        string preçoDoProduto = Console.ReadLine();
        produto.PrecoUnitario = double.Parse(preçoDoProduto);

        Console.Write("Digite a quantidade do Produto: ");
        string quantidadeDoProduto = Console.ReadLine();
        produto.Quantidade = int.Parse(quantidadeDoProduto);

        Produto.listaDeProdutosParaSerUtilizadaDuranteOsTestes.Add(produto);
        Console.WriteLine($"O Produto {produto.Nome} foi registrado com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
