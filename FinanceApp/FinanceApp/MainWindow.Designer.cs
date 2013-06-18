namespace FinanceApp
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyIntrestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyIntrestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerpane = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.collectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem1,
            this.userDetailsToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.registrationToolStripMenuItem.Text = "User";
            // 
            // registrationToolStripMenuItem1
            // 
            this.registrationToolStripMenuItem1.Name = "registrationToolStripMenuItem1";
            this.registrationToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.registrationToolStripMenuItem1.Text = "Registration";
            this.registrationToolStripMenuItem1.Click += new System.EventHandler(this.registrationToolStripMenuItem1_Click);
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userDetailsToolStripMenuItem.Text = "User Details";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyIntrestToolStripMenuItem,
            this.loanDetailsToolStripMenuItem});
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.loanToolStripMenuItem.Text = "Loan";
            // 
            // dailyIntrestToolStripMenuItem
            // 
            this.dailyIntrestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyIntrestToolStripMenuItem1,
            this.financeToolStripMenuItem});
            this.dailyIntrestToolStripMenuItem.Name = "dailyIntrestToolStripMenuItem";
            this.dailyIntrestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dailyIntrestToolStripMenuItem.Text = "New Loan";
            // 
            // dailyIntrestToolStripMenuItem1
            // 
            this.dailyIntrestToolStripMenuItem1.Name = "dailyIntrestToolStripMenuItem1";
            this.dailyIntrestToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dailyIntrestToolStripMenuItem1.Text = "Daily Intrest";
            this.dailyIntrestToolStripMenuItem1.Click += new System.EventHandler(this.dailyIntrestToolStripMenuItem1_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // loanDetailsToolStripMenuItem
            // 
            this.loanDetailsToolStripMenuItem.Name = "loanDetailsToolStripMenuItem";
            this.loanDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loanDetailsToolStripMenuItem.Text = "Loan Details";
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterCollectionToolStripMenuItem,
            this.collectionDetailsToolStripMenuItem});
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.collectionToolStripMenuItem.Text = "Collection";
            // 
            // enterCollectionToolStripMenuItem
            // 
            this.enterCollectionToolStripMenuItem.Name = "enterCollectionToolStripMenuItem";
            this.enterCollectionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.enterCollectionToolStripMenuItem.Text = "Enter Collection";
            // 
            // collectionDetailsToolStripMenuItem
            // 
            this.collectionDetailsToolStripMenuItem.Name = "collectionDetailsToolStripMenuItem";
            this.collectionDetailsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.collectionDetailsToolStripMenuItem.Text = "Collection Details";
            // 
            // containerpane
            // 
            this.containerpane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerpane.Location = new System.Drawing.Point(0, 24);
            this.containerpane.Name = "containerpane";
            this.containerpane.Size = new System.Drawing.Size(930, 420);
            this.containerpane.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 444);
            this.Controls.Add(this.containerpane);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Durga Davi Finance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyIntrestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyIntrestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel containerpane;
    }
}