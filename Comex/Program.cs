using Comex;
using System.Text.Json;

var listaDeProdutosParaSerUtilizadaDuranteOsTestes = new List<Produto>
{
    new Produto("Notebook")
    {
        Descricao = "Notebook Dell Inspiron",
        PrecoUnitario = 3500.00,
        Quantidade = 10
    },
    new Produto("Smartphone")
    {
        Descricao = "Smartphone Samsung Galaxy",
        PrecoUnitario = 1200.00,
        Quantidade = 25
    },
    new Produto("Monitor")
    {
        Descricao = "Monitor LG Ultrawide",
        PrecoUnitario = 800.00,
        Quantidade = 15
    },
    new Produto("Teclado")
    {
        Descricao = "Teclado Mecânico RGB",
        PrecoUnitario = 250.00,
        Quantidade = 50
    }
};

var listaDePedidosParaSerUtilizadaDuranteOsTestes = new List<Pedido>();

string mensagemDeBoasVindasDoProjeto = "Boas vindas ao COMEX";

void ExibirLogo()
{
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

async Task ExibirOpcoesDoMenu()
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
            criarProduto();
            await ExibirOpcoesDoMenu();
            break;
        case 2:
            ListarProdutos();  
            await ExibirOpcoesDoMenu();
            break;
        case 3:
            await ConsultarApiExterna();
            await ExibirOpcoesDoMenu();
            break;
        case 4:
            OrdenarProdutosPorTitulo();
            await ExibirOpcoesDoMenu();
            break;
        case 5:
            OrdenarProdutosPorPreco();
            await ExibirOpcoesDoMenu();
            break;
        case 6:
            CriarPedido();
            await ExibirOpcoesDoMenu();
            break;
        case 7:
            ListarPedidos();
            await ExibirOpcoesDoMenu();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

await ExibirOpcoesDoMenu();

void criarProduto()
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

    listaDeProdutosParaSerUtilizadaDuranteOsTestes.Add(produto);
    Console.WriteLine($"O Produto {produto.Nome} foi registrado com sucesso!");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}

void ListarProdutos()
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

void OrdenarProdutosPorTitulo()
{
    var produtosOrdenados = listaDeProdutosParaSerUtilizadaDuranteOsTestes.OrderBy(p => p.Nome).ToList();
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

void OrdenarProdutosPorPreco()
{
    var produtosOrdenadosPorPreco = listaDeProdutosParaSerUtilizadaDuranteOsTestes.OrderBy(p => p.PrecoUnitario).ToList();
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
void CriarPedido()
{
    Console.Clear();
    Console.WriteLine("Criando um novo pedido\n");

    Console.Write("Digite o nome do cliente: ");
    string nomeCliente = Console.ReadLine()!;
    var cliente = new Cliente();
    cliente.Nome = nomeCliente;

    var pedido = new Pedido(cliente);

    Console.WriteLine("\nProdutos disponíveis:");
    for (int i = 0; i < listaDeProdutosParaSerUtilizadaDuranteOsTestes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {listaDeProdutosParaSerUtilizadaDuranteOsTestes[i].Nome}");
    }

    Console.Write("Digite o número do produto que deseja adicionar (ou 0 para finalizar): ");
    int numeroProduto = int.Parse(Console.ReadLine()!);

    var produtoEscolhido = listaDeProdutosParaSerUtilizadaDuranteOsTestes[numeroProduto - 1];

    Console.Write("Digite a quantidade: ");
    int quantidade = int.Parse(Console.ReadLine()!);

    var itemDePedido = new ItemDePedido(produtoEscolhido, quantidade, produtoEscolhido.PrecoUnitario);
    pedido.AdicionarItem(itemDePedido);

    Console.WriteLine($"Item adicionado: {itemDePedido}\n");


    listaDePedidosParaSerUtilizadaDuranteOsTestes.Add(pedido);
    Console.WriteLine($"\nPedido criado com sucesso:\n{pedido}");
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();
}

void ListarPedidos()
{
    Console.Clear();
    Console.WriteLine("Exibindo todos os produtos registradoss na nossa aplicação");

    var pedidosOrdenados = listaDePedidosParaSerUtilizadaDuranteOsTestes.OrderBy(p => p.Cliente.Nome).ToList();

    foreach (var Pedido in pedidosOrdenados)
    {
        Console.WriteLine($"Cliente: {Pedido.Cliente.Nome}, Total: {Pedido.Total:F2}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}

async Task ConsultarApiExterna()
{
    using (HttpClient client = new HttpClient())
    {
        try
        {
            Console.Clear();
            Console.WriteLine("\nExibindo Produtos\n");
            string resposta = await client.GetStringAsync("http://fakestoreapi.com/products");
            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"Nome: {produtos[i].Nome}, " +
                    $"Descrição: {produtos[i].Descricao}, " +
                    $"Preço {produtos[i].PrecoUnitario} \n");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            await ExibirOpcoesDoMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Temos um problema: {ex.Message}");
        }
    }
}
