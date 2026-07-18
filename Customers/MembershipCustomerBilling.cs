using ECommerce.Billing;


namespace ECommerce.Customers;

// Membership customer: 20% discount and only the bill is emailed (no offer).
public  class MembershipCustomerBilling
{
    private readonly IBillCalculator _billCalculator;
    private readonly IEmail _email;

    public MembershipCustomerBilling(
        IBillCalculator billCalculator,
        IEmail email)
    {
        _billCalculator = billCalculator;
        _email = email;
    }

    public void Billing()
    {
        List<double> itemPrices = new() { 100, 500, 500, 500, 400 };
        double totalCost = _billCalculator.Calculate(itemPrices);
        _email.Send($"Dear Customer, your bill amount is {totalCost}");
    }
}
