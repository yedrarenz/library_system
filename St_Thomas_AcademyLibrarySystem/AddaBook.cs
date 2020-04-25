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
    public partial class AddaBook : Form
    {
        public AddaBook()
        {
            InitializeComponent();
        }

        public String name;
        public Main main;
        public String Bookid;
        SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

        public void bookList()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

                cn.Open();

                String query = "SELECT * FROM tblBookList";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAddBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Author" || txtBooktitle.Text == "Book Title" || txtCategory.Text == "Category" || txtDatePublished.Text == "Date Published" || txtLexileLevel.Text == "Lexile Level" || txtISBN.Text == "ISBN" || txtPublisher.Text == "Publisher")
            {
                MessageBox.Show("Please enter the valid information of the book.");
            }
            else if (txtAuthor.Text == "" || txtBooktitle.Text == "" || txtCategory.Text == "" || txtDatePublished.Text == "" || txtLexileLevel.Text == "" || txtISBN.Text == "" || txtPublisher.Text == "")
            {
                MessageBox.Show("Please complete all fields.");
            }
            else
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into tblBookList (BookTitle, Author, Publisher, LexileLevel, Category, DatePublished, ISBN) values ('" + txtBooktitle.Text + "','" + txtAuthor.Text + "','" + txtPublisher.Text + "','" + txtLexileLevel.Text + "','" + txtCategory.Text + "','" + txtDatePublished.Text + "','" + txtISBN.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book successfully Added");

                    bookList();

                    txtAuthor.ResetText();
                    txtBooktitle.ResetText();
                    txtCategory.ResetText();
                    txtDatePublished.ResetText();
                    txtLexileLevel.ResetText();
                    txtISBN.ResetText();
                    txtPublisher.ResetText();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void AddaBook_Load(object sender, EventArgs e)
        {                        
            bookList();       
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();
            this.Hide();
        }

        #region Textbox Events
        private void txtBooktitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBooktitle.ReadOnly = false;
            if (txtBooktitle.Text == "Book Title")
            {
                txtBooktitle.Text = "";
            }
        }

        private void txtBooktitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBooktitle.Text == "")
            {
                txtBooktitle.Text = "Book Title";
            }
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAuthor.ReadOnly = false;
            if (txtAuthor.Text == "Author")
            {
                txtAuthor.Text = "";
            }
        }

        private void txtPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPublisher.ReadOnly = false;
            if (txtPublisher.Text == "Publisher")
            {
                txtPublisher.Text = "";
            }
        }

        private void txtLexileLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLexileLevel.ReadOnly = false;
            if (txtLexileLevel.Text == "Lexile Level")
            {
                txtLexileLevel.Text = "";
            }
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCategory.ReadOnly = false;
            if (txtCategory.Text == "Category")
            {
                txtCategory.Text = "";
            }
        }

        private void txtDatePublished_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////txtDatePublished.ReadOnly = false;
            //if (txtDatePublished.Text == "Date Published")
            //{
            //    txtDatePublished.Text = "";
            //}
        }

        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtISBN.ReadOnly = false;
            if (txtISBN.Text == "Pages")
            {
                txtISBN.Text = "";
            }
        }

        private void txtAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAuthor.Text == "")
            {
                txtAuthor.Text = "Author";
            }
        }

        private void txtPublisher_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPublisher.Text == "")
            {
                txtPublisher.Text = "Publisher";
            }
        }

        private void txtLexileLevel_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLexileLevel.Text == "")
            {
                txtLexileLevel.Text = "Lexile Level";
            }
        }

        private void txtCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCategory.Text == "")
            {
                txtCategory.Text = "Category";
            }
        }

        private void txtDatePublished_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDatePublished.Text == "")
            {
                txtDatePublished.Text = "Date Published";
            }
        }

        private void txtPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtISBN.Text == "")
            {
                txtISBN.Text = "Pages";
            }
        }

        //private void txtBooktitle_Enter(object sender, EventArgs e)
        //{
        //    txtBooktitle.SelectionStart = 0;
        //    txtBooktitle.ReadOnly = true;
        //}

        private void txtBooktitle_MouseClick(object sender, MouseEventArgs e)
        {
            txtBooktitle.SelectionStart = 0;
            txtBooktitle.ReadOnly = true;

            if (txtBooktitle.Text == "Book Title")
            {
                txtBooktitle.SelectionStart = 0;
            }
        }

        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            txtAuthor.SelectionStart = 0;
            txtAuthor.ReadOnly = true;
        }

        private void txtPublisher_Enter(object sender, EventArgs e)
        {
            txtPublisher.SelectionStart = 0;
            txtPublisher.ReadOnly = true;
        }

        private void txtLexileLevel_Enter(object sender, EventArgs e)
        {
            txtLexileLevel.SelectionStart = 0;
            txtLexileLevel.ReadOnly = true;
        }

        private void txtCategory_Enter(object sender, EventArgs e)
        {
            txtCategory.SelectionStart = 0;
            txtCategory.ReadOnly = true;
        }

        private void txtDatePublished_Enter(object sender, EventArgs e)
        {
            txtDatePublished.SelectionStart = 0;
            txtDatePublished.ReadOnly = true;
        }

        private void txtPages_Enter(object sender, EventArgs e)
        {
            txtISBN.SelectionStart = 0;
            txtISBN.ReadOnly = true;
        }

        private void txtAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAuthor.Text == "Author")
            {
                txtAuthor.SelectionStart = 0;
            }
        }

        private void txtPublisher_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPublisher.Text == "Publisher")
            {
                txtPublisher.SelectionStart = 0;
            }
        }

        private void txtLexileLevel_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLexileLevel.Text == "Lexile Level")
            {
                txtLexileLevel.SelectionStart = 0;
            }
        }

        private void txtCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCategory.Text == "Category")
            {
                txtCategory.SelectionStart = 0;
            }
        }

        private void txtDatePublished_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDatePublished.Text == "Date Published")
            {
                txtDatePublished.SelectionStart = 0;
            }
        }

        private void txtPages_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtISBN.Text == "Pages")
            {
                txtISBN.SelectionStart = 0;
            }
        }
        #endregion

        private void AddaBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void dgvAddBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                

                txtBooktitle.Text = dgvAddBooks.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();
                txtCategory.Text = dgvAddBooks.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                txtDatePublished.Text = dgvAddBooks.Rows[e.RowIndex].Cells["DatePublished"].Value.ToString();
                txtISBN.Text = dgvAddBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                txtLexileLevel.Text = dgvAddBooks.Rows[e.RowIndex].Cells["LexileLevel"].Value.ToString();
                txtPublisher.Text = dgvAddBooks.Rows[e.RowIndex].Cells["Publisher"].Value.ToString();
                txtAuthor.Text = dgvAddBooks.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                Bookid = dgvAddBooks.Rows[e.RowIndex].Cells["BookID"].Value.ToString();

                #region Validation
                if (txtAuthor.Text == "")
                {
                    txtAuthor.Text = "Author";
                }
                if (txtBooktitle.Text == "")
                {
                    txtBooktitle.Text = "Book Title";
                }
                if (txtCategory.Text == "")
                {
                    txtCategory.Text = "Category";
                }
                if (txtDatePublished.Text == "")
                {
                    txtDatePublished.Text = "Date Published";
                }
                if (txtISBN.Text == "")
                {
                    txtISBN.Text = "ISBN";
                }
                if (txtLexileLevel.Text == "")
                {
                    txtLexileLevel.Text = "Lexile Level";
                }
                if (txtPublisher.Text == "")
                {
                    txtPublisher.Text = "Publisher";
                }
                if (txtAuthor.Text == "")
                {
                    txtAuthor.Text = "Author";
                }
                #endregion //Validation

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datePublished_ValueChanged(object sender, EventArgs e)
        {
            txtDatePublished.Text = datePublished.Value.ToString("MMMM dd, yyyy");
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAuthor.Text == "Author" || txtBooktitle.Text == "Book Title" || txtCategory.Text == "Category" || txtDatePublished.Text == "Date Published" || txtLexileLevel.Text == "Lexile Level" || txtISBN.Text == "ISBN" || txtPublisher.Text == "Publisher")
                {
                    MessageBox.Show("Please enter the valid information of the book.");
                }
                else if (txtAuthor.Text == "" || txtBooktitle.Text == "" || txtCategory.Text == "" || txtDatePublished.Text == "" || txtLexileLevel.Text == "" || txtISBN.Text == "" || txtPublisher.Text == "")
                {
                    MessageBox.Show("Please complete all fields.");
                }
                else
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tblBookList SET Author = '" + txtAuthor.Text + "', BookTitle = '" + txtBooktitle.Text + "', Category = '" + txtCategory.Text + "', DatePublished = '" + txtDatePublished.Text + "', LexileLevel = '" + txtLexileLevel.Text + "', ISBN = '" + txtISBN.Text + "', Publisher = '" + txtPublisher.Text + "' WHERE BookId = '" + Bookid + "' ", cn);
                    cmd.ExecuteNonQuery();

                    bookList();

                    MessageBox.Show("Book Successfully Updated");

                    txtAuthor.ResetText();
                    txtBooktitle.ResetText();
                    txtCategory.ResetText();
                    txtDatePublished.ResetText();
                    txtLexileLevel.ResetText();
                    txtISBN.ResetText();
                    txtPublisher.ResetText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void search()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

                cn.Open();

                if (txtSearch.Text == "")
                {
                    String query = "SELECT * FROM tblBookList";

                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAddBooks.DataSource = dt;
                }

                else
                {
                    String query = "SELECT * FROM tblBookList WHERE BookID LIKE  '%" + txtSearch.Text + "%' OR BookTitle LIKE '%" + txtSearch.Text + "%' OR Author LIKE '%" + txtSearch.Text + "%' OR Publisher LIKE '%" + txtSearch.Text + "%' OR LexileLevel LIKE '%" + txtSearch.Text + "%' OR Category LIKE '%" + txtSearch.Text + "%' OR DatePublished LIKE '%" + txtSearch.Text + "%' OR ISBN LIKE '%" + txtSearch.Text + "%' ";

                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAddBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

    }
}
