namespace BillingSystem.Billing;

// Calculates the bill and then applies a discount on top of it.
public class DiscountBillCalculator : IBillCalculator
{
    private readonly IBillCalculator _calculator;
    private readonly IDiscountStrategy _discount;

    public DiscountBillCalculator(IBillCalculator calculator, IDiscountStrategy discount)
    {
        _calculator = calculator;
        _discount = discount;
    }

    public double Calculate(List<double> prices, int couponCode)
    {
        double amount = _calculator.Calculate(prices, couponCode);
        double amountAfterDiscount = _discount.Apply(amount);
        return amountAfterDiscount;
    }
}
