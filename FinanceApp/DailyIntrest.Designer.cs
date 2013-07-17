namespace FinanceApp
{
    partial class DailyIntrest
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
            this.gbdailyintrest = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.userLoanDetails = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtintrest = new System.Windows.Forms.TextBox();
            this.txtloan = new System.Windows.Forms.TextBox();
            this.cbAutherized = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.gbdailyintrest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoanDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdailyintrest
            // 
            this.gbdailyintrest.Controls.Add(this.splitContainer1);
            this.gbdailyintrest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbdailyintrest.Location = new System.Drawing.Point(0, 0);
            this.gbdailyintrest.Name = "gbdailyintrest";
            this.gbdailyintrest.Size = new System.Drawing.Size(649, 335);
            this.gbdailyintrest.TabIndex = 0;
            this.gbdailyintrest.TabStop = false;
            this.gbdailyintrest.Text = "Daily Intrest";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userLoanDetails);
            this.splitContainer1.Size = new System.Drawing.Size(643, 316);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnsave);
            this.splitContainer2.Panel2.Controls.Add(this.txtintrest);
            this.splitContainer2.Panel2.Controls.Add(this.txtloan);
            this.splitContainer2.Panel2.Controls.Add(this.cbAutherized);
            this.splitContainer2.Panel2.Controls.Add(this.cbUser);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer2.Panel2.Controls.Add(this.txtamount);
            this.splitContainer2.Size = new System.Drawing.Size(294, 316);
            this.splitContainer2.SplitterDistance = 105;
            this.splitContainer2.TabIndex = 0;
            // 
            // userLoanDetails
            // 
            this.userLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userLoanDetails.Location = new System.Drawing.Point(2, 8);
            this.userLoanDetails.Name = "userLoanDetails";
            this.userLoanDetails.Size = new System.Drawing.Size(339, 273);
            this.userLoanDetails.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Intrest              :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Loan Number   : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Autherized Person :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Start Data        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Amount            :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "User                 :";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1, 235);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 49;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtintrest
            // 
            this.txtintrest.Location = new System.Drawing.Point(1, 120);
            this.txtintrest.MaxLength = 2;
            this.txtintrest.Name = "txtintrest";
            this.txtintrest.Size = new System.Drawing.Size(181, 20);
            this.txtintrest.TabIndex = 45;
            this.txtintrest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLimit_KeyPress);
            // 
            // txtloan
            // 
            this.txtloan.Location = new System.Drawing.Point(1, 48);
            this.txtloan.Name = "txtloan";
            this.txtloan.ReadOnly = true;
            this.txtloan.Size = new System.Drawing.Size(181, 20);
            this.txtloan.TabIndex = 48;
            // 
            // cbAutherized
            // 
            this.cbAutherized.FormattingEnabled = true;
            this.cbAutherized.Location = new System.Drawing.Point(1, 83);
            this.cbAutherized.Name = "cbAutherized";
            this.cbAutherized.Size = new System.Drawing.Size(181, 21);
            this.cbAutherized.TabIndex = 44;
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(1, 8);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(181, 21);
            this.cbUser.TabIndex = 43;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(1, 159);
            this.txtamount.MaxLength = 8;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(181, 20);
            this.txtamount.TabIndex = 46;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLimit_KeyPress);
            // 
            // DailyIntrest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbdailyintrest);
            this.Name = "DailyIntrest";
            this.Size = new System.Drawing.Size(649, 335);
            this.gbdailyintrest.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userLoanDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdailyintrest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtintrest;
        private System.Windows.Forms.TextBox txtloan;
        private System.Windows.Forms.ComboBox cbAutherized;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.DataGridView userLoanDetails;

    }
}
