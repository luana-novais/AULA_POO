using TrabalhoVetorProduto;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto[] VetProduto = new Produto[6];

        for (int i = 0; i < VetProduto.Length; i++)
        {
            VetProduto[i] = new Produto();

            Console.WriteLine("Digite o código do produto: ");
            VetProduto[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto: ");
            VetProduto[i].nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            VetProduto[i].preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o estoque inicial: ");
            VetProduto[i].estoque = Convert.ToInt32(Console.ReadLine());

            VetProduto[i].CalcularSubtotal();

        }

        foreach (Produto p in VetProduto)
            p.MostrarAtributos();

        for (int i = 0; i < VetProduto.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Digite a porcentagem de aumento do produto: ");
                double percent = Convert.ToDouble(Console.ReadLine());
                VetProduto[i].CalcularAumento(percent);
            }
            else
            {
                Console.Write("Informe a quantidade que deseja retirar do estoque: ");
                int qtde = Convert.ToInt32(Console.ReadLine());
                VetProduto[i].RetirarEstoque(qtde);
            }

            VetProduto[i].CalcularSubtotal();
        }
        foreach (Produto p in VetProduto)
            p.MostrarAtributos();
    }
}