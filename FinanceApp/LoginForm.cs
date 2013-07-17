using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            checklogin();
        }

        private void passwordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checklogin();
            }
        }

        private void checklogin()
        {
            if (usernametxt.Text == "" || passwordtxt.Text == "")
            {
                lblerrormessage.Text = "Check your user name & password";
            }
            else if (usernametxt.Text == "Admin" && passwordtxt.Text == "admin")
            {

                lblerrormessage.Text = "Loged in successfully.";
                var app = new MainWindow();
                app.Show();
                app.FormClosed += new System.Windows.Forms.FormClosedEventHandler(closeApp);
                Hide();
                //app.Show();
                //this.Close();
                //this.Close();
            }
            else
            {
                this.lblerrormessage.Text = "Check your user name & password";
            }
        }

        private void closeApp(object sender, FormClosedEventArgs e) {
            Close();
        }
    }
}
