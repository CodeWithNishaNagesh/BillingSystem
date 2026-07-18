namespace ECommerce.Billing;

// Sends an email message to customers.
public interface IEmail
{
   public void Send(string message);
}
