using VetorConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta[] VetContas = new Conta[3];

        for (int i = 0; i < VetContas.Length; i++)
        {
            //instanciação de CADA indice 
            VetContas[i] = new Conta();

            Console.WriteLine("Digite o número da conta");
            VetContas[i].numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o titular: ");
            VetContas[i].titular = Console.ReadLine();

            Console.Write("Digite o saldo: ");
            VetContas[i].saldo = Convert.ToDouble(Console.ReadLine());

        }
        for (int i = 0; i < VetContas.Length; i++)
        VetContas[i].MostrarAtributos();
        
        // o foreach APENAS pode ser usado para vetor que já tenha conteudo
        foreach (Conta c in VetContas)
            c.MostrarAtributos();
    }
}