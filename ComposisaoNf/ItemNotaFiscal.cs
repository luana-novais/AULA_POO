using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposisaoNf
{
    public class ItemNotaFiscal
    {
        public int QtdeProduto { get; set; }
        public ItemNotaFiscal(int qtdeProduto)
        {
            QtdeProduto = qtdeProduto;
        }
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destruindo o item nota fiscal");
        }
        public void Mostrar()
        {
            Console.WriteLine("Quantidade de produto: " + QtdeProduto);
        }
    }
}