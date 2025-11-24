using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda
{
    public abstract class Pagamento
    {
        protected DateTime Data { get; set; }
        protected double Total { get; set; }

        public Pagamento(double total)
        {
            Data = DateTime.Now;
            Total = total;
        }

        public abstract bool ProcessarPagamento();
    }
}