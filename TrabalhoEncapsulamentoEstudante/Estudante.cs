using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        public string? Nome { get; set; }
        private double media;
        public double Media
        {
            get { return media; }
            set
            {
                if (value >= 0 && media <= 10)
                    media = value;
                else
                    Console.WriteLine("Média invalidade!");
            }

        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Nome: " + Nome + "Média: " + Media);
        }

        public bool EstaAprovado()
        {
            if (media >= 6) return true;
            else return false;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Status: " + EstaAprovado());
        }
    }
}