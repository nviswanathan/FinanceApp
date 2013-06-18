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
        public FinanceApp.Data.FinanceAppEntities entity = Program.entity;
        public FinanceApp.Data.Address adds;
        public FinanceApp.Data.User user;
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
            var users = from user in entity.Users
                                    select user;
            IList<Data.User> courseList = users.ToList<Data.User>();
            setGridData(courseList);
            detailsPanel.Show();

        }
        private void btncancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Validate();
            adds = new Data.Address();
            user = new Data.User();
            adds.address1 = rtxtaddress.Text;
            entity.AddToAddresses(adds);
            user.name = txtusername.Text;
            user.occupation = txtoccupation.Text;
            if (!string.IsNullOrEmpty(txtphonenumber.Text) )
            {
                user.phone = Convert.ToInt32(txtphonenumber.Text);
            }
            user.presentaddr = adds.id;
            user.permenentaddr = adds.id;
            if (!string.IsNullOrEmpty(txtincome.Text))
            {
                user.income = Convert.ToInt32(txtincome.Text);
            }
            if (!string.IsNullOrEmpty(txtlimit.Text))
            {
                user.limit = Convert.ToInt32(txtlimit.Text);
            }
            user.email = txtemail.Text;
            user.role = "user";
            entity.AddToUsers(user);
            entity.SaveChanges();
            splitContainer.Hide();
            IList<Data.User> source = new List<Data.User>();
            source.Add(user);
            setGridData(source);
            detailsPanel.Show();
        }

        private void setGridData(IList<Data.User> users){
            
            BindingSource binding = new BindingSource();
            binding.DataSource = users;
            dguserdetails.DataSource = binding;
        
        }
    }
}
