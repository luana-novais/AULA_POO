using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        private string? nome;
        private double preco;
        private int codigo;
        private static int contador;

        static Produto()
        {
            Contador = 500;
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Codigo
        {
            get { return codigo; }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} | Nome: {nome} | Preço: R${preco}");
        }
    }
}