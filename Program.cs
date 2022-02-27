// See https://aka.ms/new-console-template for more information

//var customer=new Customer("Vahid Cheshmy","v.cheshmy@test.com");

using PrimitiveObsession;

var nameResult = Name.Create("Vahid Cheshmy");
if (nameResult.IsFailure)
    Console.WriteLine(nameResult.Error);

var emailResult = Email.Create("v.cheshmy@test.com");
if(emailResult.IsFailure)
    Console.WriteLine(emailResult.Error);

var customer = CustomerNew.Create(nameResult.Value, emailResult.Value);
Console.WriteLine($"Name is {customer.Name.Value} and Email is:{customer.Email.Value}");

// ToDo: some logics

var newEmail = Email.Create("v.cheshmy@hotmail.com");
customer.ChangeEmail(newEmail.Value);
Console.WriteLine($"Name is {customer.Name.Value} and Email after change:{customer.Email.Value}");


