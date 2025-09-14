using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos 
        //declaração da propriedade
        //de encapsulamento get e set
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }

        public static int Contador { get; set; }

        //declaração do construtor - atalho ctr
        //construtor tem a função de inicializar os atributos
        public Funcionario()
        {
            Contador += 1;
        }

        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Contador += 1;
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Contador += 1;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome} \tSalario: {Salario:c}");
        }
    }
}