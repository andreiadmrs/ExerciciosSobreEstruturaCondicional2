using System;

namespace ExerciciosSobreEstruturaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/
            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("Número par.");
            }
            else
            {
                Console.WriteLine("Número impar.");
            }
        }
    }
}
