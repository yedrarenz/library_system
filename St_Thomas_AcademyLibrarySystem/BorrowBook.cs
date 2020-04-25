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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        public String timenow;
        public String timereturned;


        public Main mm;

        public String name;
        public Main main;

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

                dgvBookList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            bookList();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True; MultipleActiveResultSets=True");
            cn.Open();

            //try
            //{
                SqlCommand cd = new SqlCommand("SELECT LibraryID, BookBorrowed FROM tblStudentList WHERE LibraryID = '" + txtLibraryID.Text + "'", cn);

                SqlDataReader dr = cd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        lblQty.Text = dr["BookBorrowed"].ToString();

                        int temp = Int32.Parse(lblQty.Text);

                        if (temp == 0)
                        {
                            MessageBox.Show("The student exceed the amount of books to borrowed!");
                        }

                        else if (txtBookTitle.Text == "" || txtLibraryID.Text == "")
                        {
                            MessageBox.Show("Please enter student library id or the book title!");
                        }

                        else
                        {

                            SqlCommand scmd = new SqlCommand("SELECT Quantity FROM tblBookList WHERE BookTitle = '" + txtBookTitle.Text + "'", cn);
                            SqlDataReader dtr = scmd.ExecuteReader();

                            while (dtr.Read())
                            {

                                txtQuantity.Text = dtr["Quantity"].ToString();
                                int qty = Int32.Parse(txtQuantity.Text);


                                if (qty == 0)
                                {
                                    MessageBox.Show("nasa pahiraman pa yung book");
                                }

                                else
                                {
                                    DayOfWeek day = DateTime.Now.DayOfWeek;
                                    DayOfWeek friday = DayOfWeek.Friday;
                                    DayOfWeek thursday = DayOfWeek.Thursday;
                                    //KAPAG FRIDAY + 3
                                    if (day == friday)
                                    {                                      
                                        qty = qty - 1;

                                        SqlCommand cmdBookList = new SqlCommand("UPDATE tblBookList SET Quantity = ('" + qty + "') WHERE BookTitle = '" + txtBookTitle.Text + "'", cn);
                                        

                                        temp = temp - 1;
                                        SqlCommand cdr = new SqlCommand("UPDATE tblStudentList SET BookBorrowed = ('" + temp + "') WHERE LibraryID = '" + txtLibraryID.Text + "'", cn);


                                        String[] split = DateTime.Now.ToString("MMMM dd, yyyy").Split(' ');
                                        String dueDate = DateTime.Now.AddDays(3).ToString("MMMM dd, yyyy");


                                        SqlCommand cm = new SqlCommand("INSERT INTO tblBorrow (BookID, LibraryID, BookTitle, Author, DateBorrowed, DueDate, Returned) VALUES('" + lblBookID.Text + "','" + txtLibraryID.Text + "', '" + lblBookTitle.Text + "', '" + lblAuthor.Text + "', '" + DateTime.Now.ToString("MMMM dd, yyyy") + "', '" + dueDate + "', '" + "No" + "')", cn);
                                        cm.ExecuteNonQuery();
                                        cmdBookList.ExecuteNonQuery();
                                        cdr.ExecuteNonQuery();


                                        MessageBox.Show("Borrowed!");
                                        bookList();
                                        txtBookTitle.ResetText();
                                        txtLibraryID.ResetText();
                                    }
                                    //KAPAG THURSDAY!
                                    else if (day == thursday)
                                    {
                                        qty = qty - 1;

                                        SqlCommand cmdBookList = new SqlCommand("UPDATE tblBookList SET Quantity = ('" + qty + "') WHERE BookTitle = '" + txtBookTitle.Text + "'", cn);


                                        temp = temp - 1;
                                        SqlCommand cdr = new SqlCommand("UPDATE tblStudentList SET BookBorrowed = ('" + temp + "') WHERE LibraryID = '" + txtLibraryID.Text + "'", cn);


                                        String[] split = DateTime.Now.ToString("MMMM dd, yyyy").Split(' ');
                                        String dueDate = DateTime.Now.AddDays(4).ToString("MMMM dd, yyyy");


                                        SqlCommand cm = new SqlCommand("INSERT INTO tblBorrow (BookID, LibraryID, BookTitle, Author, DateBorrowed, DueDate, Returned) VALUES('" + lblBookID.Text + "','" + txtLibraryID.Text + "', '" + lblBookTitle.Text + "', '" + lblAuthor.Text + "', '" + DateTime.Now.ToString("MMMM dd, yyyy") + "', '" + dueDate + "', '" + "No" + "')", cn);
                                        cm.ExecuteNonQuery();
                                        cmdBookList.ExecuteNonQuery();
                                        cdr.ExecuteNonQuery();


                                        MessageBox.Show("Borrowed!");
                                        bookList();
                                        txtBookTitle.ResetText();
                                        txtLibraryID.ResetText();

                                    }

                                    else
                                    {
                                        //HINDI FRIDAY!
                                        qty = qty - 1;

                                        SqlCommand cmdBookList = new SqlCommand("UPDATE tblBookList SET Quantity = ('" + qty + "') WHERE BookTitle = '" + txtBookTitle.Text + "'", cn);
                                        

                                        temp = temp - 1;
                                        SqlCommand cdr = new SqlCommand("UPDATE tblStudentList SET BookBorrowed = ('" + temp + "') WHERE LibraryID = '" + txtLibraryID.Text + "'", cn);
                                        

                                        String[] split = DateTime.Now.ToString("MMMM dd, yyyy").Split(' ');
                                        String dueDate = DateTime.Now.AddDays(2).ToString("MMMM dd, yyyy"); 

                                        timenow = DateTime.Now.ToString("hh:mm tt");


                                        SqlCommand notFri = new SqlCommand("INSERT INTO tblBorrow (BookID, LibraryID, BookTitle, Author, DateBorrowed, DueDate, Returned) VALUES('" + lblBookID.Text + "','" + txtLibraryID.Text + "', '" + lblBookTitle.Text + "', '" + lblAuthor.Text + "', '" + DateTime.Now.ToString("MMMM dd, yyyy") + " " + timenow + "', '" + dueDate + "', '" + "No" + "')", cn);
                                        notFri.ExecuteNonQuery();
                                        cmdBookList.ExecuteNonQuery();
                                        cdr.ExecuteNonQuery();

                                        MessageBox.Show("Borrowed!");
                                        bookList();
                                        txtBookTitle.ResetText();
                                        txtLibraryID.ResetText();
                                    }
                                }

                            }

                        }
                    }

                }


                else
                {
                    MessageBox.Show("Student doesn't exist!");

                }

            //}

            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.Message);
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mm = new Main();
            mm.Show();
            this.Hide();
        }

        private void BorrowBook_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvBookList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                lblBookID.Text = dgvBookList.Rows[e.RowIndex].Cells["BookID"].Value.ToString();
                txtBookTitle.Text = dgvBookList.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();
                lblBookTitle.Text = dgvBookList.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();
                lblAuthor.Text = dgvBookList.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                lblPublisher.Text = dgvBookList.Rows[e.RowIndex].Cells["Publisher"].Value.ToString();
                lblLexileLevel.Text = dgvBookList.Rows[e.RowIndex].Cells["LexileLevel"].Value.ToString();
                lblCategory.Text = dgvBookList.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                lblDatePublished.Text = dgvBookList.Rows[e.RowIndex].Cells["DatePublished"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();           
        }

        public void Search()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

                cn.Open();

                if (txtSearch.Text == "")
                {
                    txtSearchedID.Text = "";
                }

                else
                {
                    String query = "SELECT LibraryID FROM tblStudentList WHERE StudentName LIKE  '%" + txtSearch.Text + "%'";


                    SqlCommand scmd = new SqlCommand(query, cn);
                    SqlDataReader dr = scmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtSearchedID.Text = dr["LibraryID"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
