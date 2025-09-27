using System;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string? nome;
        private double media;

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Media
        {
            get { return media; }
            set
            {
                if (value >= 0 && value <= 10)
                    media = value;
                else
                    Console.WriteLine("Média inválida! Deve estar entre 0 e 10.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Nome: " + Nome + " - Média: " + Media);
        }

        public bool EstaAprovado()
        {
            return media >= 6;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Status: " + (EstaAprovado() ? "Aprovado" : "Reprovado"));
        }
    }
}
