using System.Text.RegularExpressions;

public class Customer
{
    public string Name { get;private set; }
    public string Email { get;private set; }
    public Customer(string name, string email)
    {
        //validate name
        if (string.IsNullOrWhiteSpace(name) || name.Length > 50)
            throw new ArgumentException("Name is invalid");
        
        //validate email
        if (string.IsNullOrWhiteSpace(email) || email.Length > 150)
            throw new ArgumentException("Email is invalid");
        if(!Regex.IsMatch(email,@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            throw new ArgumentException("Email is invalid");
            
        Name = name;
        Email = email;
    }

    public void ChangeName(string name)
    {
        //validate name
        if (string.IsNullOrWhiteSpace(name) || name.Length > 50)
            throw new ArgumentException("Name is invalid");
        Name = name;
    }

    public void ChangeEmail(string email)
    {
        //validate email
        if (string.IsNullOrWhiteSpace(email) || email.Length > 150)
            throw new ArgumentException("Email is invalid");
        if(!Regex.IsMatch(email,@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            throw new ArgumentException("Email is invalid");
        Email = email;
    }
}