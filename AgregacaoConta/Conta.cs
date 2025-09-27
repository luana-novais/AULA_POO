using System;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }
        public Conta();
  
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero +
            "\tTitular: " + Titular + "\tSaldo: " + Saldo);
        }
    }
}