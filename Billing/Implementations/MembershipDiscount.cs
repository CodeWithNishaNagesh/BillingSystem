namespace ECommerce.Billing;

// 20% discount for membership customers.
public class MembershipDiscount : IDiscountStrategy
{
    public double Apply(double amount)
    {
        return amount - (amount * (int)DiscountRate.Membership / 100);
    }
}
