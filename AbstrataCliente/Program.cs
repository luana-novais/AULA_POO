using AbstrataCliente;

ClienteFisico cf = new ClienteFisico(1, "Ana", 18, 100);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(2, "Empresa", 46, 222);
cj.Mostrar();

Teste t = new Teste();
t.AvaliarIdadeCliente(cf);
t.AvaliarIdadeCliente(cj);