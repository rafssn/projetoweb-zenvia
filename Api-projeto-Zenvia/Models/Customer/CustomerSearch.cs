using System.Collections.Generic;

namespace Api_projeto_Zenvia.Models.Customer
{
    public class CustomerSearch
    {
        public int TotalCount { get; set; }

        public IList<Customer> Customers { get; set; }
    }
}
