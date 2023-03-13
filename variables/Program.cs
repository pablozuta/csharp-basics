// VARIABLES

// Booleans
bool verdad = true;
bool mentira = false;
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
Console.WriteLine(numero + numeroDos);

// Floats
double floating = 102.45;
double floatingDos = 71022.345;
Console.WriteLine(floating + floatingDos);

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