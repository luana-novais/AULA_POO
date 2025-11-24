using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoInterface
{
    public class SeguroDeVida: Itributavel
    {
        public double CalculaTributos()
        {
            return 75.0; 
        }
    }
}