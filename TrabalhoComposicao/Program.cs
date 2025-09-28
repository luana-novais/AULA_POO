using TrabalhoComposicao;
class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco();


        banco.AbrirConta(1000, 500); 
        banco.AbrirConta(200, 300);  

        banco.AbrirPoupanca(1500);
        banco.AbrirPoupanca(300);

        banco.MostrarContas();
        banco.MostrarPoupancas();

        var conta = banco.Contas[0];
        conta.Depositar(200);
        conta.Sacar(500);
        conta.GerarExtrato();

        var poup = banco.Poupanca[0];
        poup.Depositar(100);
        poup.Sacar(50);
        poup.GerarRendimento();
        Console.WriteLine($"Saldo final poupança: R${poup.Saldo:F2}");

        banco.DecretarFalencia();
        banco.MostrarContas();
        banco.MostrarPoupancas();
    }
}