using ComposisaoNf;

ItemNotaFiscal it1 = new ItemNotaFiscal(12);
ItemNotaFiscal it2 = new ItemNotaFiscal(20);

NotaFiscal nf = new NotaFiscal(1, "22/09/2025");
nf.VetItens.Add(it1);
nf.VetItens.Add(it2);
Console.WriteLine("\nApresentação dos itens da nota fiscal\n");

foreach (var item in nf.VetItens)
    item.Mostrar();

//forçar a destruicao do objeto
nf = null; //aqui a variavel PERDE a referencia de memoria ficando disponivel para o coletor de lixo liberar a memoria. 

//chame o coletor de lixo 
GC.Collect();

