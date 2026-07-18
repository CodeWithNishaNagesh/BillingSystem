namespace ECommerce.Billing;

// Applies a discount to an already calculated amount.
public interface IDiscountStrategy
{
   public double Apply(double amount);
}
