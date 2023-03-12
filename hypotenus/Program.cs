System.Console.WriteLine("Enter side A: ");
double sideA = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter side B: ");
double sideB = Convert.ToDouble(Console.ReadLine());

double resultado = Math.Sqrt((sideA * sideA) + (sideB * sideB));

System.Console.WriteLine("The Hypotenuse is: " + resultado);

Console.ReadKey();
