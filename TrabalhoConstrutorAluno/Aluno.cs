using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoConstrutorAluno
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public long Ra { get; set; }
        public static long Contador { get; set; }

        static Aluno()
        {
            Contador = 15704824130000;
        }
        public Aluno()
        {
            Contador++;
            Ra = Contador;
        }
        public Aluno(string? nome)
        {
            Contador++;
            Ra = Contador;
            Nome = nome;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"RA: {Ra} - Nome: {Nome}");
        }
    }
}