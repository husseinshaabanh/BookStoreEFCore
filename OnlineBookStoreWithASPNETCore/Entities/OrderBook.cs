using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Entities
{
    public class OrderBook
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
