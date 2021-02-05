using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string Quantity { get; set; }
        public bool Shipped { get; set; }
        public DateTime ShippingDate { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public decimal TotalPrice { get; set; }
    }
}