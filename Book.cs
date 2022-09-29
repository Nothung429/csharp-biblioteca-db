public class Book : Product
{
    private string ISBN;
    private int pageNumber;

    public Book(string ISBN, int pageNumber, string title, int year, string author, string category, bool status) : base(year, title, author, category, status)
    {
        this.ISBN = ISBN;
        this.pageNumber = pageNumber;
    }

    public string GetIsbn()
    {
        return this.ISBN;
    }
    public int GetPageNumber()
    {
        return this.pageNumber;
    }
}