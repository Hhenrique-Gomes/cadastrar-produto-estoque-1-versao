using System;

namespace _42_sftwr_dados_produto_estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Caracteristicas j = new Caracteristicas();

            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Digite o nome do produto: ");
            j.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produto: ");
            j.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            j.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0}", j);

            Console.Write("Deseja adicionar mais produtos?");
            Console.WriteLine("Digite a quantidade a ser inserida ");
            int qtd = Convert.ToInt32(Console.ReadLine());
            j.AddProduto(qtd);

            Console.WriteLine("{0}", j);

            Console.Write("Deseja retirar algum produto?");
            Console.WriteLine("Digite a quantidade a ser retirada");
            qtd = Convert.ToInt32(Console.ReadLine());
            j.Rtrr(qtd);

            Console.WriteLine("{0}", j);
         
        }
    }
}
