using Comex.Modelos;

namespace Comex.Menus;

public class MenuCriarPedido
{
    public void CriarPedido()
    {
        Console.Clear();
        Console.WriteLine("Criando um novo pedido\n");

        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine()!;
        var cliente = new Cliente();
        cliente.Nome = nomeCliente;

        var pedido = new Pedido(cliente);

        Console.WriteLine("\nProdutos disponíveis:");
        for (int i = 0; i < Produto.listaDeProdutosParaSerUtilizadaDuranteOsTestes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Produto.listaDeProdutosParaSerUtilizadaDuranteOsTestes[i].Nome}");
        }

        Console.Write("Digite o número do produto que deseja adicionar (ou 0 para finalizar): ");
        int numeroProduto = int.Parse(Console.ReadLine()!);

        var produtoEscolhido = Produto.listaDeProdutosParaSerUtilizadaDuranteOsTestes[numeroProduto - 1];

        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        var itemDePedido = new ItemDePedido(produtoEscolhido, quantidade, produtoEscolhido.PrecoUnitario);
        pedido.AdicionarItem(itemDePedido);

        Console.WriteLine($"Item adicionado: {itemDePedido}\n");


        Pedido.listaDePedidosParaSerUtilizadaDuranteOsTestes.Add(pedido);
        Console.WriteLine($"\nPedido criado com sucesso:\n{pedido}");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
    }
}
