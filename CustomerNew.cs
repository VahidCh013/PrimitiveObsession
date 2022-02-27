namespace PrimitiveObsession;

public class CustomerNew
{
    public Name Name { get;private set; }
    public Email Email { get;private set; }

    private CustomerNew(Name name,Email email)
    {
        Name = name;
        Email = email;
    }

    public void ChangeEmail(Email email)
    {
        Email.ChangeEmail(email);
    }

    public static CustomerNew Create(Name name, Email email)
    {
        return new CustomerNew(name, email);
    }
}