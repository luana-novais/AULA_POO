using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorConta //namespace é uma pasta
{
    public class Conta 
    {
        //declaração dos atributos
        public int numero;
        public string? titular;
        public double saldo;
        //declaração dos métodos
        public void Sacar(double ValorSaque)
        {
            saldo = saldo - ValorSaque;
        }
        public void Depositar(double ValorDeposito)
        {
            saldo += ValorDeposito;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\tNúmero: " + numero + "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
    }
}