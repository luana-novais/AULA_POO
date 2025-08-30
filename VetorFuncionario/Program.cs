using VetorFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario [] VetFuncionario = new Funcionario[3];
        double soma = 0;
        
        for (int i = 0; i < VetFuncionario.Length; i++)
        {
            VetFuncionario[i] = new Funcionario();

            Console.WriteLine("Digite o código do fucionario");
            VetFuncionario[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome: ");
            VetFuncionario[i].nome = Console.ReadLine();

            Console.Write("Digite o salario: ");
            VetFuncionario[i].salario = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < VetFuncionario.Length; i++)
        {
            VetFuncionario[i].MostrarAtributos();
            soma += VetFuncionario[i].salario;
        }

        Console.WriteLine("Total de sálarios: " + soma);

    }
}