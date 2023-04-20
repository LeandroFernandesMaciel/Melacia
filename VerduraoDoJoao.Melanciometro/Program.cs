
using static System.Net.Mime.MediaTypeNames;

/*CONTEXTUALIZAÇÃO: George Boole criou a lógica que usou seu nome, lógica booleana e
sendo discípulo do Aristóteles fez história dentro do mundo computacional. Veja que
interessante, um discípulo de um dos maiores filósofos da história contribuiu para nossa
situação de aprendizagem. A lógica de programação é a base de toda o desenvolvimento
de software. É com ela que podemos organizar o nosso pensamento e propor algoritmos
computacionais.


Nesse contexto encontramos a empresa familiar “João do Verdurão”.
Essa empresa possui uma pequena frota de caminhão e precisa de um sistema console
básico, mas que tenha as funcionalidades principais que possam atender o negócio.

DESAFIO:
João solicita um “Melanciometro” , software este, que irá ajuda-lo no controle de
dois tipos de Melancias (Comum e Baby).
RESULTADOS ESPERADOS:
• O software deve permitir a entrada da placa do caminhão

• O software deve considerar dois valores fixos: melancia comum R$ 5.50 e melancia
baby 8.54 o quilo

• O software deve possuir um looping (do while) que possa interagir com o usuário do
sistema, esse looping irá mostrar o menu e as entradas de dados, deixando-o
controlado por sentinela ( o usuário que vai determinar o fim)

• O software deve considerar o looping e calcular o valor total de melancia comum e o
valor total de melancia baby que foi carregada no caminhão em questão

• O software deve também considerar e mostrar o total geral das duas melancias

• Na entrada de dados o usuário vai entrar com um número inteiro. Você deverá
utilizar um switch para mostrar uma mensagem personalizada para cada dia da
semana. O dia 1 é segunda-feira o dia 5 é sexta-feira.
Os dias de promoção é na terça  e quarta, chamada de terça e quarta verde, então, 
você deve dar um desconto na terça de 15% e na quarta de 17%, as mensagens devem 
ser personalizadas (“terçaverde”, “quarta verde”). Os outros dias, respectivamente,
devem dar os seguintes descontos: Segunda - Feira(1 %) , Quinta - Feira(2 %) , Sexta
- Feira(3 %) e não possuem mensagem de promoções.
• Por último, ele solicitou também, um controle de usuário, considerando que a senha
é 123 e o usuário é “joão”. Sabendo desses valores estáticos, crie um sistema de
login que verifique se o usuário e a senha possuem os dados corretos para
autenticação.
• Muito importante, saber também, que ele pediu para bloquear e abandonar o looping
se o usuário errar três vezes. Então, aplique os conhecimentos de if, if else, while,
break, continue entre outros aplicando-os nesse desafio, considere que ele pode
acertar a senha e o usuário na 1ª , 2ª ou 3ª tentativa.*/







using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;



namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
            
        {

            Console.WriteLine(" Bom dia ! Para iniciar a compra informe a placa do seu caminhão");
            int placa = int.Parse(Console.ReadLine());

             Console.WriteLine("Para aproveitar nossas promoções informe o dia da semana. 1 - domingo.\n 2 - segunda-feira.\n 3 - terça-feira.\n 4 - quarta.\n 5 - quinta.\n 6 - sexta");
            int diaSemana = int.Parse(Console.ReadLine());


            int novoPedido;
           
            double preco;
          
            //double

            do
            {

                Console.WriteLine("Bom dia ! Informe que tipo de melancia quer levar hoje. Digite 1 para Melancia COMUM e 2 para Melancia BABY");
                int melancia = int.Parse(Console.ReadLine());
                Console.ReadKey();//serve para o programa não fechar 

                if (melancia == 1)
                {
                    preco = 5.50;
                    Console.WriteLine(" Você selecionou Melancia Comum que está saindo  por " + preco.ToString());

                }
                else if (melancia == 2)
                {
                    preco = 8.54;
                    Console.WriteLine("Você selecionou Melancia Baby que está saindo por  " + preco.ToString());
                }
                else
                {
                    Console.WriteLine("Não existe essa opção! Digite 1-Melancia Comum 2-Melancia Baby ");
                   
                }
                Console.WriteLine("Gostaria de fazer um novo pedido ? 1 para sim  2 para não ");
                novoPedido = int.Parse(Console.ReadLine());



            } while (novoPedido == 1);



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

