public class Product
{
    protected internal int year;
    protected internal string title;
    protected internal string author;
    protected internal string category;
    protected internal bool status;

    public Product(int year, string title, string author, string category, bool status)
    {
        this.year = year;
        this.title = title;
        this.author = author;
        this.category = category;
        this.status = status;
    }
}