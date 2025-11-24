using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }
        public Cheque(double total, long numero, DateTime dataDeposito) : base(total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = 0;
        }

        public override bool ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com cheque nº {Numero} registrado.");
            Console.WriteLine($"Data depósito: {DataDeposito}");
    
            if (Situacao == 0) Console.WriteLine("Situação: aguardando compensação.");
            else if (Situacao == 1) Console.WriteLine("Situação: compensado.");
            else if (Situacao == 2) Console.WriteLine("Situação: devolvido.");

            return true;
        }
    }
}