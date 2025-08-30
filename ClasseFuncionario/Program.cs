using ClasseFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario F1 = new Funcionario();  //funcionario = classe, tipo, estrututra  
        //                                  //f1 = objeto, variavel de instancia  
        //                                 //new = alocacao de memoria 
        //                                //funcionario() = metodo construtuor - nome da classe com os parenteses 
        
        Console.Write("Digite o código do funcionario: ");
        F1.codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome: ");
        F1.nome = Console.ReadLine();
        Console.Write("Informe o salario: ");
        F1.salario = Convert.ToDouble(Console.ReadLine());
        F1.MostrarAtributos();
        F1.CalcularSalario();
        F1.MostrarAtributos();
    }
}