using System.Collections.Generic;

namespace parlem.web.Models
{

    public class CustomerViewModel
    {
        public List<CustomerModel> Customers { get; set; }
    }

    public class CustomerModel
    {
        public int Id { get; set; }
        public string DocType { get; set; }
        public string DocNum { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string phone { get; set; }
    }
}
