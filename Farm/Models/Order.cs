using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm.Models
{
    public class Order
    {
        public string Id { get; set; }

        public List<OrderItems> OrderItems { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
