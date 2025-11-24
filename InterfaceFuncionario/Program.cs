using InterfaceFuncionario;

//IAutenticavel ia = new IAutenticavel();

Cliente c = new Cliente();
c.Senha = 100;

IAutenticavel ia = c;

ia.Autenticar(101);

Gerente g = new Gerente();
g.Senha = 200;

ia = g;
Console.WriteLine(ia.Autenticar(200));

Diretor d = new Diretor();
d.Senha = 300;

ia = d;
Console.WriteLine(ia.Autenticar(301));
