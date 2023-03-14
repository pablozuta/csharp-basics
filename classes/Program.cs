//this is for using the console methot directly
using System;

namespace classes
{
    class Program
    {
        // aca se crea la clase
        class Book
        {
            public string title;
            public string author;
            public int yearOfPublication;
        }

        // aca se crea otra clase
        class Person
        {
            public string name;
            public int age;
        }

        // ENUMS
        // An enum is a special value type that lets you specify a group of named numeric constants.
        enum EmpType
        {
            Manager,
            Grunt,
            Contractor,
            VicePresident
        }

        enum BorderSide {Left =10, Right, Top, Bottom}


        static void Main(string[] args)
        {
            // aca se crea un objeto de esa clase
            Book bookUno = new Book();
            // pupulate his attributes(fields)
            bookUno.title = "Necronomicon";
            bookUno.author = "H.P. Lovecraft";
            bookUno.yearOfPublication = 1921;

            // aca se muestra por consola
            const string bookTitle = "Title: ";
            const string bookAuthor = "Author: ";
            Console.WriteLine(bookTitle + bookUno.title);
            Console.WriteLine(bookAuthor + bookUno.author);
            Console.WriteLine("Year: " + bookUno.yearOfPublication);

            // se crea un objeto de la clase Person
            Person personUno = new Person();
            // populate hus atributes(fields)
            personUno.name = "Philip";
            personUno.age= 50;
            System.Console.WriteLine(personUno.name);
            System.Console.WriteLine(personUno.age);

            // Acceder a enums
            System.Console.WriteLine(BorderSide.Left); // devuelve "Left"
            System.Console.WriteLine((int)BorderSide.Left); // devuelve 10

            System.Console.WriteLine((int)EmpType.Manager); // devuelve 0
            System.Console.WriteLine(EmpType.Grunt); // devuelve "Grunt"



           
        }
    }
}
