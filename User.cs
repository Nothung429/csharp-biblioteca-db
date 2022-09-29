public class User
{
    private string name;
    private string surname;
    private string email;
    private string password;
    private int phone;

    public User(string name, string surname, string email, string password, int phone)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }

    public string GetName()
    {
        return this.name;
    }
    public string GetSurname()
    {
        return this.surname;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
    public int GetPhone()
    {
        return this.phone;
    }
}