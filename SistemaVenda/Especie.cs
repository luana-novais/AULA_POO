using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco { get; set; }

        public Especie(double total, double quantia) : base(total)
        {
            Quantia = quantia;
            Troco = quantia - total;
        }

        public override bool ProcessarPagamento()
        {
            if (Quantia >= Total)
            {
                Console.WriteLine($"Pagamento em Espécie. Troco: R$ {Troco:F2}");
                return true;
            }
            else
            {
                Console.WriteLine($"Valor insuficiente. Faltam: R$ {Total - Quantia:F2}");
                return false;
            }
        }
    }
}