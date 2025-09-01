using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Titular = "Ana";
        c1.Saldo = 200;

        Conta c2 = new Conta();
        Console.WriteLine("Digite o número: ");
        c2.Numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome: ");
        c2.Titular = Console.ReadLine();
        Console.WriteLine("Digite o saldo: ");
        c2.Saldo = Convert.ToDouble(Console.ReadLine());

        c1.MostrarAtributos();
        c2.MostrarAtributos();
    }
}