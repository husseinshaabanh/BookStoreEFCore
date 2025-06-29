using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; } // ← هنا string فقط للعرض
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
