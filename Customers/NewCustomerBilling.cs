using ECommerce.Billing;

namespace ECommerce.Customers;

// Walk-in (New Customer) customer, send the bill along with the offer for the next purchase.
public  class NewCustomerBilling
{
    private readonly IBillCalculator _billCalculator;
    private readonly IOffer _offer;
    private readonly IEmail _email;

    public NewCustomerBilling(
        IBillCalculator billCalculator,
        IOffer offer,
        IEmail email)
    {
        _billCalculator = billCalculator;
        _offer = offer;
        _email = email;
    }

    public void Billing()
    {
        List<double> itemPrices = new() { 320, 150, 550 };
        double amount = _billCalculator.Calculate(itemPrices);
        string offer = _offer.GetOffer();
        _email.Send($"Dear Customer, your bill amount is {amount} and your offer is {offer} on next purchase");
    }
}
