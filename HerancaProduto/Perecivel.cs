using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        protected string? dtValidade;
        protected string? dtFabricacao;
        protected int lote;

        public string? DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }

        public string? DtFabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }
        
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        
        public void Mostrar()
        {
            Console.WriteLine($"Código: {codigo} \tProduto: {nome} \tPreço: {preco} \tData de válidade: {DtValidade} \tData de fabricação: {DtFabricacao}");
        }      
    }
}