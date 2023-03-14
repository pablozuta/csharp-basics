class Program {
    static void Main(string[] args)
    {
    int age = 30;
    string name = "dave";
        singHapyBirthday();
        singHapyBirthdayDos(name, age);


        Console.ReadKey();
    }

    static void singHapyBirthday()
    {
        System.Console.WriteLine("Happy Birthday to you");
        System.Console.WriteLine("Happy Birthday to you");
    }

    static void singHapyBirthdayDos(string name, int age)
    {
        System.Console.WriteLine("Happy Birthday to you");
        System.Console.WriteLine("Happy Birthday to you");
        System.Console.WriteLine("Happy Birthday {0}" , name);
        System.Console.WriteLine("You are {0} years old" , age);
        System.Console.WriteLine("Happy Birthday to you");

    }
}