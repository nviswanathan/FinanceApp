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
    public partial class RegistrationForm : UserControl
    {
        public RegistrationForm()
        {
            InitializeComponent();

        }

        public void Show()
        {
            detailsPanel.Hide();
            splitContainer.Show();
            base.Show();
        }

        public void showUserDetails()
        {
            splitContainer.Hide();
            IList<Data.User> userList = Data.User.getAllUsers();
            setGridData(userList);
            detailsPanel.Show();

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btnregister_Click(object sender, EventArgs e)
        {
            Validate();
            string address = rtxtaddress.Text;
            string email = txtemail.Text;
            string name = txtusername.Text;
            int phone = string.IsNullOrEmpty(txtphonenumber.Text)? 0: Convert.ToInt32(txtphonenumber.Text);
            int income = string.IsNullOrEmpty(txtincome.Text) ? 1 :  Convert.ToInt32(txtincome.Text);
            int limit = string.IsNullOrEmpty(txtlimit.Text) ? 500 : Convert.ToInt32(txtlimit.Text);
            string occupation = txtoccupation.Text;
            Data.User.saveUser(address, name, occupation, phone, income, limit, email);
            splitContainer.Hide();
            detailsPanel.Show();
        }

        private void setGridData(IList<Data.User> users){
            
            BindingSource binding = new BindingSource();
            binding.DataSource = users;
            dguserdetails.DataSource = binding;
        
        }
    }
}
