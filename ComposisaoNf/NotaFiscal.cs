using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposisaoNf
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }
        public NotaFiscal(int nf, string data)
        {//inicializa a instancialização 
         //no momento da instancia do objeto-todo NotaFiscal, a instancia da relação/associacao DEVE ser realizada/estabelecida

            VetItens = new List<ItemNotaFiscal>();
            NumeroNf = nf;
            Data = data;
        }
        ~NotaFiscal()//o destrutor retirara a referencia de memoria do objeto instanciado
        {//implemente o fechamento dos recursos em aberto aqui!
            VetItens = null; //o null retira a referencia de memoria
            Console.WriteLine("Destruindo a nota fiscal");
        }
    }
}