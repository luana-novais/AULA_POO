using AbstrataFuncionario;

Endereco e = new Endereco("Terezina", 75, "Vila Paulo Roberto", "PP");
Console.WriteLine("=== ENDEREÇO ===");
e.Mostrar();


Assalariado a1 = new Assalariado(1, "Assalariado 1", e, 1000);
Assalariado a2 = new Assalariado(2, "Assalariado 2", e, 1000);

Comissionado c1 = new Comissionado(3, "Comissionado 1", e, 1000, 20);
Comissionado c2 = new Comissionado(4, "Comissionado 2", e, 1000, 30);

Console.WriteLine("\n=== DEPARTAMENTO TI ===");

Departamento d1 = new Departamento(1, "TI");
d1.VetF = new List<Funcionario>();  

d1.AdmitirFuncionario(a1);
d1.AdmitirFuncionario(c1);

d1.Mostrar();
d1.ListarFuncionarios();

Console.WriteLine($"Folha do Departamento TI: {d1.CalcularFolha(30):c}");

Console.WriteLine("\n=== DEPARTAMENTO RH ===");

Departamento d2 = new Departamento(2, "RH");
d2.VetF = new List<Funcionario>();  

d2.AdmitirFuncionario(a2);
d2.AdmitirFuncionario(c2);

d2.Mostrar();
d2.ListarFuncionarios();

d2.DemitirFuncionario(4);

Console.WriteLine("\nFuncionários após demissão:");
d2.ListarFuncionarios();

Console.WriteLine($"Folha do Departamento RH: {d2.CalcularFolha(30):c}");

Dependente dA = new Dependente { Codigo = 1, Nome = "Pedro", Idade = 10 };
Dependente dB = new Dependente { Codigo = 2, Nome = "Maria", Idade = 19 };

a1.AdicionarDependente(dA);
a1.AdicionarDependente(dB);

a1.ListarDependentes();

Console.WriteLine($"Total de dependentes: {a1.CalcularTotalDependente()}");

Console.WriteLine("\nRemovendo dependentes maiores de idade...");
a1.RemoverDependentesMaioridade(2);

a1.ListarDependentes();
Console.WriteLine($"Total de dependentes: {a1.CalcularTotalDependente()}");
