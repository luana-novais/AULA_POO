using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public class Cliente : IAutenticavel
    {// o caracter : neste caso representa
    // a IMPLEMENTAÇÃO da interface
        public int Senha { get; set; }
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Cliente tem acesso");
                return true;
            }
            else
            {
                Console.WriteLine("Cliente NÃO tem acesso");
                return false;
            }
        }
    }
}