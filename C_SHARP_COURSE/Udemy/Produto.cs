using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
             double valor = Preco * Quantidade;
            return valor;
        }

        public void AdicionarProdutos(int quant)
        {
            Quantidade = Quantidade+quant;
        }
        public void RemoverProdutos(int quant)
        {
            Quantidade = Quantidade - quant;
        }
    }
}
