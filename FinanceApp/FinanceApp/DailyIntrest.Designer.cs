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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutherized = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtloan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtintrest = new System.Windows.Forms.TextBox();
            this.userLoanDetails = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userLoanDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User                 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount            :";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(129, 188);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(181, 20);
            this.txtamount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Data        :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(129, 37);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(181, 21);
            this.cbUser.TabIndex = 6;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Autherized Person :";
            // 
            // cbAutherized
            // 
            this.cbAutherized.FormattingEnabled = true;
            this.cbAutherized.Location = new System.Drawing.Point(129, 112);
            this.cbAutherized.Name = "cbAutherized";
            this.cbAutherized.Size = new System.Drawing.Size(181, 21);
            this.cbAutherized.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loan Number   : ";
            // 
            // txtloan
            // 
            this.txtloan.Location = new System.Drawing.Point(129, 77);
            this.txtloan.Name = "txtloan";
            this.txtloan.ReadOnly = true;
            this.txtloan.Size = new System.Drawing.Size(181, 20);
            this.txtloan.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Intrest              :";
            // 
            // txtintrest
            // 
            this.txtintrest.Location = new System.Drawing.Point(129, 149);
            this.txtintrest.Name = "txtintrest";
            this.txtintrest.Size = new System.Drawing.Size(181, 20);
            this.txtintrest.TabIndex = 12;
            // 
            // userLoanDetails
            // 
            this.userLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userLoanDetails.Location = new System.Drawing.Point(328, 37);
            this.userLoanDetails.Name = "userLoanDetails";
            this.userLoanDetails.Size = new System.Drawing.Size(298, 201);
            this.userLoanDetails.TabIndex = 13;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(129, 264);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // DailyIntrest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.userLoanDetails);
            this.Controls.Add(this.txtintrest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtloan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAutherized);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DailyIntrest";
            this.Size = new System.Drawing.Size(649, 335);
            ((System.ComponentModel.ISupportInitialize)(this.userLoanDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAutherized;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtloan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtintrest;
        private System.Windows.Forms.DataGridView userLoanDetails;
        private System.Windows.Forms.Button btnsave;
    }
}
