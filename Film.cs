public class Film : Product
{
    private string code;
    private int duration;

    public Film(string code, int duration, string title, int year, string author, string category, bool status) : base(year, title, author, category, status)
    {
        this.code = code;
        this.duration = duration;
    }
    public string GetCode()
    {
        return this.code;
    }
    public int GetDuration()
    {
        return this.duration;
    }
}