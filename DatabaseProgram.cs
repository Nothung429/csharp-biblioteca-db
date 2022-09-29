//Per quanto riguarda l’esercitazione di oggi dovrete evolvere il precedente progetto della biblioteca aggiungendo le funzionalità applicative necessarie per gestire i dati attraverso l’uso del Database.

//Precodinzioni:

//    1- Creiamo un nuovo progetto chiamato csharp-biblioteca-db che sarà anche il nome della repo.
//    2- Copiamo i file di codice (*.cs) che avevamo realizzato nel precedente progetto della biblioteca e copiamoli nel nuovo progetto.
//    3- Attenzione, non è detto che ci serva tutto, ma è comunque il punto di partenza.

//Cosa fare:

//    1- Analizziamo il codice e cerchiamo di ricostruire la situazione, magari generando uno schema E/R per capire quali tabelle e quali relazioni creare
//    2- Ricordatevi di creare una nuova connessione e un nuovo db per il progetto, non vi servirà caricarlo online, vi basta che esista sulla vostra macchina locale.
//    3- Con lo schema E/R precedente e osservando il codice che abbiamo scritto nel precedente progetto, scriviamo le query per creare le tabelle (potete anche usare l’editor di visual studio)
//    4- Una volta prodotto il DB modifichiamo il codice del vecchio programma in modo che possa leggere e scrivere dal database invece che dalle istanze di oggetti creati a runtime

using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;" + "Initial Catalog=db-library;" + "Integrated Security=True;";

SqlConnection connessioneSql = new SqlConnection(stringaDiConnessione);

try
{
    connessioneSql.Open();

    //void login(string inputUser, string inputPassword)
    //{
    //    String login = "SELECT * FROM User WHERE name=@Name AND password=@Password";
    //    using (SqlCommand cmd = new SqlCommand(login, connessioneSql))
    //    {
    //        cmd.Parameters.Add(new SqlParameter("@Name", inputUser));
    //        cmd.Parameters.Add(new SqlParameter("@Password", inputPassword));
    //        using (SqlDataReader reader = cmd.ExecuteReader())
    //        {
    //            if(reader.Read())
    //            {
    //                Console.WriteLine("Plebeo");
    //            }
    //        }
    //    }
    //}

    string query = "INSERT INTO Product (title, year, category, author, available) VALUES (@title, @year, @category, @author, @available)";

    using SqlCommand cmd = new SqlCommand(query, connessioneSql);

    cmd.Parameters.Add(new SqlParameter("@title", "Harry Potter"));
    cmd.Parameters.Add(new SqlParameter("@year", 2001));
    cmd.Parameters.Add(new SqlParameter("@category", "fantasy"));
    cmd.Parameters.Add(new SqlParameter("@author", "J K Rowling"));
    cmd.Parameters.Add(new SqlParameter("@available", 1));

    cmd.ExecuteNonQuery();

    //using (SqlDataReader reader = cmd.ExecuteReader())
    //{

    //}

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    connessioneSql.Close();
}