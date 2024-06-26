using System.Text.Json.Serialization;

namespace Comex.Modelos;

public class Produto
{  
    public Produto(string nome)
    {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public static List<Produto> listaDeProdutosParaSerUtilizadaDuranteOsTestes = new();

    public static void InicializaListaDeProdutos()
    {
        Produto produto1 = new Produto("Notebook");
        produto1.Descricao = "Notebook Dell Inspiron";
        produto1.PrecoUnitario = 3500.00;
        produto1.Quantidade = 10;

        Produto produto2 = new Produto("Smartphone");
        produto2.Descricao = "Smartphone Samsung Galaxy";
        produto2.PrecoUnitario = 1200.00;
        produto2.Quantidade = 25;

        Produto produto3 = new Produto("Monitor");
        produto3.Descricao = "Monitor LG Ultrawide";
        produto3.PrecoUnitario = 800.00;
        produto3.Quantidade = 15;

        Produto produto4 = new Produto("Teclado");
        produto4.Descricao = "Teclado Mecânico RGB";
        produto4.PrecoUnitario = 250.00;
        produto4.Quantidade = 50;

        listaDeProdutosParaSerUtilizadaDuranteOsTestes.Add(produto1);
        listaDeProdutosParaSerUtilizadaDuranteOsTestes.Add(produto2);
        listaDeProdutosParaSerUtilizadaDuranteOsTestes.Add(produto3);
        listaDeProdutosParaSerUtilizadaDuranteOsTestes.Add(produto4);
    }

    public static void ListarProdutos()
    {
        Console.Clear();

        Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

        for (int i = 0; i < listaDeProdutosParaSerUtilizadaDuranteOsTestes.Count; i++)
        {
            Console.WriteLine($"Produto: {listaDeProdutosParaSerUtilizadaDuranteOsTestes[i].Nome}, Preço: {listaDeProdutosParaSerUtilizadaDuranteOsTestes[i].PrecoUnitario:F2}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}