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
    public partial class DailyIntrest : UserControl
    {
        public FinanceApp.Data.FinanceAppEntities entity = Program.entity;
        public FinanceApp.Data.User user;
        public DailyIntrest()
        {
            InitializeComponent();
            setUserCombo(getUsers());
            setAuthorized(getUsers());
            txtloan.Text = getLoanMax().ToString();
        }

        private int getLoanMax()
        {
            Data.Loan loan= entity.Loans.OrderByDescending(u => u.id).FirstOrDefault();
            if (loan != null)
            {
                return loan.id;
            }
            return 0;
        }
        private IList<Data.User> getUsers()
        {
            IList<Data.User> list;
            var users = from user in entity.Users
                        select user;
            list = users.ToList<Data.User>();
            return list;
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

        private IList<Data.Loan> getUserLoanDetails(Data.User user)
        {
            IList<Data.Loan> loans;
            var loanquery = from loan in entity.Loans
                            where loan.user_id == user.id
                            select loan;
            loans = loanquery.ToList<Data.Loan>();
            return loans;
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.User user = (Data.User)((ComboBox)sender).SelectedItem;
            IList<Data.Loan> loans = getUserLoanDetails(user);
            userLoanDetails.DataSource = loans;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Data.Loan loan = new Data.Loan();
            loan.intrest = Convert.ToInt32(txtintrest.Text);
            loan.amoutn = Convert.ToInt32(txtamount.Text);
            loan.status = true;
            loan.User = (Data.User)cbUser.SelectedItem;
            loan.approved = Convert.ToInt32(cbAutherized.SelectedValue);

        }
    }
}
