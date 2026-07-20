namespace BillingSystem.Billing;

// No discount for new membership customers.
public class NewMembershipDiscount : IDiscountStrategy
{
    public double Apply(double amount)
    {
        return amount - (amount * (int)DiscountRate.None / 100);
    }
}
