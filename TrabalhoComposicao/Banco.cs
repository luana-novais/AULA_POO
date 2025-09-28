using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicao
{
    public class Banco
    {
        private List<Poupanca> poups;
        private List<ContaCorrente> contas;

        public List<ContaCorrente> Contas
        {
            get { return contas; }
        }

        public List<Poupanca> Poupanca
        {
            get { return poups; }
        }


        public Banco()
        {
            poups = new List<Poupanca>();
            contas = new List<ContaCorrente>();
        }

        public void IniciarBanco()
        {
            poups.Clear();
            contas.Clear();
        }

        public void AbrirConta(double saldoInicial, double chequeEspecial)
        {
            contas.Add(new ContaCorrente(saldoInicial, chequeEspecial));
            Console.WriteLine("Conta Corrente criada!");
        }

        public void AbrirPoupanca(double saldoInicial)
        {
            poups.Add(new Poupanca(saldoInicial));
            Console.WriteLine("Poupança criada!");
        }

        public void MostrarContas()
        {
            Console.WriteLine("Contas Correntes:");
            foreach (var c in contas)
                c.GerarExtrato();
        }

        public void MostrarPoupancas()
        {
            Console.WriteLine("Poupanças:");
            foreach (var p in poups)
                p.MostrarSaldo();
        }
        public void DecretarFalencia()
        {
            contas.Clear();
            poups.Clear();
            Console.WriteLine("Banco decretou falência. As contas foram encerradas.");
        }

        ~Banco()
        {
            Console.WriteLine("Banco encerrado.");
        }
    }
}
