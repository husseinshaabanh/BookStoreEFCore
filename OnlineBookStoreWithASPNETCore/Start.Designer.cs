namespace OnlineBookStoreWithASPNETCore
{
    partial class Start
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            label1 = new Label();
            label2 = new Label();
            perLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(44, 532);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 1;
            label1.Text = "Loading...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 11);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 17;
            label2.Text = "Online Book Store";
            // 
            // perLabel
            // 
            perLabel.AutoSize = true;
            perLabel.BackColor = Color.Transparent;
            perLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            perLabel.ForeColor = Color.Red;
            perLabel.Location = new Point(165, 532);
            perLabel.Name = "perLabel";
            perLabel.Size = new Size(27, 22);
            perLabel.TabIndex = 18;
            perLabel.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick1;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(47, 564);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(722, 22);
            progressBar.TabIndex = 19;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.progress;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 592);
            Controls.Add(progressBar);
            Controls.Add(perLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Book Store";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label perLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

