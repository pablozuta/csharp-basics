// FOR LOOP
for (int i = 10; i > 0; i--) {
    Console.WriteLine(i);
}

for(int i = 0; i <=10; i++){
    System.Console.WriteLine("El numero es: "+ i);
}

// FOR LOOP MOSTRANDO ARRAY
String[] textos = {"Talpa", "La cuesta de las comadres", "Nos han dado la tierra"};

for(int i = 0; i < textos.Length; i++){
    System.Console.WriteLine(textos[i]);
}

// WHILE LOOP
String name = "";

while (name == "")
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
}

System.Console.WriteLine($"Hello, {name}");