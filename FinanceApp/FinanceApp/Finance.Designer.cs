namespace FinanceApp
{
    partial class Finance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtloannumber = new System.Windows.Forms.TextBox();
            this.cbuser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbautherized = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtintrest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpenddate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtperiod = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.userLoanDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finance";
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
            this.splitContainer1.Size = new System.Drawing.Size(585, 407);
            this.splitContainer1.SplitterDistance = 296;
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
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
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
            this.splitContainer2.Panel2.Controls.Add(this.txtperiod);
            this.splitContainer2.Panel2.Controls.Add(this.dpenddate);
            this.splitContainer2.Panel2.Controls.Add(this.dpstartdate);
            this.splitContainer2.Panel2.Controls.Add(this.txtamount);
            this.splitContainer2.Panel2.Controls.Add(this.txtintrest);
            this.splitContainer2.Panel2.Controls.Add(this.cbautherized);
            this.splitContainer2.Panel2.Controls.Add(this.cbuser);
            this.splitContainer2.Panel2.Controls.Add(this.txtloannumber);
            this.splitContainer2.Size = new System.Drawing.Size(296, 407);
            this.splitContainer2.SplitterDistance = 93;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User                      :";
            // 
            // txtloannumber
            // 
            this.txtloannumber.Location = new System.Drawing.Point(4, 40);
            this.txtloannumber.Name = "txtloannumber";
            this.txtloannumber.ReadOnly = true;
            this.txtloannumber.Size = new System.Drawing.Size(192, 20);
            this.txtloannumber.TabIndex = 0;
            // 
            // cbuser
            // 
            this.cbuser.FormattingEnabled = true;
            this.cbuser.Location = new System.Drawing.Point(4, 13);
            this.cbuser.Name = "cbuser";
            this.cbuser.Size = new System.Drawing.Size(192, 21);
            this.cbuser.TabIndex = 1;
            this.cbuser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loan Number        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autherized Person :";
            // 
            // cbautherized
            // 
            this.cbautherized.FormattingEnabled = true;
            this.cbautherized.Location = new System.Drawing.Point(4, 70);
            this.cbautherized.Name = "cbautherized";
            this.cbautherized.Size = new System.Drawing.Size(192, 21);
            this.cbautherized.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intrest                    :";
            // 
            // txtintrest
            // 
            this.txtintrest.Location = new System.Drawing.Point(4, 103);
            this.txtintrest.MaxLength = 2;
            this.txtintrest.Name = "txtintrest";
            this.txtintrest.Size = new System.Drawing.Size(192, 20);
            this.txtintrest.TabIndex = 3;
            this.txtintrest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount                  :";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(4, 133);
            this.txtamount.MaxLength = 8;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(192, 20);
            this.txtamount.TabIndex = 4;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start Data              :";
            // 
            // dpstartdate
            // 
            this.dpstartdate.Location = new System.Drawing.Point(4, 164);
            this.dpstartdate.Name = "dpstartdate";
            this.dpstartdate.Size = new System.Drawing.Size(192, 20);
            this.dpstartdate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "End Date              :";
            // 
            // dpenddate
            // 
            this.dpenddate.Location = new System.Drawing.Point(4, 199);
            this.dpenddate.Name = "dpenddate";
            this.dpenddate.Size = new System.Drawing.Size(192, 20);
            this.dpenddate.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Period                    :";
            // 
            // txtperiod
            // 
            this.txtperiod.Location = new System.Drawing.Point(4, 231);
            this.txtperiod.MaxLength = 3;
            this.txtperiod.Name = "txtperiod";
            this.txtperiod.Size = new System.Drawing.Size(192, 20);
            this.txtperiod.TabIndex = 7;
            this.txtperiod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(4, 267);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // userLoanDetails
            // 
            this.userLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userLoanDetails.Location = new System.Drawing.Point(3, 3);
            this.userLoanDetails.Name = "userLoanDetails";
            this.userLoanDetails.Size = new System.Drawing.Size(279, 287);
            this.userLoanDetails.TabIndex = 0;
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Finance";
            this.Size = new System.Drawing.Size(591, 426);
            this.groupBox1.ResumeLayout(false);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtperiod;
        private System.Windows.Forms.DateTimePicker dpenddate;
        private System.Windows.Forms.DateTimePicker dpstartdate;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtintrest;
        private System.Windows.Forms.ComboBox cbautherized;
        private System.Windows.Forms.ComboBox cbuser;
        private System.Windows.Forms.TextBox txtloannumber;
        private System.Windows.Forms.DataGridView userLoanDetails;
    }
}
