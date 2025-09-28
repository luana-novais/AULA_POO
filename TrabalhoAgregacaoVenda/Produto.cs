using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        private static int contador = 500;
        private int codigo;
        private string? nome;
        private double preco;

        public string? Nome
        {
            get { return nome; }
            set
            {
                if (value != "")
                {
                    nome = value;
                }
            }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
            }
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public Produto(string? nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            codigo = contador++;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} | Nome: {nome} | Preço: R${preco:F2}");
        }
    }
}