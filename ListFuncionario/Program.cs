using ListFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Funcionario> VetFuncionario = new List<Funcionario>();

        double soma = 0;
        
        for (int i = 0; i < 3; i++)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o código do fucionario");
            f.codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome: ");
            f.nome = Console.ReadLine();

            Console.Write("Digite o salario: ");
            f.salario = Convert.ToDouble(Console.ReadLine());

            soma += f.salario;
            VetFuncionario.Add(f);
        }

        foreach (Funcionario func in VetFuncionario)
            func.MostrarAtributos();

    Console.WriteLine($"Total de sálarios é: {soma:c}");

    }
}