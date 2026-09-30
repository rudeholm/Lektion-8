/* 2. Inköpslistan på rad
Skapa en array med 4 valfria saker du behöver köpa i en mataffär. Använd en for-loop för att skriva
ut varje sak på en egen rad i konsolen, tillsammans med dess indexnummer (t.ex. '0: Kaffe'). */

string[] matvaror = [
    "Mjölk",
    "Bröd",
    "Smör",
    "Pålägg",
    ];

for (int i = 0; i < matvaror.Length; i++)
{
    Console.WriteLine($"{i}: {matvaror[i]}");
}
