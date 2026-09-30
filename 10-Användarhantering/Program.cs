/* 10. Användarhantering (Ta bort)
Skapa en List<string> med 5 användarnamn. Låt användaren skriva in ett namn som ska tas bort
från listan. Använd metoden .Remove() för att ta bort namnet om det finns. Skriv ut ett meddelande
om borttagningen lyckades eller om namnet inte existerade, och visa den uppdaterade listan. */

List<string> användarnamn = [
    "Foo",
    "Bar",
    "Baz",
    "Boo",
    "Goo",
    ];

foreach (var anv in användarnamn)
{
    Console.WriteLine($"{anv}");
}

Console.Write("Ange ett användarnamn som ska tas bort: ");
var namn = Console.ReadLine();

if (användarnamn.Remove(namn))
    Console.WriteLine("Användarnamnet togs bort.");
else
    Console.WriteLine("Användarnamnet hittades inte i listan och kunde därför inte tas bort.");

foreach (var anv in användarnamn)
{
    Console.WriteLine($"{anv}");
}
