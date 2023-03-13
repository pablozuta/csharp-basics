using System;
// In C#, you can use string and String interchangeably, int and Int32
// interchangeably, bool and Boolean and double Double
// VARIABLES

// Booleans
bool verdad = true;
Boolean mentira = false;
Console.WriteLine(verdad);
Console.WriteLine(mentira);

// Strings
string coltrane = "Vilia(audio)";
string coltraneDos = "Naima";
string coltraneAlbum = "Two Directions At Once";
Console.WriteLine(coltrane + " - " + coltraneDos);


// Integers
int numero = 100;
int numeroDos = 200;
Int32 numeroTres = 400;
Console.WriteLine(numero + numeroDos);
Console.WriteLine(numeroTres);
Console.WriteLine(numeroTres.ToString().Length);

// Floats
double floating = 102.45;
double floatingDos = 71022.345;
Double floatingTres = 132.41;
Console.WriteLine(floating + floatingDos + floatingTres);

// Decimals
decimal numeroDecimal = 143213.3413M;
decimal numeroDecimalDos = 127636153123.321647124M;
System.Console.WriteLine("Numero Decimal: " +numeroDecimal);
System.Console.WriteLine("Numero Decimal Dos: " +numeroDecimalDos);

// the C# language does provide for implicitly typing of local variables using the
// var keyword. The var keyword can be used in place of specifying a specific data type 
// (such as int, bool, or string). 
// When you do so, the compiler will automatically infer the underlying data type
// based on the initial value.
var myVar1 = 900;
var myVar2 = false;
var myVar3 = "Readings in Art History";
Console.WriteLine(myVar1);
Console.WriteLine(myVar2);
Console.WriteLine(myVar3);


// Composite Formatting
Console.WriteLine("The Album from John Coltrane {0} has the song {1}", coltraneAlbum, coltraneDos);

// String Interpolation
Console.WriteLine($"The Album from John Coltrane {coltraneAlbum} has the song {coltraneDos}");

// String Concatenation
Console.WriteLine("The Album from John Coltrane "+ coltraneAlbum + " has the song " + coltrane);

// CONSTANTS
const int MaxValue = 100;
const float Pi = 3.1415927f;
const double SpeedOfLight = 299792458.0;
const string AppName = "My Application";
Console.WriteLine("The MaxValue is {0}, this is the value of PI {1} and this the speed of light {2}, the name of my app is {3} ", MaxValue, Pi, SpeedOfLight, AppName);

// String Methods
System.Console.WriteLine(coltrane.ToUpper());
System.Console.WriteLine(coltrane.ToLower());
System.Console.WriteLine(coltrane.Replace("V", "B"));
System.Console.WriteLine(coltrane.Replace("V", "B"));
System.Console.WriteLine(coltrane.Insert(0, "Track Name: "));
System.Console.WriteLine(coltrane.Length);
System.Console.WriteLine(coltrane.Substring(0, 4));

// size of types
Console.WriteLine("Byte: " + sizeof(byte));
Console.WriteLine("Sbyte: " + sizeof(sbyte));
Console.WriteLine("Int: " + sizeof(int));