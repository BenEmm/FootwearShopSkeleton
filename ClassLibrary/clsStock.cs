using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public DateTime DateOrdered { get; set; }
        public int StockID { get; set; }
        public string StockDescription { get; set; }
        public string StockColour { get; set; }
        public bool Available { get; set; }
        public int StockAmount { get; set; }
        public decimal StockPrice { get; set; }
    }
}