using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicao
{
    public class Poupanca
    {
        public double Saldo { get; private set; }

        public Poupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            Console.WriteLine("Saldo insuficiente!");
            return false;
        }

        // Gerar rendimento de 0,5% ao mês
        public void GerarRendimento()
        {
            double rendimento = Saldo * 0.005;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento aplicado: R${rendimento:F2}");
        }
        public void MostrarSaldo()
        {
            Console.WriteLine($"[Poupança] Saldo: R${Saldo:F2}");
        }

        ~Poupanca()
        {
            Console.WriteLine("Poupança encerrada.");
        }
    }
}