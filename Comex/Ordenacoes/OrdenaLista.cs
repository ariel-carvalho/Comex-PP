﻿using Comex.Modelos;

namespace Comex.Ordenacoes;

public class OrdenaLista
{
    public void OrdenarProdutosPorTitulo()
    {
        var produtosOrdenados = Produto.listaDeProdutosParaSerUtilizadaDuranteOsTestes.OrderBy(p => p.Nome).ToList();
        Console.Clear();
        Console.WriteLine("Produtos ordenados pelo título:");
        for (int i = 0; i < produtosOrdenados.Count; i++)
        {
            Console.WriteLine($"Produto: {produtosOrdenados[i].Nome}, Preço: {produtosOrdenados[i].PrecoUnitario:F2}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    public void OrdenarProdutosPorPreco()
    {
        var produtosOrdenadosPorPreco = Produto.listaDeProdutosParaSerUtilizadaDuranteOsTestes.OrderBy(p => p.PrecoUnitario).ToList();
        Console.Clear();
        Console.WriteLine("Produtos ordenados pelo preço:");
        for (int i = 0; i < produtosOrdenadosPorPreco.Count; i++)
        {
            Console.WriteLine($"Produto: {produtosOrdenadosPorPreco[i].Nome}, Preço: {produtosOrdenadosPorPreco[i].PrecoUnitario:F2}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
