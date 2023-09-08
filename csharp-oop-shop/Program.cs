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


        Prodotto[] arr = new Prodotto[5];

        for(int i  = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Inserisci Il nome del prodotto");
            string name = Console.ReadLine();
            Console.WriteLine("Inserisci la descrizione del prodotto");
            string descrizione = Console.ReadLine();
            Console.WriteLine("Inserisci Il prezzo del prodotto");
            float prezzo = float.Parse(Console.ReadLine());
            arr[i] = new Prodotto(name, descrizione, prezzo);

            
        }

        for(int i = 0;i < arr.Length;i++)
        {
            Console.WriteLine($"Prodotto numero {i+1}: ");
            arr[i].GetInfo();
        }
    }
}