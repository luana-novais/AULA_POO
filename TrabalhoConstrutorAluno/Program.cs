using TrabalhoConstrutorAluno;
class Program
{
    static void Main()
    {
        Aluno a1 = new Aluno("João");
        Aluno a2 = new Aluno("Maria");
        Aluno a3 = new Aluno("Luana");

        a1.MostrarAtributos();
        a2.MostrarAtributos();
        a3.MostrarAtributos();
    }
}