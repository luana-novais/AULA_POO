using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;

        public int Numero //numero em minusculo é atributo. numero em maiusculo é a propriedade, é a representação dos métodos de encapsulamento. 
        {
            set
            {
                if (value > 0)
                    numero = value;
                else
                    Console.WriteLine("Número de conta inválido!");
            }
            get { return numero; }
        }

        public string? Titular
        {
            set { titular = value; }
            get { return titular; }
        }

        //No caso do saldo, não precisa encapsular pois tem o sacar e o depositar, não precisando mexer no saldo diretamente!
        /*public double Saldo
        {
            set { saldo = value; }
            get { return saldo; }
        }*/
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