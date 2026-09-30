/* 12. Inmatning till fast array
Du har en fast array av typen int med storlek 5. Låt användaren mata in heltal via konsolen tills
arrayen är helt full. Programmet måste vara kraschsäkert – om användaren skriver en felaktig
sträng (eller text) ska ett felmeddelande visas och programmet ska be om samma index igen utan
att räkna upp loop-räknaren. */

int[] heltal = new int[5];

for (int i = 0; i < heltal.Length; i++)
{
    var giltigInput = false;

    while (giltigInput == false)
    {
        Console.Write($"Heltal #{i+1}: ");
        giltigInput = int.TryParse(Console.ReadLine(), out int nummer);
        if (giltigInput)
            heltal[i] = nummer;
        else
        {
            Console.WriteLine("FEL - Ange ett heltal");
        }
    }
    
}

foreach (var nummer in heltal)
{
    Console.WriteLine(nummer);    
}