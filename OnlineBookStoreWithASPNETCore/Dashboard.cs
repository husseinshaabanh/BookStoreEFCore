using OnlineBookStoreWithASPNETCore.Contexts;

namespace OnlineBookStoreWithASPNETCore
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            using OnlineBookStoreDbContext dbContext = new OnlineBookStoreDbContext();
            var customerCount = dbContext.Customers.Count();
            var orderCount = dbContext.Orders.Count();
            var totalOrderQuantity = dbContext.Orders.Sum(o => o.Quantity);
            var totalBookQuantity = dbContext.Books.Sum(b => b.Quantity);

            label1.Text += " : " + customerCount.ToString();
            label2.Text += " : " + orderCount.ToString();
            label4.Text += " : " + totalOrderQuantity.ToString();
            label3.Text += " : " + totalBookQuantity.ToString();
        }
    }
}
