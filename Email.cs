using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace PrimitiveObsession;

public class Email
{
    public string Value { get; private set; }

    private Email(string value)
    {
        Value = value;
    }
    public static Result<Email> Create(string email)
    {
        //validate email
        if (string.IsNullOrWhiteSpace(email) || email.Length > 150)
            return Result.Failure<Email>("Email is invalid");
        if(!Regex.IsMatch(email,@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            return Result.Failure<Email>("Email is invalid");
        return Result.Success<Email>(new Email(email));
    }

    public void ChangeEmail(Email email)
    {
        Value = email.Value;
    }
}