Random random = new Random();

int num1 = random.Next(1, 7);
int num2 = random.Next(1, 7);
long num3 = random.NextInt64();

// double num random
double num1Double = random.NextDouble();
double num2Double = random.NextDouble();
double num3Double = random.NextDouble();

System.Console.WriteLine("Integer entre 1-7: "+ num1);
System.Console.WriteLine("Integer entre 1-7: "+ num2);
System.Console.WriteLine("Long Number NextInt64: " + num3);
System.Console.WriteLine(num1Double);
System.Console.WriteLine(num2Double);
System.Console.WriteLine(num3Double);

Console.ReadKey();