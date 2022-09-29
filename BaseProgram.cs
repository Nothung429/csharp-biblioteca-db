﻿//creazione utente
User myUser = new User("Mario", "Rossi", "mariorossi@gmail.com", "prova123", 333777888);

//creazione prodotti
Book myBook = new Book("12345678", 1200, "il signore degli anelli", 1954, "J. R. R. Tolkien", "fantasy", true);
Film myFilm = new Film("87654321", 200, "il signore degli anelli: la compagnia dell'anello", 2001, "J. R. R. Tolkien", "fantasy", true);

//accesso
Console.WriteLine("Esegui l'accesso");
string verifyUserEmail = Console.ReadLine();
string verifyUserPassword = Console.ReadLine();
if (verifyUserEmail == myUser.GetEmail() && verifyUserPassword == myUser.GetPassword())
{
    //ricerca
    Console.WriteLine("Cerca un libro");
    bool searchBooksTitle = myBook.title.Contains(Console.ReadLine());
    bool searchBooksIsbn = myBook.GetIsbn().Contains(Console.ReadLine());
    if (searchBooksTitle == true || searchBooksIsbn == true)
    {
        Console.WriteLine($"Il libro esiste in libreria? {myBook.title} \n");
    }
    else
    {
        Console.WriteLine("Ci dispiace non abbiamo questo titolo \n");
    }

    Console.WriteLine("Cerca un film");
    bool searchFilmsTitle = myFilm.title.Contains(Console.ReadLine());
    bool searchFilmsCode = myFilm.GetCode().Contains(Console.ReadLine());
    if (searchFilmsTitle == true || searchFilmsCode == true)
    {
        Console.WriteLine($"Il film esiste in libreria? {myFilm.title} \n");
    }
    else
    {
        Console.WriteLine("Ci dispiace non abbiamo questo titolo \n");
    }

    //prenotazione
    if (myBook.status == true)
    {
        Console.WriteLine("Vuoi prenotare il libro?\n si/no");        
        if (Console.ReadLine() == "si")
        {            
            Console.WriteLine("Per quale periodo vorresti prenotarlo?\n");
            Console.WriteLine("Dal ");
            string dataInizio = Console.ReadLine();
            Console.WriteLine("Al ");
            string dataFine = Console.ReadLine();
            Console.WriteLine($"{myBook.title} prenotato con successo dal {dataInizio} al {dataFine}");
            Console.WriteLine($"{myUser.GetName()} {myUser.GetSurname()} {myUser.GetPhone()}");
            myBook.status = false;
        }
    } 
    else
    {
        Console.WriteLine("Libro non disponibile");
    }

    if (myFilm.status == true)
    {
        Console.WriteLine("Vuoi prenotare il film?\n si/no");
        if (Console.ReadLine() == "si")
        {
            Console.WriteLine("Per quale periodo vorresti prenotarlo?");
            Console.WriteLine("Dal ");
            string dataInizio = Console.ReadLine();
            Console.WriteLine("Al ");
            string dataFine = Console.ReadLine();
            Console.WriteLine($"{myFilm.title} prenotato con successo dal {dataInizio} al {dataFine}");
            Console.WriteLine($"{myUser.GetName()} {myUser.GetSurname()} {myUser.GetPhone()}");
            myFilm.status = false;
        }
    }
    else
    {
        Console.WriteLine("Film non disponibile");
    }
}
else
{
    Console.WriteLine("\nRegistrati\n");
}

//Console.WriteLine($"\nL'ISBN del libro è: {myBook.GetIsbn()}");
//Console.WriteLine($"Il numero di pagine del libro è: {myBook.GetPageNumber()}");
//Console.WriteLine($"Il titolo del libro è: {myBook.title}");
//Console.WriteLine($"L'anno di uscita del libro è: {myBook.year}");
//Console.WriteLine($"L'autore del libro è: {myBook.author}");
//Console.WriteLine($"La categoria del libro è: {myBook.category}");
//Console.WriteLine($"La disponibilità del libro è: {myBook.status} \n");

//Console.WriteLine($"\nIl codice del film è: {myFilm.GetCode()}");
//Console.WriteLine($"La durata del film è: {myFilm.GetDuration()} minuti");
//Console.WriteLine($"Il titolo del film è: {myFilm.title}");
//Console.WriteLine($"L'anno di uscita del film è: {myFilm.year}");
//Console.WriteLine($"L'autore del film è: {myFilm.author}");
//Console.WriteLine($"La categoria del film è: {myFilm.category}");
//Console.WriteLine($"La disponibilità del film è: {myFilm.status} \n");