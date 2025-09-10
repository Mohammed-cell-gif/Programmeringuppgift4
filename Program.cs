// See https://aka.ms/new-console-template for more information
Console.WriteLine("Gisa nummer som dator väljd,de är mellan 1 och 100");
Random rnd = new Random();
int randomNumber = rnd.Next(1, 100);
int antalgis = 0;
int Gisa = int.Parse(Console.ReadLine());

while (Gisa != randomNumber)
{
    if (Gisa < randomNumber)
    {
        Console.WriteLine("Gissningen är för låg");
    }
    else if (Gisa > randomNumber)
    {
        Console.WriteLine("Gissningen är för hög");
    }
    antalgis++;
    Console.WriteLine("Antal gissningar: " + antalgis);
    Gisa = int.Parse(Console.ReadLine());
}
Console.WriteLine("Helt rätt");
Console.WriteLine("Din total antal gissningar är " + antalgis);