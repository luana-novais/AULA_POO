using EncapsulamentoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario F1 = new Funcionario();                               //funcionario() = metodo construtuor - nome da classe com os parenteses 
        Console.Write("Digite o código do funcionario: ");
        F1.Codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome: ");
        F1.Nome = Console.ReadLine();
        Console.Write("Informe o salario: ");
        F1.Salario = Convert.ToDouble(Console.ReadLine());
        F1.MostrarAtributos();
        F1.CalcularSalario();
        F1.MostrarAtributos();
    }
}