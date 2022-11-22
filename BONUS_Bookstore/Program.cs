//BONUS: Le variabili del libro ora devono essere imesse dall'utente tramite console
using System.Globalization;                            //Viene usato per rendere possibile la trasformazione dell'input in numeri decimali

Console.WriteLine("Qual è il titolo del libro?");

string title = Console.ReadLine();

Console.WriteLine("Chi è l'autore del libro?");

string author = Console.ReadLine();

Console.WriteLine("Qual è l'ISBN libro?");

string ImputISBN = Console.ReadLine();

long ISBN = Int64.Parse(ImputISBN);

Console.WriteLine("Quante pagine ha il libro?");

string ImputPages = Console.ReadLine();

int pages = Int32.Parse(ImputPages);     

Console.WriteLine("Quanti grammi pesa il libro?");

string ImputWeight = Console.ReadLine();

ImputWeight = ImputWeight.Replace(',', '.');

float weight = float.Parse(ImputWeight, CultureInfo.InvariantCulture);

Console.WriteLine("Quant'è la lunghezza del libro? (cm)");

string ImputLength = Console.ReadLine();

ImputLength = ImputLength.Replace(',', '.');

float length = float.Parse(ImputLength, CultureInfo.InvariantCulture);

Console.WriteLine("Quant'è la larghezza del libro? (cm)");

string ImputWidth = Console.ReadLine();

ImputWidth = ImputWidth.Replace(',', '.');

float width = float.Parse(ImputLength, CultureInfo.InvariantCulture);

Console.WriteLine("Quant'è la profodnità del libro? (cm)");

string ImputDepth = Console.ReadLine();

ImputDepth = ImputDepth.Replace(',', '.');

float depth = float.Parse(ImputDepth, CultureInfo.InvariantCulture);

Console.WriteLine("Quante recensioni ha il libro?");

string ImputReviews = Console.ReadLine();

int ReviewsNumber = Int32.Parse(ImputReviews);

Console.WriteLine("Qual è la media delle valutazioni del libro? (stelle)");

string ImputRating = Console.ReadLine();

ImputRating = ImputRating.Replace(',', '.');

float rating = float.Parse(ImputRating, CultureInfo.InvariantCulture);

Console.WriteLine("Il libro è disponibile su Kindle?");

string KindleAvaible = Console.ReadLine();

Console.WriteLine("Il libro è disponibile con la copertina flessibile?");

string FlexCoverAvaible = Console.ReadLine();

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
Console.WriteLine("Numero di recensioni: " + ReviewsNumber + " recensioni");
Console.WriteLine("Valutazione media: " + rating + " stelle");
Console.WriteLine("Kindle disponibile? " + KindleAvaible);
Console.WriteLine("Copertina flessibile disponibile? " + FlexCoverAvaible);