using ECommerce.Billing;
using ECommerce.BillingSystem;
using ECommerce.Customers;

IEmail email = new Email();
ShopBillingSystem billing = new();

// New customer - bill without discount ,plus the offer of next purchase.
var newCustomerBilling = new NewCustomerBilling(billing, billing, email);

// Membership customer - 20% discount.
IBillCalculator membershipCalculator = new DiscountBillCalculator(billing, new MembershipDiscount());
var membershipCustomerBilling = new MembershipCustomerBilling(membershipCalculator, email);

newCustomerBilling.Billing();
membershipCustomerBilling.Billing();
