/* 14. Avancerat: Rullande logg
Skapa ett system för en rullande logg med en fast array på 5 element. När ett nytt loggmeddelande
läggs till och arrayen redan är full, ska det äldsta meddelandet (på index 0) kastas bort, alla andra
meddelanden flyttas ett steg till vänster (index 1 blir index 0 osv.), och det nya meddelandet läggas
till på den nu lediga sista platsen (index 4). Skriv en metod för att hantera denna insättning. */

string[] logg = new string[5];
int index = 0;

while (true)
{
    Console.Clear();
    VisaLogg();
    Console.WriteLine("Lägg till rad i loggen:");
    Console.Write("> ");
    LäggTillNyRad(Console.ReadLine());
}

void LäggTillNyRad(string nyRad)
{
    if (index >= logg.Length)
    {
        RullaLogg();
        index -= 1;
    }

    logg[index] = nyRad;

    index++;

}

void RullaLogg()
{
    string[] nyLogg = new string[logg.Length];
    Array.ConstrainedCopy(logg, 1, nyLogg, 0, logg.Length-1);
    logg = nyLogg;
}

void VisaLogg()
{
    Console.WriteLine("-----");
    foreach (var rad in logg)
    {
        Console.WriteLine(rad);
    }
    Console.WriteLine("-----");
}