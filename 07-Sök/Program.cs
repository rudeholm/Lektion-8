/* 7. Sök i vektorn
Skapa en array fylld med 6 olika städer (strängar). Låt användaren mata in namnet på en stad.
Programmet ska söka igenom arrayen och svara om staden finns med på listan eller inte, samt på
vilket index den hittades. */

string[] städer = [
    "Gävle",
    "Stockholm",
    "Uppsala",
    "Storvreta",
    "Sandviken",
    "Göteborg",
    ];

Console.Write("Sök stad: ");
string? sök = Console.ReadLine();
bool hittad = false;

for (int i = 0; i < städer.Length; i++)
{
    if (sök.ToLower().Equals(städer[i].ToLower()))
    {
        Console.WriteLine($"{städer[i]} hittades med index = {i}!");
        hittad = true;
        break;
    }
}

if (hittad == false)
    Console.WriteLine("Staden hittades inte.");