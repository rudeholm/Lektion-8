/* 4. Temperaturer
Skapa en array av typen double med 7 värden som representerar veckans temperaturer. Skriv ett
program som letar upp och skriver ut den allra högsta temperaturen i arrayen. (Inga avancerade
LINQ-funktioner, använd en vanlig loop och en variabel för att spara högsta värdet). */

double[] temperaturer = [24.3, 25.3, 25.9, 27.0, 24.8, 23.2, 22.2];
double högstaTemp = 0;

for (int i = 0; i < temperaturer.Length; i++)
{
    if (temperaturer[i] > högstaTemp)
        högstaTemp = temperaturer[i];
}

Console.WriteLine($"Högst: {högstaTemp:F2} ºC");