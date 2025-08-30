using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListFuncionario //pasta
{
    public class Funcionario
    {
        public int codigo;

        public string nome;

        public double salario;

        public void CalcularSalario()
        {
            salario = salario + salario * 0.05;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tSalario: {salario:c}");
        }
    }
}