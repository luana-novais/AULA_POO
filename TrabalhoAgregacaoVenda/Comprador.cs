using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            get { return verba; }
            set
            {
                if (value >= 0)
                {
                    verba = value;
                }
            } 
        }
        
        public Comprador (double verba)
        {
            Verba = verba;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Verba após a compra: R${verba:F2}");
        }
    }
}