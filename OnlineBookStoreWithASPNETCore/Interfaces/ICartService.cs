using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Interfaces
{
    public interface ICartService
    {
        void AddOrUpdateCart(DataGridView dataItems, string title, int quantity, decimal price);
    }
}
