using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//              classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Rg: {Rg}");
        }   
    }
}