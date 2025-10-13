using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(double salario) : base(salario)
        {
        }
        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao() + 1000;
        }
    }
}