using EncapsulamentoProduto;

Produto p = new Produto();
p.Codigo = 1;
p.Nome = "mouse";
p.Preco = 50;

if (p.Preco > 10)
    Console.WriteLine("Preço alto " + p.Preco);