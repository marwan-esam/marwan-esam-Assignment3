using System.Diagnostics.Contracts;

namespace CSharpBasicsAssignment;

enum PriorityValues
{
  High,
  Medium,
  Low,
}
public class Order
{
  public int OrderID;
  public string CustomerName = "Sample Customer";
  public int Quantity;
  public decimal UnitPrice;
  public decimal TotalPrice;
  public bool IsPaid;
  public double DiscountPercent;
  public string ShippingCity = "Sample City";
  public char Priority;
  public long ItemCode;

  public decimal CalculateTotal()
  {
    decimal total = Quantity * UnitPrice * (1 - (decimal) DiscountPercent / 100m);
    TotalPrice = total;
    return TotalPrice;
  }

  public void PrintSummary()
  {
    Console.WriteLine($"Order ID: {OrderID}, Customer Name: {CustomerName}, Total Price: {TotalPrice} => Order is {(IsPaid ? "paid" : "not paid")}");
  }
}