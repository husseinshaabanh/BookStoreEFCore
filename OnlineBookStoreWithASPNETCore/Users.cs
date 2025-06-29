using OnlineBookStoreWithASPNETCore.Contexts;
using System.Data;

namespace OnlineBookStoreWithASPNETCore
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            try
            {
                using var dbContext = new OnlineBookStoreDbContext();

                var users = dbContext.Customers
                    .Select(c => new
                    {
                        ID = c.CustomerId,
                        NAME = c.First_Name + " " + c.Last_Name,
                        EMAIL = c.Email,
                        PHONE = c.Phone,
                        CITY = c.City,
                        ORDERS = dbContext.Orders.Count(o => o.CustomerId == c.CustomerId)
                    })
                    .ToList();

                dataBooks.DataSource = users;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
