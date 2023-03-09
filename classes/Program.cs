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
        static void Main(string[] args)
        {

            // aca se crea un objeto de esa clase
            Book bookUno = new Book ();
            // pupulate his attributes(fields)
            bookUno.title = "Necronomicon";
            bookUno.author = "H.P. Lovecraft";
            bookUno.yearOfPublication = 1921;



            // aca se muestra por consola
            const string bookTitle = "Title: ";
            const string bookAuthor = "Author: ";
        Console.WriteLine(bookTitle + bookUno.title);
        Console.WriteLine(bookAuthor + bookUno.author);
        Console.WriteLine("Year: "+ bookUno.yearOfPublication);

        }
    }
}
