// See https://aka.ms/new-console-template for more information

//BONUS

/*
Le informazioni sul libro sono le seguenti:Titolo,Autore,ISBN,Numero pagine,Peso del libro,Larghezza, Altezza e Profondità del libro,
Valutazione media,Numero di recensioni,se è disponibile in versione Kindle,se la copertina flessibile è disponibile.
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
Stampiamo bene le informazioni acquisite sulla console.
*/

/*
//INFORMAZIONI DEL LIBRO
string titolo = "Clean code";
string autore = "Robert C. Martin";
string isbn = "978-8850334384";
int numeroPagine = 435;
int pesoLibro = 860; //g
double larghezzaLibro = 17.2; //cm
double altezzaLibro = 17.3; //cm
double profonditaLibro = 2.6; //cm
double valutazioneMedia = 4.5; //SU 5
int numeroRecensioni = 119;
bool versioneKindle = true;
bool copertinaFlessibile = true;
*/

double maxValutazione = 5.0;

//INFORMAZIONI CHIESTE ALL'UTENTE






//STAMPA IN CONSOLE
Console.WriteLine("------ IL LIBRO DI OGGI: " + titoloUtente + " di " + autoreUtente + " ------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbnUtente);
Console.WriteLine("Numero delle pagine: " + numeroPagineUtente + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibroUtente + " g");
Console.WriteLine("Dimensioni del libro: " + larghezzaLibroUtente + " cm x " + altezzaLibroUtente + " cm x " + profonditaLibroUtente + " cm");

Console.WriteLine("");

Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioniUtente);
Console.WriteLine("Valutazione media delle recensioni: " + valutazioneMediaUtente + " / " + maxValutazione + " stelle");

if (versioneKindleUtente)
{
    Console.WriteLine("Kindle disponibile: Si");
}
else
{
    Console.WriteLine("Kindle disponibile: No");
};

if (copertinaFlessibileUtente)
{
    Console.WriteLine("Copertina flessibile disponibile: Si");
}
else
{
    Console.WriteLine("Copertina flessibile disponibile: No");
};
Console.WriteLine("--------------------------------------------------------------");
