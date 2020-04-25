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
    public partial class ManageBooks : Form
    {
        public String name;
        public Main main;

        public ManageBooks()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
     
            main.Show();
            this.Hide();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
