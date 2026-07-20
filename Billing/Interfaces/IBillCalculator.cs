namespace BillingSystem.Billing;

// Calculates the bill for a list of item prices.
public interface IBillCalculator
{
    public double Calculate(List<double> prices, int couponCode = 0);
}
