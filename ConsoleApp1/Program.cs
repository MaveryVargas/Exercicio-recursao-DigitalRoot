using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(DigitalRoot(942));

        }
        public static double DigitalRoot(int n) //metodo recursivo, tem que um return
        {

            int soma = 0;
            while (n != 0) //primeiro laço: em quanto n for diferente de zero
            {
                while (n != 0)  // em quanto o n for diferente de zero soma vai receber e somar o resto de n
                {
                    soma += n % 10;
                    n = n / 10; //resultado da divisao por 10. 
                }
                if (n > 9) // se o n > 9, n vai receber soma e soma vai receber zero, ate que n seja menor que 9
                {
                    n = soma; //n recebe soma
                    soma = 0; // soma recebe zero e recomeça o processo ate que n = 0
                }
            }


           return soma; //retorna soma
        }
    }
}


