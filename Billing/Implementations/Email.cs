namespace BillingSystem.Billing;

// Sends the email by writing it to the console.
public class Email : IEmail
{
    public void Send(string message) { Console.WriteLine(message); }
}
