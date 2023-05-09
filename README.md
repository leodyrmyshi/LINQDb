# LINQDb
Inanzitutto scarichiamo il file da un link che ci viene assegnato dal professore.
creiamo una carertlla sul desktop

![Cattura5](https://user-images.githubusercontent.com/116791297/236147586-9c8f96a9-c271-4750-9e00-0a428b782c05.PNG)



Una volta scaricato apriamo visual studio e andiamo su nuovo progetto --> apri una cartella --> una volta aperta la cartella apriamo il terminale e scirviamo sul terminale dotnet new console.

![Cattura2](https://user-images.githubusercontent.com/116791297/236143796-924bbae4-d1af-4354-a859-5cef86adfc20.PNG)

Dotnet new console serve:
1) A creare un nuovo progetto
2) File di configurazione o soluzione in base al modello specificato

una volta effettuato il dotnet si ottiene questo

![Cattura3](https://user-images.githubusercontent.com/116791297/236144041-c3b87cc1-d676-4b02-b2f1-dfab9916dd95.PNG)


per scaricare la libreria desiderata dobbiamo andare nella sezione delle estensioni
![Cattura](https://user-images.githubusercontent.com/116791297/236142487-2815eca5-e162-4237-aac9-d8f3ac6e118c.PNG)

i link dove scaricare il diagramma del db chinook.db è questo:
https://www.sqlitetutorial.net/sqlite-sample-database/#:~:text=the%20following%20link.-,Download%20SQLite%20sample%20database,-In%20case%20you

come connettersi a SQLite

![Cattura4](https://user-images.githubusercontent.com/116791297/236147625-a78b9bee-69b7-4c95-ae57-d45fe1b865fb.PNG)

il codice in c# per visualizzare gli artisti è questo:

![Cattura6](https://user-images.githubusercontent.com/116791297/236148315-88d4520d-e279-48f7-a608-7dfa9880d3b1.PNG)

il codice per visualizzare gli in ordine di artistID e Name è:

###
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
###
