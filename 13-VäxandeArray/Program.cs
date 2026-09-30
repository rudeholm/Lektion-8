/* 13. Avancerat: Den växande arrayen
Simulera hur en List<T> fungerar under huven. Skapa en fast array med storlek 3. Låt användaren
mata in tal i en oändlig loop. När arrayen blir full ska programmet automatiskt skapa en ny array
som är dubbelt så stor, kopiera över de gamla värdena, ersätta den gamla arrayen med den nya och
fortsätta ta emot inmatningar. Skriv ut ett meddelande varje gång arrayen expanderar. */

int[] heltal = new int[3];
int index = 0;

while (true)
{
    var giltigInput = false;

    while (giltigInput == false)
    {
        Console.Write($"Heltal #{index + 1}: ");
        giltigInput = int.TryParse(Console.ReadLine(), out int nummer);
        if (giltigInput)
            heltal[index] = nummer;
        else
        {
            Console.WriteLine("FEL - Ange ett heltal");
        }
    }

    if (++index >= heltal.Length)
    {
        foreach (var nummer in heltal)
        {
            Console.Write($"{nummer}, ");
        }
        Console.WriteLine();
        Console.WriteLine("Kapacitet uppnådd. Expanderar vektorn!");
        int[] nyArray = new int[heltal.Length * 2];
        Array.Copy(heltal, nyArray, heltal.Length);
        heltal = nyArray;
    }
}

foreach (var nummer in heltal)
{
    Console.WriteLine(nummer);
}