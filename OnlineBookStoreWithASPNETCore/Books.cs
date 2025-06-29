using Guna.UI2.WinForms;
using OnlineBookStoreWithASPNETCore.Interfaces;
using System.Data;

namespace OnlineBookStoreWithASPNETCore
{
    public partial class Books : UserControl
    {
        string id;
        private readonly IBookRepository bookRepo;
        private readonly IBookService bookService;
        private readonly ICategoryRepository catRepo;
        private readonly IOrderService orderService;
        private readonly ICartService cartService;

        public Books(string cuId, IBookRepository _bookRepo, ICategoryRepository _catRepo, IOrderService _orderService, ICartService _cartService, IBookService _bookService)
        {
            InitializeComponent();
            id = cuId;
            bookRepo = _bookRepo;
            catRepo = _catRepo;
            orderService = _orderService;
            cartService = _cartService;
            bookService = _bookService;
        }
        private void dataBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataBooks.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataBooks.SelectedRows[0];
                    bTitle.Text = selectedRow.Cells["BookTitle"].Value?.ToString() ?? string.Empty;
                    price.Text = selectedRow.Cells["Price"].Value?.ToString() ?? string.Empty;
                    quantity.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddToCart()
        {
            string bookTitle = bTitle.Text;
            int qty = int.Parse(quantity.Text);
            decimal total = decimal.Parse(price.Text);
            cartService.AddOrUpdateCart(dataItems, bookTitle, qty, total);
        }
        private void catCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = catCombo.SelectedItem.ToString();
            LoadBooks(selectedCategory);
        }
        private void Books_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategoriesIntoComboBox();
        }

        int newQuantity = 0;
        decimal pricePerBook = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            newQuantity = int.Parse(quantity.Text);
            Guna2Button b = (Guna2Button)sender;

            if (b == plusBtn)
            {
                bookService.IncreaseQuantity(dataBooks, quantity, newQuantity, pricePerBook, price);
            }
            else if (b == minusBtn)
            {
                bookService.DecreaseQuantity(dataBooks, quantity, newQuantity, pricePerBook, price);
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddToCart();
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataItems.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataItems.SelectedRows)
                    {
                        dataItems.Rows.Remove(row);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            if (dataItems.Rows.Count > 0)
            {
                var cartItems = dataItems.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();
                bool success = orderService.PlaceOrder(cartItems, id, dataReceipt, totalL);
                if (success)
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataItems.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No items in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadBooks(string category = "All")
        {
            try
            {
                var books = bookRepo.GetBooks(category);
                dataBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }

        }
        private void LoadCategoriesIntoComboBox()
        {
            try
            {
                var categories = catRepo.GetCategories();
                catCombo.Items.Clear();
                catCombo.Items.Add("All");
                foreach (var category in categories)
                {
                    catCombo.Items.Add(category);
                }

                if (catCombo.Items.Count > 0)
                {
                    catCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }
    }
}
