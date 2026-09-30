/* 5. Skriv ut baklänges
Deklarera en array med 5 heltal. Skriv en for-loop som startar på sista indexet och räknar nedåt till
noll, så att arrayens element skrivs ut i helt omvänd ordning på skärmen. */

int[] heltal = [1, 2, 3, 4, 5];

for (int i = heltal.Length - 1; i >= 0; i--)
{
    Console.Write($"{heltal[i]} ");
}