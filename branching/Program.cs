﻿int numero = 100;

// IF STATEMENT
if (numero > 100)
{
    Console.WriteLine("Numero Mayor a 100");
}
else if (numero == 100)
{
    Console.WriteLine("El numero es 100");
}
else
{
    Console.WriteLine("Numero menor a 100");
}

// TERNARY
Console.WriteLine((numero > 99) ? "Numero mayor a 99" : "Numero menor a 99");

// SWITCH STATEMENT
String dia = "Domingo";

switch (dia)
{
    case "Lunes":
        Console.WriteLine("El dia es Lunes");
        break;
    case "Domingo":
        Console.WriteLine("El dia es Domingo");
        break;
   
}