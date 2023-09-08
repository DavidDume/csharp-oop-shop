// See https://aka.ms/new-console-template for more information


using csharp_oop_shop;

internal class Program
{
    private static void Main(string[] args)
    {
        Prodotto item = new Prodotto("Libro", "Lorem Ipsum", 9.99f);


        Console.WriteLine(item.GetFull());
        Console.WriteLine(item.GetPriceVAT());

        Console.WriteLine(item.GetCodeWithPad(12344556));
    }
}