/* 15. Avancerat: Array-rotation utan extra minne
Skapa en array med 5 heltal (t.ex. [1, 2, 3, 4, 5]). Skriv en algoritm som roterar alla element ett steg
till höger, så att det sista elementet hamnar först (resultat: [5, 1, 2, 3, 4]). Begränsning: Du får inte
skapa en ny array, utan rotationen måste ske direkt i minnet ('in-place') med hjälp av temporära
variabler. */

int[] heltal = [1, 2, 3, 4, 5];

SkrivUtArray(heltal);
RoteraArrayHöger(ref heltal);
SkrivUtArray(heltal);


void RoteraArrayHöger(ref int[] arr)
{
    int lastIndex = arr.Length - 1;

    int temp = heltal[lastIndex];

    for (int i = lastIndex; i > 0; i--)
    {
        heltal[i] = heltal[i - 1];
    }

    heltal[0] = temp;

}

void SkrivUtArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}