using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {   // array de integers

            int[] numeros = {1, 2, 4, 6, 5 };
            int[] numerosDos = {32, 65, 432, 4};
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[3]);
            
            // hace una iteracion por los elementos del array
            foreach (int item in numerosDos)
            {
             Console.WriteLine("item " + item);   
            }

            int[] arrayOfNumeros = {10, 35, 623, 312, 15 };
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
        }
    }
}
