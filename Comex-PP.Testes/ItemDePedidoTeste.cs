using Comex.Modelos;

namespace Comex_PP.Testes;

public class ItemDePedidoTeste
{
    [Fact]
    public void TestaCalculaSubtotal()
    {
        Produto produto = new("Produto 1");
        produto.Quantidade = 5;
        produto.PrecoUnitario = 10;
        ItemDePedido itemDePedido = new(produto, produto.Quantidade, produto.PrecoUnitario);

        var validacao = itemDePedido.Subtotal;

        Assert.Equal(50, validacao);
    }
}