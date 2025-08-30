using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo, estoque;
        public string? nome;
        public double preco, subtotal;
        public void CalcularAumento(double porcentagem)

        {
            preco += preco * porcentagem / 100;
        }

        public void RetirarEstoque(int qtd)

        {
            estoque -= qtd;                
        }

        public void CalcularSubtotal()

        {
            subtotal = estoque * preco;
        }

        public void MostrarAtributos()

        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tEstoque: " + estoque + "\tPreço: " + $"{preco:F2}" + "\tSubtotal: " + $"{subtotal:F2}");
        }
    }
}