/* 8. Betygskollen (Medelvärde)
Skapa en array som innehåller 5 olika provpoäng (heltal). Räkna ut medelpoängen för dessa prov
och skriv ut resultatet. (Kom ihåg att typkonvertera summan till double innan divisionen så att
decimalerna inte försvinner i heltalsdivision). */

int[] provpoäng = [93, 87, 95, 89, 92];
double totalt = 0.0;
foreach (var poäng in provpoäng)
{
    totalt += poäng;
}

double medel = totalt / provpoäng.Length;

Console.WriteLine($"Medel: {medel:F2}");