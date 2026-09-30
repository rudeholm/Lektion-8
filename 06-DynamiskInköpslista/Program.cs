/* 6. Dynamisk inköpslista
Skapa en tom List<string>. Bygg en loop som låter användaren skriva in saker till en inköpslista en
efter en via Console.ReadLine(). När användaren skriver 'klar' ska loopen avslutas och hela listan
skrivas ut i konsolen. */

List<string> inköpslista = [];
string? input;

do
{
    input = Console.ReadLine();
    if (input.ToLower().Equals("klar"))
        break;

    inköpslista.Add(input);
}
while (true);

Console.WriteLine();

foreach (var rad in inköpslista)
{
    Console.WriteLine(rad);
}