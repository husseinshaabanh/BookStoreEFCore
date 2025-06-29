using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        //[InverseProperty(nameof(Customer.Orders))]        
        public Customer Customer { get; set; }
        public ICollection<OrderBook> OrderBooks { get; set; } = 
            new HashSet<OrderBook>();

    }
}
