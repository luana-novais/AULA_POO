using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produto> VetProduto { get; set; }

        public Venda(Comprador comp, Vendedor vend, List<Produto> produtos)
        {
            Comp = comp;
            Vend = vend;
            VetProduto = produtos;
        }

        public void RealizarVenda()
        {
            foreach (var produto in VetProduto)
            {
                Comp.ComprarProduto(produto, Vend);
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\nResumo da Venda:");
            Comp.MostrarAtributo();
            Console.WriteLine($"Comissão do vendedor: R$ {Vend.Comissao:F2}");
        }
    }
}