//BONUS: Le variabili del libro ora devono essere imesse dall'utente tramite console

Console.WriteLine("Qual è il titolo del libro?");

string title = Console.ReadLine();

Console.WriteLine("Chi è del libro?");

string author = Console.ReadLine();

Console.WriteLine("Qual è l'ISBN libro?");

string ImputISBN = Console.ReadLine();

long ISBN = Int64.Parse(ImputISBN);

int pages = 800;

float weight = 500;

float length = 19;

float width = 12.8f;

float depth = 5;

int ReviewsNumber = 208;

float rating = 4.1f;

string KindleAvaible = "Sì";

string FlexCoverAvaible = "Sì";

//Ora che le informazioni sono scritte sotto forma di variabuli, è possibile procedere con la stampa di essi

Console.WriteLine("<<<----------IL LIBRO DI OGGI È: '" + title + "'---------->>>");
Console.WriteLine();
Console.WriteLine("Informazioni principali:");
Console.WriteLine("Autore: " + author);
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero delle pagine: " + pages + " pagine");
Console.WriteLine("Peso del ibro: " + weight + "g");
Console.WriteLine("Dimensioni del libro: " + width + "cm x " + length + "cm x " + depth + "cm");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni:" + ReviewsNumber + " recensioni");
Console.WriteLine("Valutazione media: " + rating + " stelle");
Console.WriteLine("Kindle disponibile? " + KindleAvaible);
Console.WriteLine("Copertina flessibile disponibile? " + FlexCoverAvaible);