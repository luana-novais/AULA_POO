using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda
{
    public class Venda
    {
        private DateTime data;
        private double total;
        public Pagamento Pagamento { get; set; } 
        public List<ItemVenda> VetItens { get; set; }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Venda()
        {
            Data = DateTime.Now;
            VetItens = new List<ItemVenda>();
            Total = 0;
        }

        public void AdicionaItem(ItemVenda item)
        {
            VetItens.Add(item);
            Total += item.Subtotal;
            item.Produto.Estoque -= item.Quantidade;

        }
    }
}