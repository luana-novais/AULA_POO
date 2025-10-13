using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(double salario) : base(salario)
        {
        }
        public override double CalcularBonificacao() //overide vai mudar a logica que foi definida na classe base
        {
            return Salario * 15 / 100;
        }
    }
}
