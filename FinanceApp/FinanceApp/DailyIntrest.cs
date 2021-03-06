﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class DailyIntrest : UserControl
    {
        public FinanceApp.Data.FinanceAppEntities entity = Program.entity;
        public FinanceApp.Data.User user;
        public DailyIntrest()
        {
            InitializeComponent();
            setUserCombo(Data.User.getAllUsers());
            setAuthorized(Data.User.getAllUsers());
            txtloan.Text = Data.Loan.getLoanMaxID().ToString();
        }

        private void setUserCombo(IList<Data.User> users)
        {
            cbUser.DataSource = users;
            cbUser.DisplayMember = "name";
            cbUser.ValueMember = "id";
        }

        private void setAuthorized(IList<Data.User> users)
        {

            cbAutherized.DataSource = users;
            cbAutherized.DisplayMember = "name";
            cbAutherized.ValueMember = "id";
        }

        private void textLimit_KeyPress(object sender, KeyPressEventArgs arg)
        {
            const char Delete = (char)8;
            arg.Handled = !Char.IsDigit(arg.KeyChar) && arg.KeyChar != Delete;
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.User user = (Data.User)((ComboBox)sender).SelectedItem;
            IList<Data.Loan> loans = Data.Loan.getUserLoanDetails(user);
            userLoanDetails.DataSource = loans;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int intrest = txtintrest.Text == "" ? Convert.ToInt32(txtintrest.Text) : 0;
            int amount = txtamount.Text == "" ? Convert.ToInt32(txtamount.Text) : 0;
            int user_id = ((Data.User)cbUser.SelectedItem).id;
            int approved = Convert.ToInt32(cbAutherized.SelectedValue);
            DateTime startdata = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime enddate = DateTime.Now;
            int surety_user_id = Convert.ToInt32(cbAutherized.SelectedValue);
            int authorized_user_id = surety_user_id;
            Data.Loan.saveLoan(user_id, authorized_user_id, surety_user_id, intrest, amount, true, 1, startdata, enddate);

        }
    }
}
