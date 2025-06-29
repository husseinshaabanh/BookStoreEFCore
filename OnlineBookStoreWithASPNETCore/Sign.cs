using Guna.UI2.WinForms;
using OnlineBookStoreWithASPNETCore.Contexts;
using OnlineBookStoreWithASPNETCore.Entities;

namespace OnlineBookStoreWithASPNETCore
{
    public partial class Sign : UserControl
    {
        Guna2Button homeBtn;
        public Sign(Guna2Button homeButton)
        {
            InitializeComponent();
            homeBtn = homeButton;
        }
        #region KeyDown
        private void fnameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lnameTb.Focus();
            }
        }
        private void lnameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailTb.Focus();
            }
        }
        private void emailTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passTb.Focus();
            }
        }
        private void passTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phoneTb.Focus();
            }
        }
        private void phoneTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cityTb.Focus();
            }
        }
        private void cityTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                codeTb.Focus();
            }
        }
        private void codeTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                streetTb.Focus();
            }
        }
        private void streetTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }
        #endregion

        #region Enter and Leave Click
        private void fnameTb_Enter(object sender, EventArgs e)
        {
            if (fnameTb.Text == "First name") fnameTb.Text = "";
        }
        private void fnameTb_Leave(object sender, EventArgs e)
        {
            if (fnameTb.Text == "") fnameTb.Text = "First name";
        }

        private void lnameTb_Enter(object sender, EventArgs e)
        {
            if (lnameTb.Text == "Last name") lnameTb.Text = "";
        }
        private void lnameTb_Leave(object sender, EventArgs e)
        {
            if (lnameTb.Text == "") lnameTb.Text = "Last name";
        }

        private void emailTb_Enter(object sender, EventArgs e)
        {
            if (emailTb.Text == "E-mail") emailTb.Text = "";
        }
        private void emailTb_Leave(object sender, EventArgs e)
        {
            if (emailTb.Text == "") emailTb.Text = "E-mail";
        }

        private void passTb_Enter(object sender, EventArgs e)
        {
            if (passTb.Text == "Password") passTb.Text = "";
        }
        private void passTb_Leave(object sender, EventArgs e)
        {
            if (passTb.Text == "") passTb.Text = "Password";
        }

        private void phoneTb_Enter(object sender, EventArgs e)
        {
            if (phoneTb.Text == "Phone") phoneTb.Text = "";
        }
        private void phoneTb_Leave(object sender, EventArgs e)
        {
            if (phoneTb.Text == "") phoneTb.Text = "Phone";
        }

        private void cityTb_Enter(object sender, EventArgs e)
        {
            if (cityTb.Text == "City") cityTb.Text = "";
        }
        private void cityTb_Leave(object sender, EventArgs e)
        {
            if (cityTb.Text == "") cityTb.Text = "City";
        }

        private void codeTb_Enter(object sender, EventArgs e)
        {
            if (codeTb.Text == "Zip code") codeTb.Text = "";
        }
        private void codeTb_Leave(object sender, EventArgs e)
        {
            if (codeTb.Text == "") codeTb.Text = "Zip code";
        }

        private void streetTb_Enter(object sender, EventArgs e)
        {
            if (streetTb.Text == "Street") streetTb.Text = "";
        }
        private void streetTb_Leave(object sender, EventArgs e)
        {
            if (streetTb.Text == "") streetTb.Text = "Street";
        }
        #endregion
        private void createBtn_Click(object sender, EventArgs e)
        {
            var fields = new (Guna2TextBox tb, string placeholder)[]
            {
                (fnameTb, "First name"),
                (lnameTb, "Last name"),
                (emailTb, "E-mail"),
                (passTb, "Password"),
                (phoneTb, "Phone"),
                (cityTb, "City"),
                (codeTb, "Zip code"),
                (streetTb, "Street")
            };
            bool valid = fields.All(f => !string.IsNullOrWhiteSpace(f.tb.Text) && f.tb.Text != f.placeholder);
            if (valid)
            {
                try
                {
                    customerRegistrationToDB();
                    MessageBox.Show("Account created successfully!");
                    homeBtn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                fillL.Visible = true;
            }
        }
        private void customerRegistrationToDB()
        {
            using OnlineBookStoreDbContext dbContext = new OnlineBookStoreDbContext();
            Entities.Customer C1 = new Entities.Customer()
            {
                First_Name = fnameTb.Text,
                Last_Name = lnameTb.Text,
                Email = emailTb.Text,
                Password = passTb.Text,
                Phone = phoneTb.Text,
                City = cityTb.Text,
                Zip_Code = codeTb.Text,
                Street = streetTb.Text
            };
            dbContext.Add(C1);
            dbContext.SaveChanges();
        }

    }
}
