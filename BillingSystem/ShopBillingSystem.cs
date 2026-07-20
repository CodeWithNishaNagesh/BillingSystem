using BillingSystem.Billing;

namespace BillingSystem.BillingSystem;

// Billing system used by the shop. 
// BillingSystem has a protected constructor, so we create it through this subclass. The inherited Calculate and GetOffer methods.
public sealed class ShopBillingSystem : BillingSystem, IBillCalculator, IOffer
{
}
