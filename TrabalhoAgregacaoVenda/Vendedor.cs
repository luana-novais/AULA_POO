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

        

        public void MostrarAtributo()
        {
            Console.WriteLine($"Nome: {Nome} \tComissao{Comissao}");
        }
    }
}