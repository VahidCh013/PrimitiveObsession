using CSharpFunctionalExtensions;

namespace PrimitiveObsession;

public class Name
{
    public string Value { get; private set; }

    private Name(string value)
    {
        Value = value;
    }

    public static Result<Name> Create(string name)
    {
        //validate name
        if (string.IsNullOrWhiteSpace(name) || name.Length > 50)
            return Result.Failure<Name>("Name is invalid");
        return Result.Success<Name>(new Name(name));
    }
    
    
    
    public static implicit operator string(Name name)
    {
        return name.Value;
    }
 
    public override bool Equals(object obj)
    {
        Name name = obj as Name;
 
        if (ReferenceEquals(name, null))
            return false;
 
        return Value == name.Value;
    }
 
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}