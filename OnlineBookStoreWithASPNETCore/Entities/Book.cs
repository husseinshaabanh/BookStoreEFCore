using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Entities
{
    public class Book
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }  
        public ICollection<OrderBook> BookOrders { get; set; } =
            new HashSet<OrderBook>();
    }
}
