using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Incira o nome do produto:");
            string produto = Console.ReadLine();
            Console.WriteLine("Incira a quantidade de produtos:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço");


            double preco = double
                .Parse(Console.ReadLine());

            double precoFinal = preco * quantidade;
            double desconto1 = precoFinal * 0.9;
            double desconto2 = precoFinal * 0.8;
            double desconto3 = precoFinal *  0.75;


            if (quantidade <= 10)
            {
                Console.WriteLine($"Você escolheu {produto} {quantidade} e o valor total é de {precoFinal}");
            }
            else if (quantidade <= 20)
            {
                Console.WriteLine($"Você escolheu {quantidade}  com 10%de desconto, com o valor final de {desconto1}");

            }

            else if (quantidade <= 50)
            {

                Console.WriteLine($" Você comprou {quantidade} com 20% de desconto, que deu {desconto2}");
            }
            else if(quantidade>=50)
            {
                Console.WriteLine($"Você comprou {quantidade}produtos, com 25%de desconto com o preço final de {desconto3}");

            }

            }
        }
    }
