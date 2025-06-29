using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Interfaces
{
    public interface IOrderService
    {
        bool PlaceOrder(List<DataGridViewRow> cartItems, string customerId, DataGridView dataReceipt, Label totalL);
    }
}
