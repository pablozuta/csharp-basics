using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        { // array de integers
            int[] numeros = { 1, 2, 4, 6, 5 };
            int[] numerosDos = { 32, 65, 432, 4 };
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[3]);

            // hace una iteracion por los elementos del array
            foreach (int item in numerosDos)
            {
                Console.WriteLine("item " + item);
            }

            int[] arrayOfNumeros = { 10, 35, 623, 312, 15 };
            Console.WriteLine(arrayOfNumeros[0]);
            Console.WriteLine(arrayOfNumeros[3]);
            Console.WriteLine(arrayOfNumeros[2]);

            // array de strings
            string[] arrayDeStrings = { "Glen Runciter", "Hallucinatory Logic" };
            Console.WriteLine(arrayDeStrings[0]);
            Console.WriteLine(arrayDeStrings[1]);

            // array declaration
            int[] firstArray;

            // allocate memory
            firstArray = new int[10];
            Console.WriteLine(firstArray);

            // LIST
            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");
            food.Insert(1, "sushi"); // inserta un item en el index indicado

            Console.WriteLine(food[0]);
            Console.WriteLine(food[1]);
            Console.WriteLine("La cuenta de la lista es: " + food.Count);
            food.Remove("fries"); // remueve el item indicado

            // for each en list
            foreach (string item in food)
            {
                Console.WriteLine("List Item: " + item);
            }
        }
    }
}
