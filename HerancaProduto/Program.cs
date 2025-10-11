using HerancaProduto;

Produto p = new Produto();
p.Codigo = 1;
p.Nome = "Caneta";
p.Preco = 2.5;

p.Mostrar();

Perecivel pe = new Perecivel();
pe.Codigo = 2;
pe.Nome = "Café";
pe.Preco = 38;
pe.DtValidade = "10/11/2025";
pe.DtFabricacao = "20/03/2025";
pe.Lote = 12234;

pe.Mostrar();