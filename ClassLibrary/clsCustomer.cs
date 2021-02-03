using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int AddressNo { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public bool IsCustomer { get; set; }
        public decimal TotalSpent { get; set; }
    }
}