/* 11. Detektiven (Duplikat)
Skapa en array med 7 strängar där vissa namn förekommer flera gånger. Skriv ett program som
hittar och skriver ut vilka namn som är duplikat (förekommer mer än en gång) i arrayen, utan att
använda LINQ. */

string[] namnlista = [
    "Foo",
    "Bar",
    "Baz",
    "Foo",
    "Baz",
    "Goo",
    "Baz",
    ];

List<string> duplikat = [];

for (int i = 0; i < namnlista.Length; i++)
{
    for (int j = 0; j < namnlista.Length; j++)
    {
        if (i != j)
        {
            if (namnlista[i].Equals(namnlista[j]) && duplikat.Contains(namnlista[i]) == false)
            {
                duplikat.Add(namnlista[i]);
            }
        }
    }
}

Console.WriteLine("Följande namn förekommer flera gånger: ");
foreach (var namn in duplikat)
{
    Console.WriteLine(namn);
}