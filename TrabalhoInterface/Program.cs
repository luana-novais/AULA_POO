using TrabalhoInterface;

ContaCorrente conta = new ContaCorrente(5000); 
SeguroDeVida seguro = new SeguroDeVida();

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

totalizador.Adiciona(conta);
totalizador.Adiciona(seguro);

Console.WriteLine("Imposto da Conta Corrente: " + conta.CalculaTributos());
Console.WriteLine("Imposto do Seguro de Vida: " + seguro.CalculaTributos());
Console.WriteLine("Total de Tributos: " + totalizador.Total);