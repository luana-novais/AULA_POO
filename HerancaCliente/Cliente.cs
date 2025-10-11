using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente //superclasse - base
    {
        protected int codigo;
        protected string? nome;

        public int Codigo //propriedade
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        
    }
}