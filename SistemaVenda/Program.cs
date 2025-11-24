using SistemaVenda;

List<Produto> produtos = new List<Produto>();
Venda venda = new Venda();

string opcao;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Adicionar Item à Venda");
    Console.WriteLine("3 - Ver Resumo da Venda");
    Console.WriteLine("4 - Escolher Pagamento");
    Console.WriteLine("5 - Finalizar");
    Console.Write("Escolha: ");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.Write("Código do produto: ");
        long codigo = Convert.ToInt64(Console.ReadLine());

        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        int estoque = Convert.ToInt32(Console.ReadLine());

        Produto p = new Produto(codigo, nome, preco, estoque);
        produtos.Add(p);

        Console.WriteLine("Produto cadastrado!");
    }

    else if (opcao == "2")
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado!");
            continue;
        }

        Console.WriteLine("\nProdutos disponíveis:");
        foreach (var prod in produtos)
        {
            Console.WriteLine($"{prod.Codigo} - {prod.Nome} (R$ {prod.Preco})");
        }

        Console.Write("Digite o código do produto: ");
        long codBusca = Convert.ToInt64(Console.ReadLine());

        Produto escolhido = null;

        foreach (var prod in produtos)
        {
            if (prod.Codigo == codBusca)
                escolhido = prod;
        }

        if (escolhido == null)
        {
            Console.WriteLine("Produto não encontrado.");
            continue;
        }

        Console.Write("Quantidade: ");
        int qtd = Convert.ToInt32(Console.ReadLine());

        ItemVenda item = new ItemVenda(escolhido, qtd);
        venda.AdicionaItem(item);

        Console.WriteLine("Item adicionado!");
    }

    else if (opcao == "3")
    {
        Console.WriteLine("\n--- RESUMO DA VENDA ---");

        foreach (var item in venda.VetItens)
        {
            Console.WriteLine($"{item.Quantidade}x {item.Produto.Nome} -> Subtotal: R$ {item.Subtotal:F2}");
        }

        Console.WriteLine($"TOTAL: R$ {venda.Total:F2}");
    }

    else if (opcao == "4")
    {
        Console.WriteLine("\n--- TIPOS DE PAGAMENTO ---");
        Console.WriteLine("1 - Cartão");
        Console.WriteLine("2 - Espécie");
        Console.WriteLine("3 - Cheque");

        Console.Write("Escolha: ");
        string tipo = Console.ReadLine();

        if (tipo == "1")
        {
            Console.Write("Código da transação: ");
            string codTransacao = Console.ReadLine();

            venda.Pagamento = new Cartao(venda.Total, codTransacao);
            venda.Pagamento.ProcessarPagamento();
        }
        else if (tipo == "2")
        {
            Console.Write("Valor entregue pelo cliente: ");
            double entregue = Convert.ToDouble(Console.ReadLine());

            venda.Pagamento = new Especie(venda.Total, entregue);
            venda.Pagamento.ProcessarPagamento();
        }
        else if (tipo == "3")
        {
            Console.Write("Número do cheque: ");
            long num = Convert.ToInt64(Console.ReadLine());

            venda.Pagamento = new Cheque(venda.Total, num, DateTime.Now);
            venda.Pagamento.ProcessarPagamento();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

} while (opcao != "5");

Console.WriteLine("\nPrograma encerrado.");
