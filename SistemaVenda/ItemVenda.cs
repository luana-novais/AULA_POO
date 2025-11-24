using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Subtotal { get; set; }
        public Produto Produto { get; set; }
        public ItemVenda(Produto p, int qtd)
        {
            Produto = p;
            Quantidade = qtd;

            double soma = qtd * p.Preco;

            if (qtd >= 50)
            {
                soma *= 0.8;
                Console.WriteLine($"Desconto de 20% (Atacado) aplicado para {p.Nome}.");
            }

            Subtotal = soma;
        }
    }
}