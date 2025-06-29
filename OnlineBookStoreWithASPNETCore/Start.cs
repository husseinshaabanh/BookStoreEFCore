namespace OnlineBookStoreWithASPNETCore
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private async void timer1_Tick1(object sender, EventArgs e)
        {
            progressBar.Value++;
            perLabel.Text = progressBar.Value + "%";
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                await Task.Delay(1000);
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

    }
}
