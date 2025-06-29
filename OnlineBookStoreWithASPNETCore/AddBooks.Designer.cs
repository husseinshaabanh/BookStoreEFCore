namespace OnlineBookStoreWithASPNETCore
{
    partial class AddBooks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            containerPanel = new Panel();
            dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            catCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            category = new Guna.UI2.WinForms.Guna2TextBox();
            delBtn = new Guna.UI2.WinForms.Guna2Button();
            saveBtn = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            quantity = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            price = new Guna.UI2.WinForms.Guna2TextBox();
            author = new Guna.UI2.WinForms.Guna2TextBox();
            bTitle = new Guna.UI2.WinForms.Guna2TextBox();
            containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.WhiteSmoke;
            containerPanel.Controls.Add(dataGrid);
            containerPanel.Controls.Add(label7);
            containerPanel.Controls.Add(catCombo);
            containerPanel.Controls.Add(category);
            containerPanel.Controls.Add(delBtn);
            containerPanel.Controls.Add(saveBtn);
            containerPanel.Controls.Add(label6);
            containerPanel.Controls.Add(quantity);
            containerPanel.Controls.Add(label5);
            containerPanel.Controls.Add(label4);
            containerPanel.Controls.Add(label3);
            containerPanel.Controls.Add(label2);
            containerPanel.Controls.Add(price);
            containerPanel.Controls.Add(author);
            containerPanel.Controls.Add(bTitle);
            containerPanel.Location = new Point(0, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(952, 721);
            containerPanel.TabIndex = 3;
            // 
            // dataGrid
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGrid.ColumnHeadersHeight = 18;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            dataGrid.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid.Location = new Point(48, 350);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.Size = new Size(856, 329);
            dataGrid.TabIndex = 17;
            dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGrid.ThemeStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.ThemeStyle.HeaderStyle.Height = 18;
            dataGrid.ThemeStyle.ReadOnly = true;
            dataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGrid.ThemeStyle.RowsStyle.Height = 24;
            dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(435, 273);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 16;
            label7.Text = "Category";
            // 
            // catCombo
            // 
            catCombo.AutoRoundedCorners = true;
            catCombo.BackColor = Color.Transparent;
            catCombo.BorderRadius = 17;
            catCombo.DrawMode = DrawMode.OwnerDrawFixed;
            catCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            catCombo.FocusedColor = Color.FromArgb(94, 148, 255);
            catCombo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            catCombo.Font = new Font("Segoe UI", 10F);
            catCombo.ForeColor = Color.FromArgb(68, 88, 112);
            catCombo.ItemHeight = 30;
            catCombo.Location = new Point(362, 298);
            catCombo.Name = "catCombo";
            catCombo.Size = new Size(225, 36);
            catCombo.TabIndex = 15;
            catCombo.SelectedIndexChanged += catCombo_SelectedIndexChanged;
            // 
            // category
            // 
            category.Animated = true;
            category.AutoRoundedCorners = true;
            category.BorderRadius = 18;
            category.Cursor = Cursors.IBeam;
            category.DefaultText = "";
            category.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            category.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            category.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            category.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            category.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            category.Font = new Font("Segoe UI", 9F);
            category.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            category.Location = new Point(630, 68);
            category.Margin = new Padding(3, 4, 3, 4);
            category.Name = "category";
            category.PasswordChar = '\0';
            category.PlaceholderText = "";
            category.SelectedText = "";
            category.Size = new Size(245, 38);
            category.TabIndex = 14;
            // 
            // delBtn
            // 
            delBtn.Animated = true;
            delBtn.AutoRoundedCorners = true;
            delBtn.BorderRadius = 21;
            delBtn.DisabledState.BorderColor = Color.DarkGray;
            delBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            delBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            delBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            delBtn.FillColor = Color.FromArgb(64, 64, 64);
            delBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delBtn.ForeColor = Color.White;
            delBtn.Location = new Point(546, 212);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(264, 45);
            delBtn.TabIndex = 13;
            delBtn.Text = "Delete";
            delBtn.Click += btn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Animated = true;
            saveBtn.AutoRoundedCorners = true;
            saveBtn.BorderRadius = 21;
            saveBtn.DisabledState.BorderColor = Color.DarkGray;
            saveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            saveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            saveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            saveBtn.FillColor = Color.FromArgb(64, 64, 64);
            saveBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(174, 212);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(264, 45);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.Click += btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(169, 128);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 10;
            label6.Text = "Quantity";
            // 
            // quantity
            // 
            quantity.Animated = true;
            quantity.AutoRoundedCorners = true;
            quantity.BorderRadius = 18;
            quantity.Cursor = Cursors.IBeam;
            quantity.DefaultText = "";
            quantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            quantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            quantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            quantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            quantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            quantity.Font = new Font("Segoe UI", 9F);
            quantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            quantity.Location = new Point(92, 154);
            quantity.Margin = new Padding(3, 4, 3, 4);
            quantity.Name = "quantity";
            quantity.PasswordChar = '\0';
            quantity.PlaceholderText = "";
            quantity.SelectedText = "";
            quantity.Size = new Size(245, 38);
            quantity.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(464, 128);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(718, 42);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 7;
            label4.Text = "Categories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(454, 43);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(169, 42);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Book title";
            // 
            // price
            // 
            price.Animated = true;
            price.AutoRoundedCorners = true;
            price.BorderRadius = 18;
            price.Cursor = Cursors.IBeam;
            price.DefaultText = "";
            price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            price.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            price.Font = new Font("Segoe UI", 9F);
            price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            price.Location = new Point(362, 154);
            price.Margin = new Padding(3, 4, 3, 4);
            price.Name = "price";
            price.PasswordChar = '\0';
            price.PlaceholderText = "";
            price.SelectedText = "";
            price.Size = new Size(245, 38);
            price.TabIndex = 3;
            // 
            // author
            // 
            author.Animated = true;
            author.AutoRoundedCorners = true;
            author.BorderRadius = 18;
            author.Cursor = Cursors.IBeam;
            author.DefaultText = "";
            author.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            author.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            author.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            author.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            author.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            author.Font = new Font("Segoe UI", 9F);
            author.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            author.Location = new Point(362, 68);
            author.Margin = new Padding(3, 4, 3, 4);
            author.Name = "author";
            author.PasswordChar = '\0';
            author.PlaceholderText = "";
            author.SelectedText = "";
            author.Size = new Size(245, 38);
            author.TabIndex = 1;
            // 
            // bTitle
            // 
            bTitle.Animated = true;
            bTitle.AutoRoundedCorners = true;
            bTitle.BorderRadius = 18;
            bTitle.Cursor = Cursors.IBeam;
            bTitle.DefaultText = "";
            bTitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            bTitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            bTitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            bTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            bTitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            bTitle.Font = new Font("Segoe UI", 9F);
            bTitle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            bTitle.Location = new Point(92, 68);
            bTitle.Margin = new Padding(3, 4, 3, 4);
            bTitle.Name = "bTitle";
            bTitle.PasswordChar = '\0';
            bTitle.PlaceholderText = "";
            bTitle.SelectedText = "";
            bTitle.Size = new Size(245, 38);
            bTitle.TabIndex = 0;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(containerPanel);
            Name = "AddBooks";
            Size = new Size(952, 721);
            Load += AddBooks_Load;
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private Guna.UI2.WinForms.Guna2TextBox author;
        private Guna.UI2.WinForms.Guna2TextBox bTitle;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button delBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2TextBox category;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox catCombo;
    }
}
