namespace ECommerce.BillingSystem;

/// <summary>
/// LEGACY class. Responsible only for bill calculation and is consumed in
/// several other places across the code. It must remain untouched so that existing callers not impacted
/// </summary>
public class BillingSystem
{
    protected BillingSystem()
    {
    }

    public double Calculate(List<double> prices, int couponCode = 0)
    {
        double amount = GetAmount(prices);
        return ApplyGST(amount) - ApplyCoupon(amount, couponCode);
    }

    public string GetOffer()
    {
        return "Coupon Code 1: 10% discount on next purchase.";
    }

    private double GetAmount(List<double> items)
    {
        return items.Sum();
    }

    private double ApplyGST(double amount)
    {
        return amount + (amount * 10 / 100);
    }

    private double ApplyCoupon(double amount, int couponCode)
    {
        if (couponCode <= 0)
        {
            return 0;
        }

        return (amount * 10 / 100);
    }
}
