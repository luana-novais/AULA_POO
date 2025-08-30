using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto P1 = new Produto();

        Console.Write("Digite o código do produto: ");
        P1.codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do produto: ");
        P1.nome = Console.ReadLine();

        Console.Write("Digite o valor do produto: ");
        P1.preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o estoque inicial: ");
        P1.estoque = Convert.ToInt32(Console.ReadLine());

        P1.CalcularSubtotal();
        P1.MostrarAtributos();

        Console.Write("Informe a porcentagem do aumento: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        //envio de mensagem
        P1.CalcularAumento(percent); //chamada da função

        P1.CalcularSubtotal();
        P1.MostrarAtributos();

        Console.Write("Informe a quantidade que deseja retirar do estoque: ");
        int qtde = Convert.ToInt32(Console.ReadLine());
        
        P1.RetirarEstoque(qtde);
        P1.CalcularSubtotal();
        P1.MostrarAtributos();
    }
}