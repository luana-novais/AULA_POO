using TrabalhoAgregacaoVenda;
class Program
{
    static void Main()
    {
        Vendedor vend = new Vendedor();
        Comprador comp = new Comprador(500);

        Produto p1 = new Produto("Camiseta", 50);
        Produto p2 = new Produto("Calça", 200);
        Produto p3 = new Produto("Vestido", 300);

        Venda venda = new Venda(comp, vend);
        venda.RealizarVenda(p1);
        venda.RealizarVenda(p2);
        venda.RealizarVenda(p3);

        venda.MostrarAtributos();
    }
}
