using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using xDialog;
using System.Runtime.InteropServices;

namespace St_Thomas_AcademyLibrarySystem
{
    public partial class Main : Form
    {

        public Login loginform = new Login();
        public String name,pass;
        public ManageBooks mb;
        public SettingsAuthentication san;
        public BorrowBook bb;
        public ReturnBook rb;
        public AddStudent addS;
        public AddaBook addB;

        public Main()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pbBorrow_Click(object sender, EventArgs e)
        {
            bb = new BorrowBook();
            bb.name = name;
            bb.main = this;
            bb.Show();
            this.Hide();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            rb = new ReturnBook();
            rb.name = name;
            rb.main = this;
            rb.Show();
            this.Hide();
        }

        //private void pbAddBook_Click(object sender, EventArgs e)
        //{
        //    addB = new AddaBook();
        //    addB.name = name;
        //    addB.main = this;
        //    addB.Show();
        //    this.Hide();
        //}

        //private void pbStudent_Click(object sender, EventArgs e)
        //{
        //    addS = new AddStudent();
        //    addS.name = name;
        //    addS.main = this;
        //    addS.Show();
        //    this.Hide();
        //}

        private void pbBookList_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            san = new SettingsAuthentication();
            san.pass = pass;
            san.user = name;
            san.main = this;
            san.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult result = CustomMessageBox.Show("Are you sure you want to logout?", "Logout", CustomMessageBox.Buttons.YesNo, CustomMessageBox.Icon.Question, CustomMessageBox.AnimateStyle.FadeIn);
            if (result == DialogResult.Yes)
            {
                loginform.Show();
                loginform.txtUsername.Text = "Username";
                loginform.txtPassword.Text = "Password";
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Are you sure you want to logout?", "Logout", CustomMessageBox.Buttons.YesNo, CustomMessageBox.Icon.Question, CustomMessageBox.AnimateStyle.FadeIn);
            if (result == DialogResult.Yes)
            {
                loginform.Show();
                loginform.txtUsername.Text = "Username";
                loginform.txtPassword.Text = "Password";
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void pcbBooks_MouseHover(object sender, EventArgs e)
        {
            pcbBooks.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redBooks;
        }

        private void pcbStudents_MouseHover(object sender, EventArgs e)
        {
            pcbStudents.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redStudents;
        }

        private void pcbTransactions_MouseHover(object sender, EventArgs e)
        {
            pcbTransactions.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redTransactions;
            TransactionsPanel.Visible = true;
        }

        private void pcbReports_MouseHover(object sender, EventArgs e)
        {
            pcbReports.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redReports;
        }

        private void pcbBooks_MouseLeave(object sender, EventArgs e)
        {
            pcbBooks.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaBook1;
        }

        private void pcbStudents_MouseLeave(object sender, EventArgs e)
        {
            pcbStudents.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaStudents;
        }

        private void pcbTransactions_MouseLeave(object sender, EventArgs e)
        {
            //pcbTransactions.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaTransactions;
            //pbBorrow.Visible = false;
            //pbReturn.Visible = false;
        }

        private void pcbReports_MouseLeave(object sender, EventArgs e)
        {
            pcbReports.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaReports;
        }

        private void pcbBooks_Click(object sender, EventArgs e)
        {
            addB = new AddaBook();
            addB.name = name;
            addB.main = this;
            addB.Show();
            this.Hide();
        }

        private void pcbStudents_Click(object sender, EventArgs e)
        {
            addS = new AddStudent();
            addS.name = name;
            addS.main = this;
            addS.Show();
            this.Hide();

        }

        private void pbBorrow_MouseHover(object sender, EventArgs e)
        {
            pbBorrow.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redBorrow;
        }

        private void pbReturn_MouseHover(object sender, EventArgs e)
        {
            pbReturn.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redReturn;
        }          
        private void pbBorrow_MouseLeave_1(object sender, EventArgs e)
        {
            pbBorrow.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaBorrow;
        }

        private void pbReturn_MouseLeave_1(object sender, EventArgs e)
        {
            pbReturn.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaReturn;
        }

        private void TransactionsPanel_MouseLeave(object sender, EventArgs e)
        {
            TransactionsPanel.Visible = false;
            pcbTransactions.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaTransactions;
        }

        private void TransactionsPanel_MouseHover(object sender, EventArgs e)
        {
            pcbTransactions.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.redTransactions;
        }

        //private void pbBorrow_MouseLeave_1(object sender, EventArgs e)
        //{
        //    pbBorrow.Visible = false;
        //    pbReturn.Visible = false;
        //    pcbTransactions.Image = St_Thomas_AcademyLibrarySystem.Properties.Resources.transpaTransactions;
        //}

    }
}
