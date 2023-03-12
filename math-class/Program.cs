double x = 3;

double a = Math.Pow(x, 2); // we raise x to the second power
System.Console.WriteLine("This is {0} to the second power: {1}", x, a);

double numeroCuadrado = Math.Sqrt(x); // square root
System.Console.WriteLine($"The square root of {x} is " + numeroCuadrado);

double xx = -30;
double valorAbsoluto = Math.Abs(xx); // nos entrega el valor absoluto del numero hasta cero
System.Console.WriteLine(valorAbsoluto);

double xxx = 3.35;
double rounded = Math.Round(xxx); // nos devuelve valor acercandolo al numero sin decimales mas cercano
double ceiling = Math.Ceiling(xxx); // lo ajusta hacia arriba
double floor = Math.Floor(xxx); // lo ajusta hacia abajo
System.Console.WriteLine(rounded);
System.Console.WriteLine(ceiling);
System.Console.WriteLine(floor);

double valorMaximo = Math.Max(xx, xxx);
System.Console.WriteLine("El valor maximo entre {0} y {1} es {2}", xx, xxx, valorMaximo);

double valorMinimo = Math.Min(xx, xxx);
System.Console.WriteLine("El valor minimo entre {0} y {1} es {2}", xx, xxx, valorMinimo);

Console.ReadKey();
