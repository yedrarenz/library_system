using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace St_Thomas_AcademyLibrarySystem
{
    public partial class BorrowedHistory : Form
    {
        public BorrowedHistory()
        {
            InitializeComponent();
        }

        public Main mm;

        public void borrowedBooks()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

                cn.Open();

                String query = "SELECT tblStudentList.LibraryID, tblStudentList.StudentName, tblStudentList.ContactNumber, tblStudentList.Address, tblStudentList.Year, tblStudentList.Section, tblBorrow.BookTitle, tblBorrow.Author, tblBorrow.DateBorrowed, tblBorrow.DueDate, tblBorrow.DateReturned, tblBorrow.Returned FROM tblStudentList LEFT JOIN tblBorrow ON tblStudentList.LibraryID = tblBorrow.LibraryID WHERE Returned = 'Yes' ";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBorrowedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BorrowedHistory_Load(object sender, EventArgs e)
        {
            borrowedBooks();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mm = new Main();
            mm.Show();
            this.Hide();
        }

        private void BorrowedHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to close history?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    mm = new Main();
            //    mm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
