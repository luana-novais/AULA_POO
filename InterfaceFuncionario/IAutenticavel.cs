using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public interface IAutenticavel
    {
        bool Autenticar(int senha);
    }
}