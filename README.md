# ECommerce – Billing Calculation

Application for a retail shop's billing. The shop already had a legacy
BillingSystem calculates amount , GST, Offer based on existing membership and new customer.
The new ask was to support two more customer types without breaking any of the
places that already use that legacy class Billing System:

# Expected output:

Walk-in Customer:
Dear Customer, your bill amount is 1122 and your offer is: 10% discount on next purchase.

Existing Customer
Dear Customer, your bill total amount is 1600.


 New customer — items { 320, 150, 550 }

Sum = 1020
+10% GST = 1122
no discount
Output: your bill amount is 1122 and your offer is  10% discount on next purchase.

Membership customer — items { 100, 500, 500, 500, 400 }

Sum = 2000
+10% GST = 2200
membership discount = 20%
Output: your bill amount is 1760 

# How to run the application
  It is a .net 8 console application
  View --> Terminal --> Run the application using command dotnet run

