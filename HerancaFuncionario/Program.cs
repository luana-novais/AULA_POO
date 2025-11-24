using HerancaFuncionario;

Funcionario f = new Funcionario(1000);
Console.WriteLine($"Funcionario: {f.CalcularBonificacao():c}");

Secretario s = new Secretario(1000);
Console.WriteLine($"Secretario: {s.CalcularBonificacao():c}");

Gerente g = new Gerente(1000);
Console.WriteLine($"Gerente: {g.CalcularBonificacao():c}");

Diretor d = new Diretor(1000);
Console.WriteLine($"Diretor: {d.CalcularBonificacao():c}");

GerenciadorBonificacao gb = new GerenciadorBonificacao();
gb.TotalizadorBonificacao(f);
gb.TotalizadorBonificacao(s);
gb.TotalizadorBonificacao(g);
gb.TotalizadorBonificacao(d);

Console.WriteLine($"Total de Bonificações: {gb.TotalBonificacao:c}");
