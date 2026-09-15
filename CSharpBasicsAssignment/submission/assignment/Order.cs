using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsAssignment
{
    public class Order
    {
       public int OrderId;
        public  string CustomerName;
        public int Quantity;
        public  decimal UnitPrice;
        public  decimal TotalPrice;
        public  bool IsPaid;
        public  double DiscountPercent;
        public  string ShippingCity;
        public  char Priority;
        public  long ItemCode;

        public Order(int OrderId, string CustomerName, int Quantity, decimal UnitPrice, decimal TotalPrice, bool IsPaid, double DiscountPercent, string ShippingCity, char Priority, long ItemCode)
        {
            this.OrderId = OrderId;
            this.CustomerName = CustomerName;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.TotalPrice = TotalPrice;
            this.IsPaid = IsPaid;
            this.DiscountPercent = DiscountPercent;
            this.ShippingCity = ShippingCity;
            this.Priority = Priority;
            this.ItemCode = ItemCode;
        }
        public Order()
        {
            
        }
        public void CalculateTotal()
        {
            TotalPrice = Quantity * UnitPrice * (decimal)(1 - DiscountPercent / 100);
        }

        public void PrintSummary()
        {
            Console.WriteLine(
                $"OrderId: {OrderId}, Customer: {CustomerName}, TotalPrice: {TotalPrice}, IsPaid: {IsPaid} " 
                
            );
        }
    }
}
