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
            IList<LoanData> loanData = LoanData.getUserLoan(user);
            userLoanDetails.DataSource = loanData;
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
    public class LoanData
    {
        //public int user_id { get; set; }
        [System.ComponentModel.DisplayName("User Name")]
        public string userName { get; set; }
        [System.ComponentModel.DisplayName("Loan Number")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("Loan Type")]
        public string loanType { get; set; }
        [System.ComponentModel.DisplayName("Amount")]
        public int amount { get; set; }
        [System.ComponentModel.DisplayName("Interst")]
        public int intrest { get; set; }

        public static IList<LoanData> getUserLoan(Data.User user)
        {
            IList<LoanData> loanDatas = new List<LoanData>();
            IList<Data.Loan> loans = Data.Loan.getUserLoanDetails(user);
            foreach (var loan in loans)
            {
                LoanData data = new LoanData();
                data.id = loan.id;
                data.intrest = loan.intrest;
                //data.user_id = loan.user_id;
                data.userName = loan.User.name;
                data.loanType = loan.LoanType.typename;
                loanDatas.Add(data);
            }
            return loanDatas;
        }
    }
}
