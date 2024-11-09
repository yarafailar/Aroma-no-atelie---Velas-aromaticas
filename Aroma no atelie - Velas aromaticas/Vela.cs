using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma_no_atelie___Velas_aromaticas
{
    internal class Vela
    {
        public int CodVela { get; set; }
        public string NomeVela { get; set; }
        public string TamanhoVela { get; set; }
        public string DescricaoVela { get; set; }
        public decimal PrecoVela { get; set; }

        public Vela(int codvela, string nome, string tamanho, string descricao, decimal preco): this(nome, tamanho, descricao,preco)
        {
           CodVela = codvela;

        }
        public Vela(string nome, string tamanho, string descricao, decimal preco)
        {
            NomeVela = nome;
            TamanhoVela = tamanho;
            DescricaoVela = descricao;
            PrecoVela = preco;
        }
    }
}
