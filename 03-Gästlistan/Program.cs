/* 3. Gästlistan (List<T>)
Skapa en dynamisk lista (List<string>) för gäster på en fest. Lägg till 3 gäster med .Add()-metoden.
Skriv ut hur många gäster som är anmälda totalt genom att använda Count-egenskapen. */

List<string> gäster = [];

gäster.Add("Foo");
gäster.Add("Bar");
gäster.Add("Baz");

Console.WriteLine(gäster.Count);