using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using xDialog;


namespace St_Thomas_AcademyLibrarySystem
{
    public partial class Login : Form
    {


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public DatabaseConnection dc = new DatabaseConnection();

        public Main n;
        public String name;
        public String pass;

        public Login()
        {
            InitializeComponent();
        }

        public void enterMain()
        {


            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM tbllogin WHERE Username = '" + txtUsername.Text + "'AND Password = '" + txtPassword.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    n = new Main();
                    DialogResult result = CustomMessageBox.Show("Welcome to St. Thomas Academy Library Management System.", "Welcome", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Search, CustomMessageBox.AnimateStyle.FadeIn);
                    name = txtUsername.Text;
                    pass = txtPassword.Text;

                    n.pass = pass;
                    n.txtName.Text = name;
                    n.name = name;
                    n.loginform = this;
                    //n.FormClosing -= Login_FormClosing;
                    n.Show();

                    //   cn.Close();
                    this.Hide();
                }
                else
                {

                    DialogResult result = CustomMessageBox.Show("Wrong username or password!", "Incorrect", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Search, CustomMessageBox.AnimateStyle.FadeIn);
                                        //   cn.Close();
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            enterMain();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;

                enterMain();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Are you sure you want to quit?", "Quit", CustomMessageBox.Buttons.YesNo, CustomMessageBox.Icon.Question, CustomMessageBox.AnimateStyle.FadeIn);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }         
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {          
            if (txtUsername.Text == "Username")
            {
                txtUsername.SelectionStart = 0;
                txtUsername.ReadOnly = true;
            }
        }


        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsername.ReadOnly = false;
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        //Text Password
          
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {     
            if (txtPassword.Text == "Username")
            {
                txtPassword.SelectionStart = 0;
                txtPassword.ReadOnly = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.ReadOnly = false;
            if (txtPassword.Text == "Username")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Username";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

        }
    }
}
