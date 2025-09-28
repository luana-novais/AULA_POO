using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicao
{
    public class ContaCorrente
    {
        public double Saldo { get; private set; }
        public double ChequeEspecial { get; private set; }

        public ContaCorrente(double saldoInicial, double chequeEspecial)
        {
            Saldo = saldoInicial;
            ChequeEspecial = chequeEspecial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo + ChequeEspecial)
            {
                Saldo -= valor;
                return true;
            }
            Console.WriteLine("Saldo insuficiente!");
            return false;
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"[Conta Corrente] Saldo: R${Saldo:F2} | Cheque Especial: R${ChequeEspecial:F2}");
        }

        ~ContaCorrente()
        {
            Console.WriteLine("Conta Corrente encerrada.");
        }
    }
}