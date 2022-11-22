// See https://aka.ms/new-console-template for more information

/*
Le informazioni sul libro sono le seguenti:Titolo,Autore,ISBN,Numero pagine,Peso del libro,Larghezza, Altezza e Profondità del libro,
Valutazione media,Numero di recensioni,se è disponibile in versione Kindle,se la copertina flessibile è disponibile.
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
Stampiamo bene le informazioni acquisite sulla console.
*/

//INFORMAZIONI DEL LIBRO
string titolo = "Clean code";
string autore = "Robert C. Martin";
string isbn = "978-8850334384";
int numeroPagine = 435;
int pesoLibro = 860; //g
double larghezzaLibro = 17.2; //cm
double altezzaLibro = 17.3; //cm
double profonditaLibro = 2.6; //cm
double valutazioneMedia = 4.5; //SU 5.0
int numeroRecensioni = 119;
bool versioneKindle = true;
bool copertinaFlessibile = true;

double maxValutazione = 5.0;

//STAMPA IN CONSOLE
Console.WriteLine("------ IL LIBRO DI OGGI: " + titolo + " di " + autore + " ------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " g");
Console.WriteLine("Dimensioni del libro: " + larghezzaLibro + " cm x " + altezzaLibro + " cm x " + profonditaLibro + " cm");

Console.WriteLine("");

Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni);
Console.WriteLine("Valitazione media delle recensioni: " + valutazioneMedia + " / " + maxValutazione + " stelle");

if (versioneKindle)
{
    Console.WriteLine("Kindle disponibile: Si");
} else
{
    Console.WriteLine("Kindle disponibile: No");
};

if (copertinaFlessibile)
{
    Console.WriteLine("Copertina flessibile disponibile: Si");
}
else
{
    Console.WriteLine("Copertina flessibile disponibile: No");
};
Console.WriteLine("--------------------------------------------------------------");
