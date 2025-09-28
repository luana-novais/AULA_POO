using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
     public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProd;

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            comp = comprador;
            vend = vendedor;
            vetProd = new List<Produto>();
        }

        public void RealizarVenda(Produto produto)
        {
            if (comp.Verba >= produto.Preco)
            {
                comp.Verba -= produto.Preco;
                vend.CalcularComissao(produto.Preco);
                vetProd.Add(produto);
                Console.WriteLine($"Venda realizada: {produto.Nome} por {produto.Preco:C}");
            }
            else
            {
                Console.WriteLine($"Venda NÃO realizada: verba insuficiente para comprar {produto.Nome}!");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\n--- Detalhes da Venda ---");
            comp.MostrarAtributos();
            vend.MostrarAtributos();
            Console.WriteLine("Produtos comprados:");
            foreach (var p in vetProd)
            {
                p.MostrarAtributos();
            }
        }
    }
}