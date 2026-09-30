/* 9. Säkerhetskopian
Skapa en array med 4 string-element som innehåller konfigurationer (t.ex. 'IP=192.168.1.1'). Skapa
en helt ny, tom array av samma storlek. Kopiera över alla element från den första arrayen till den
andra med hjälp av metoden Array.Copy(). Ändra sedan ett element i den första arrayen och bevisa
att den andra arrayen förblir oförändrad. */

string[] konfig = [
    "IP=192.168.1.1",
    "DATABASE=MYSQL",
    "COLOR=GREEN",
    "USERNAME=foobar",
    ];

string[] konfigKopia = new string[konfig.Length];

Array.Copy(konfig, konfigKopia, konfig.Length);

konfig[0] = "IP=127.0.0.1";

Console.WriteLine(konfig[0] != konfigKopia[0]);