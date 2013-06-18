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
    public partial class MainWindow : Form
    {
        UserControl ActiveControl = null;
        RegistrationForm registration = new RegistrationForm();
        DailyIntrest dailyintest = new DailyIntrest();
        public MainWindow()
        {
            InitializeComponent();
            containerpane.Controls.Add(registration);
            containerpane.Controls.Add(dailyintest);
            registration.Hide();
            dailyintest.Hide();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hideActiveControl();
            ActiveControl = registration;
            ActiveControl.Dock = DockStyle.Fill;
            registration.Show();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideActiveControl();
            ActiveControl = registration;
            ActiveControl.Dock = DockStyle.Fill;
            registration.Show();
            registration.showUserDetails();
        }
        private void hideActiveControl()
        {
            if (ActiveControl != null)
            {
                ActiveControl.Hide();
            }
        }

        private void dailyIntrestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hideActiveControl();
            ActiveControl = dailyintest;
            ActiveControl.Dock = DockStyle.Fill;
            dailyintest.Show();
        }
    }
}
