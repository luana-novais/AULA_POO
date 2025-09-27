using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        public string Nome { get; set; }

        public void MostrarAtributo()
        {
            Console.WriteLine($"Nome: {Nome} \tVerba: {verba}");
        }
    }
}