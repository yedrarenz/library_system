using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace St_Thomas_AcademyLibrarySystem
{
    public partial class SettingsAuthentication : Form
    {
        public Main main;
        public String pass,user;

        public SettingsAuthentication()
        {
            InitializeComponent();
        }

        private void txtGo_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == pass)
            {
                MessageBox.Show("Success!");
                AuthenticationPanel.Hide();
            }

            else
            {
                MessageBox.Show("Wrong username of password");
            }
        }

    }
}
