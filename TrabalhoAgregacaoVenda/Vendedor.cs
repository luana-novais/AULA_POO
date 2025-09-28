using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;

        public double Comissao
        {
            get { return comissao; }
            set
            {
                if (value >= 0)
                    comissao = value;
            }
        }

        public Vendedor()
        {
            comissao = 0;
        }

        public void CalcularComissao(double valorVenda)
        {
            comissao += valorVenda * 0.02;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão: R${comissao:F2}");
        }
    }
}