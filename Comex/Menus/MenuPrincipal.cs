using Comex.Ordenacoes;

namespace Comex.Menus;
public class MenuPrincipal
{
    public async Task InicializaAplicacao()
    {
        await ExibirOpcoesDoMenu();
    }

    async Task ExibirOpcoesDoMenu()
    {
        var opcao = true;

        while (opcao == true)
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 Criar Produto");
            Console.WriteLine("Digite 2 Listar Produtos");
            Console.WriteLine("Digite 3 Consultar API Externa");
            Console.WriteLine("Digite 4 Ordenar Produtos pelo Título");
            Console.WriteLine("Digite 5 Ordenar Produtos pelo Preço");
            Console.WriteLine("Digite 6 Criar Pedido");
            Console.WriteLine("Digite 7 Listar Pedidos");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    MenuCriarProduto criarProduto = new MenuCriarProduto();
                    criarProduto.CriarProduto();
                    break;
                case 2:
                    MenuListarProdutos menuListarProdutos = new MenuListarProdutos();
                    menuListarProdutos.ListarProdutos();
                    break;
                case 3:
                    MenuConsultarApiExterna menuConsultarApiExterna = new MenuConsultarApiExterna();
                    await menuConsultarApiExterna.ConsultarApiExterna();
                    break;
                case 4:
                    OrdenaLista ordenaListaPorNome = new OrdenaLista();
                    ordenaListaPorNome.OrdenarProdutosPorTitulo();
                    break;
                case 5:
                    OrdenaLista ordenaListaPorPreco = new OrdenaLista();
                    ordenaListaPorPreco.OrdenarProdutosPorPreco();
                    break;
                case 6:
                    MenuCriarPedido menuCriarPedido = new MenuCriarPedido();
                    menuCriarPedido.CriarPedido();
                    break;
                case 7:
                    MenuListarPedidos menuListarPedidos = new MenuListarPedidos();
                    menuListarPedidos.ListarPedidos();
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    opcao = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    void ExibirLogo()
    {
        string mensagemDeBoasVindasDoProjeto = "Boas vindas ao COMEX";
        Console.WriteLine(@"
────────────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██░░██████████─██░░██████░░██─██░░░░░░░░░░░░░░░░░░██─██░░██████████─████░░██──██░░████─
─██░░██─────────██░░██──██░░██─██░░██████░░██████░░██─██░░██───────────██░░░░██░░░░██───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░░░░░░░░░██─────██░░░░░░██─────
─██░░██─────────██░░██──██░░██─██░░██──██████──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──────────██░░██─██░░██───────────██░░░░██░░░░██───
─██░░██████████─██░░██████░░██─██░░██──────────██░░██─██░░██████████─████░░██──██░░████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
────────────────────────────────────────────────────────────────────────────────────────");
        Console.WriteLine(mensagemDeBoasVindasDoProjeto);
    }
}
