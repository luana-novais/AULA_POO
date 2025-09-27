using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        public string? Nome { get; set; }
        public double Comissao { get; set; }

        public void CalcularComissao(double valorVenda)
        {
            comissao += valorVenda * 0.02;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {Nome} \tComissao{Comissao}");
        }
    }
}