using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;

        private string? nome;

        private double salario;

        public int Codigo
        {
            get { return codigo; }
            set{ codigo = value; }
        }

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set{ salario = value; }
        }

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