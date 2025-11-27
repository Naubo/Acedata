using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int anterior = 0;
            int atual = 1;
            int proximo = 1;
            bool pertence = false;
            int contador = 0;


            // Tratativa caso entrada1 seja não numérica ou não inteira
            do
            {
                //Insere numero N
                Console.Write("Insira um numero inteiro: ");
                string entrada1 = (Console.ReadLine());

                // Converte string para int e valida se é maior que zero
                if (int.TryParse(entrada1, out n) && n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro maior que zero.");
                }

            } while (true);

            Console.Clear();
            Console.WriteLine( n + " primeiros numeros da sequencia de Fibonacci:");
            Console.WriteLine("--------------------");

            // Calcula sequencia de Fibonacci e imprime os N primeiros numeros
            for (int i = 1; i<= n; i++)
            {
                Console.Write(atual + " "); // imprime atual
                anterior = atual; // anterior recebe atual
                atual = proximo; // atual recebe proximo
                proximo = anterior + atual; // proximo recebe anterior + atual
                
                if (atual == n) 
                {
                    pertence = true;
                    contador = i+1;
                }
            }

            // Caso pertence = true, faz parte da sequencia.
            if (pertence)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("O numero " + n + " pertence a sequencia de Fibonacci.");
                Console.WriteLine("Ele é o " + contador + "° numero da sequencia.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("O numero " + n + " nao pertence a sequencia de Fibonacci.");
            }

            // Finalização do programa 
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
