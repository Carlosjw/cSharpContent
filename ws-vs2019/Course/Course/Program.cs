using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte x = 100; Tipo sbyte

            // Console.WriteLine(x);

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // recomendado o uso do L após o valor em valores do tipo long
            bool complet = false;
            char genero = 'F'; // tipo char deve ser colocado entre aspas simples.
            char letra = '\u0041'; // letra A em código UNICODE
            float n5 = 4.5f; // precisa colocar o f após o valor para indicar que é tipo float
            double n6 = 4.5; // Não há necessidade de colocar letra no tipo double.
            string nome = "Maria Green"; // As duplas para tipo string
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(complet);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            
            // pressionar cw e a tecla tab 2x para escrever o Console.WriteLine
        }
    }
}
