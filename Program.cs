using SQLite;

//Connessione al Database
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");

//Richieste al Database
var tblArtists = cn1.Query<Artist>("select * from artists");

//Stampa su console di quanti record sono presenti in tblArtists
Console.WriteLine($"In questa tabella ci sono {tblArtists.Count} record!");

//Language Integrate Query
//LINQ

tblArtists = tblArtists.OrderByDescending(x=>x.Name).ToList();
foreach(var artista in tblArtists)
{
    Console.WriteLine($"{artista.Name}");
}

