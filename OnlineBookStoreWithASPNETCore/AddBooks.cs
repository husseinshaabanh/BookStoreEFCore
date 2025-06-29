using Guna.UI2.WinForms;
using OnlineBookStoreWithASPNETCore.Contexts;
using OnlineBookStoreWithASPNETCore.Interfaces;
using OnlineBookStoreWithASPNETCore.Services;

namespace OnlineBookStoreWithASPNETCore
{
    public partial class AddBooks : UserControl
    {
        private Guna2Button addbookBtn;
        private Guna2Button userBtn;
        private Guna2Button dashBtn;
        private readonly ICategoryRepository catRepo;
        private readonly IBookRepository bookRepo;
        private readonly IBookService bookService;
        public AddBooks(Guna2Button _addbookButton, Guna2Button _usersButton, Guna2Button _dashButton, ICategoryRepository _catRepo, IBookRepository _bookRepo, IBookService _bookServ)
        {
            InitializeComponent();
            addbookBtn = _addbookButton;
            userBtn = _usersButton;
            dashBtn = _dashButton;
            catRepo = _catRepo;
            bookRepo = _bookRepo;
            bookService = _bookServ;
        }
        private void add_form(UserControl us)
        {
            containerPanel.Controls.Clear();
            us.Dock = DockStyle.Fill;
            us.BringToFront();
            containerPanel.Controls.Add(us);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn == saveBtn)
            {
                SaveDataToDatabase();
            }
            else if (btn == delBtn)
            {
                DeleteDataFromDatabase();
            }
            else if (btn == userBtn)
            {
                Users users = new Users();
                add_form(users);
                userBtn.FillColor = Color.White;
                userBtn.ForeColor = Color.Black;
            }
        }
        private async void SaveDataToDatabase()
        {
            try
            {
                bool result = await bookService.AddBookWithCategoryAsync(
                                    bTitle.Text,
                                    author.Text,
                                    category.Text,
                                    int.Parse(quantity.Text),
                                    double.Parse(price.Text));
                if (result)
                {
                    MessageBox.Show("Book saved or updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to save book.");
                }
                LoadBooks();
                LoadCategoriesIntoComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
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
        private void LoadBooks(string category = "All")
        {
            try
            {
                var books = bookRepo.GetBooks(category);
                dataGrid.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }
        private async void DeleteDataFromDatabase()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedBookId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["ID"].Value);
                    bool result = await bookService.DeleteBookByIdAsync(selectedBookId);
                    if (result)
                    {
                        MessageBox.Show("Book deleted successfully!");
                        LoadBooks();
                        LoadCategoriesIntoComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Book not found or failed to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void catCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = catCombo.SelectedItem.ToString();
            LoadBooks(selectedCategory);
        }
        private void AddBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategoriesIntoComboBox();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
