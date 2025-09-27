using AgregacaoCOnta;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli = new Cliente();
        cli.Nome = "Bia";
        cli.Rg = 100;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 1000;
        c1.Titular = cli; //a relação de agregação foi efetivada no armazenamento do objeto cliente(clia) no atributo Titular que agora o Titular passa a ser um objeto Cliente

        Conta c2 = new Conta();
        c2.Numero = 2;
        c2.Saldo = 2000;
        c2.Titular = new Cliente();
        c2.Titular.Nome = "Leo";
        c2.Titular.Rg = 200;
    }
}