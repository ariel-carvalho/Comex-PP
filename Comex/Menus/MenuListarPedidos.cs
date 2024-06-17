using Comex.Modelos;

namespace Comex.Menus;

public class MenuListarPedidos
{
    public void ListarPedidos()
    {
        Console.Clear();
        Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

        var pedidosOrdenados = Pedido.listaDePedidosParaSerUtilizadaDuranteOsTestes.OrderBy(p => p.Cliente.Nome).ToList();

        foreach (var Pedido in pedidosOrdenados)
        {
            Console.WriteLine($"Cliente: {Pedido.Cliente.Nome}, Total: {Pedido.Total:F2}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
