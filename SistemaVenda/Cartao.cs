using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; } 

        public Cartao(double total, string dados) : base(total)
        {
            DadosTransacao = dados;
            ResultadoTransacao = 0;
        }

        public override bool ProcessarPagamento()
        {
            Console.WriteLine("Pagamento em cartão processado.");
            Console.WriteLine($"Código transação: {DadosTransacao}");

            if (ResultadoTransacao == 0)
            {
                Console.WriteLine("Status: Aprovado.");
                return true;
            }
            else
            {
                Console.WriteLine("Status: Negado.");
                return false;
            }
        }
    }
}