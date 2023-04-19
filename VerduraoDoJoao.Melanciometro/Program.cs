using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Melancia Comum 2-Melancia Baby");
            int melancia = int.Parse(Console.ReadLine());
            double preco;
            string resp;
            double

            do
            {
                if (melancia == 1)
                {
                    preco = 5.50;
                    Console.WriteLine("Melancia Comum: " + preco.ToString());

                }
                else if (melancia == 2)
                {
                    preco = 8.56;
                    Console.WriteLine("Melancia Baby " + preco.ToString());
                }
                else
                {
                    Console.WriteLine("Não existe essa opção!");
                    melancia = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("1-Melancia Comum 2-Melancia Baby");
                melancia = int.Parse(Console.ReadLine());



            } while (melancia != 0);



            ////int cont = 1;
            ////while (cont < 10)
            ////{
            ////    Console.WriteLine("Você entendeu?");
            ////    if (cont == 3)
            ////        break;
            ////    cont = cont + 1;
            ////}



        }
    }




        }

