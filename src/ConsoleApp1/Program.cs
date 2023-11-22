// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

namespace ConsoleApp1;

public static partial class Program
{
    public static void Main()
    {
        var clas = new RetornaUmClass();
        Console.WriteLine("Hello, World!" + clas.RetornaUm());
    }
}
