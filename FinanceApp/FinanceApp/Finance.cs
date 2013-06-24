using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class Finance : UserControl
    {
        public Finance()
        {
            InitializeComponent();
            setUserCombo(Data.User.getAllUsers());
            setAuthorized(Data.User.getAllUsers());
            txtloannumber.Text = Data.Loan.getLoanMaxID().ToString();
        }

        private void setUserCombo(IList<Data.User> users)
        {
            cbuser.DataSource = users;
            cbuser.DisplayMember = "name";
            cbuser.ValueMember = "id";
        }

        private void setAuthorized(IList<Data.User> users)
        {

            cbautherized.DataSource = users;
            cbautherized.DisplayMember = "name";
            cbautherized.ValueMember = "id";
        }

        private void text_KeyPress(object sender, KeyPressEventArgs arg)
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
            int user_id = ((Data.User)cbuser.SelectedItem).id;
            int approved = Convert.ToInt32(cbautherized.SelectedValue);
            DateTime startdata = Convert.ToDateTime(dpstartdate.Value);
            DateTime enddate = Convert.ToDateTime(dpenddate.Value);
            int period = txtperiod.Text == "" ? Convert.ToInt32(txtperiod.Text) : 0;
            int surety_user_id = Convert.ToInt32(cbautherized.SelectedValue);
            int authorized_user_id = surety_user_id;
            Data.Loan.saveLoan(user_id, authorized_user_id, surety_user_id, intrest, amount, true, 2, startdata, enddate, period, enddate);

        }
    }
}
