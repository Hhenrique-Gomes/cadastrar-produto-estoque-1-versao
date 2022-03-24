using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_sftwr_dados_produto_estoque
{
    class Caracteristicas
    {

        public string Nome;
        public int Quantidade;
        public double Preco;
        public string Linha;

        public double ValorTotalProduto()
        {

            return Preco * Quantidade;

        }

        public void AddProduto (int quantidade)
        {

            Quantidade += quantidade;

        }

        public void Rtrr( int rtrr)
        {

            Quantidade -= rtrr;

        }

        public override string ToString()
        {
            Console.WriteLine("{0}, R$ {1}, {2} unidades, Total: R$ {3} ", Nome, Preco.ToString("F2"), Quantidade, ValorTotalProduto());
            Linha = Console.ReadLine();

            return Linha;

            /*
            return Nome;  
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidadedes, Total: $ "
            + ValorTotalProduto().ToString("F2");
            */

        }

    }
}
