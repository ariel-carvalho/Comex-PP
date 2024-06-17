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

    public void InicializaListaDeProdutos()
    {
        Produto produto1 = new Produto("Notebook");
        produto1.Descricao = "Notebook Dell Inspiron";
        produto1.PrecoUnitario = 3500.00;
        produto1.Quantidade = 10;

        Produto produto2 = new Produto("Notebook");
        produto2.Descricao = "Notebook Dell Inspiron";
        produto2.PrecoUnitario = 3500.00;
        produto2.Quantidade = 10;

        Produto produto3 = new Produto("Notebook");
        produto3.Descricao = "Notebook Dell Inspiron";
        produto3.PrecoUnitario = 3500.00;
        produto3.Quantidade = 10;

        Produto produto4 = new Produto("Notebook");
        produto4.Descricao = "Notebook Dell Inspiron";
        produto4.PrecoUnitario = 3500.00;
        produto4.Quantidade = 10;

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

