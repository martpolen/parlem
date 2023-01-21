using System;

namespace parlem.web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductTypeName { get; set; }
        public int numeracioTerminal { get; set; }
        public DateTime SoldAt { get; set; }
        public int CustomerId { get; set; }
        public string FamilyName { get; set; }
        public string phone { get; set; }



    }
}
