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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        public String name;
        public Main main;
        public BorrowedHistory bh;
        
        public void showBorrowers()
        {
            //try
            //{
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

                cn.Open();

                String query = "SELECT tblStudentList.LibraryID, tblStudentList.StudentName, tblStudentList.ContactNumber, tblStudentList.Address, tblStudentList.Year, tblStudentList.Section, tblBorrow.BookTitle, tblBorrow.Author, tblBorrow.DateBorrowed, tblBorrow.DueDate AS 'Due Date', tblBorrow.Returned, tblBorrow.ID FROM tblStudentList LEFT JOIN tblBorrow ON tblStudentList.LibraryID = tblBorrow.LibraryID WHERE Returned = 'No' ";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBorrowers.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            showBorrowers();
            penalty();
        }


        public void penalty()
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True; MultipleActiveResultSets=True");
            cn.Open();

            SqlCommand penalty = new SqlCommand("SELECT Penalty FROM tblStudentList WHERE LibraryID = '" + lblLibraryID.Text + "'", cn);
            SqlDataReader penaltyReader = penalty.ExecuteReader();


            SqlCommand scs = new SqlCommand("SELECT DueDate FROM tblBorrow WHERE LibraryID = '" + lblLibraryID.Text  + "'",cn);
            penaltyReader = scs.ExecuteReader();

            while (penaltyReader.Read())
            {
                String dateReturned = penaltyReader["DueDate"].ToString();
                String[] split = dateReturned.Replace(",", "").Split(' ');
                int dateToReturned = Int32.Parse(split[1]);
                int dateToday = Int32.Parse(DateTime.Now.ToString("dd"));


                if (dateToday == 30 || dateToday == 31)
                {
                    if (dateToReturned < dateToday)
                    {
                        //Do Something..
                        while (penaltyReader.Read())
                        {
                            String temp = penaltyReader["Penalty"].ToString();
                            int penaltyTemp = Int32.Parse(temp);

                            if (penaltyTemp == 20)
                            {
                                penalty = new SqlCommand("UPDATE tblStudentList SET Remarks = '" + "Need to call the guardian." + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
                                penalty.ExecuteNonQuery();
                            }
                            else
                            {
                                penaltyTemp += 10;

                                penalty = new SqlCommand("UPDATE tblStudentList SET Penalty = '" + penaltyTemp + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
                                penalty.ExecuteNonQuery();
                            }

                        }
                    }
                }

                else if (dateToReturned < dateToday)
                {
                    while (penaltyReader.Read())
                    {
                        String temp = penaltyReader["Penalty"].ToString();
                        int penaltyTemp = Int32.Parse(temp);

                        if (penaltyTemp == 20)
                        {
                            penalty = new SqlCommand("UPDATE tblStudentList SET Remarks = '" + "Need to call the guardian." + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
                            penalty.ExecuteNonQuery();
                        }
                        else
                        {
                            penaltyTemp += 10;

                            penalty = new SqlCommand("UPDATE tblStudentList SET Penalty = '" + penaltyTemp + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
                            penalty.ExecuteNonQuery();
                        }

                    }                  
                }

               
            }
            //SqlCommand select = new SqlCommand("SELECT * FROM tblBorrow WHERE LibraryID = '" + lblLibraryID.Text + "' ",cn);
            //SqlDataReader drr = select.ExecuteReader();

            //    while (drr.Read())
            //    {
            //        lblDateReturned.Text = drr["DueDate"].ToString() + " " + DateTime.Now.ToString("hh:mm tt");

            //        String[] split = lblDateReturned.Text.Replace(",", "").Split(' ');
            //        int dateToReturned = Int32.Parse(split[1]);

            //        int dateToday = Int32.Parse(DateTime.Now.ToString("dd"));

            //        if (dateToday == 30 || dateToday == 31)
            //        {
            //            select = new SqlCommand("SELECT Penalty FROM tblStudentList WHERE LibraryID = '" + lblLibraryID.Text + "' ",cn);
            //            drr = select.ExecuteReader();

            //            while (drr.Read())
            //            {
            //                String penalty = drr["Penalty"].ToString();
            //                int tmpPenalty = Int32.Parse(penalty);

            //                tmpPenalty += 10;
            //                select = new SqlCommand("UPDATE tblStudentList SET Penalty = '" + tmpPenalty.ToString() + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ",cn);
            //                select.ExecuteNonQuery();
            //            }                                               
            //        }


            //        else if (dateToday > dateToReturned)
            //        {
            //            select = new SqlCommand("SELECT Penalty FROM tblStudentList WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
            //            drr = select.ExecuteReader();

            //            while (drr.Read())
            //            {
            //                String penalty = drr["Penalty"].ToString();
            //                int tmpPenalty = Int32.Parse(penalty);

            //                tmpPenalty += 10;
            //                select = new SqlCommand("UPDATE tblStudentList SET Penalty = '" + tmpPenalty.ToString() + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
            //                select.ExecuteNonQuery();
            //            }
            //        }
                   
            //    }

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True; MultipleActiveResultSets=True");
                cn.Open();
                          

                SqlCommand cand = new SqlCommand("SELECT BookBorrowed FROM tblStudentlist WHERE LibraryID = '" + lblLibraryID.Text + "'", cn);
                SqlDataReader drd = cand.ExecuteReader();

                while (drd.Read())
                {
                    txtBookBorrowed.Text = drd["BookBorrowed"].ToString();
                    int bookBorrowed = Int32.Parse(txtBookBorrowed.Text);

                    bookBorrowed++;

                    SqlCommand cd = new SqlCommand("UPDATE tblStudentList SET BookBorrowed = '" + bookBorrowed + "'", cn);
                    cd.ExecuteNonQuery();

                }


                SqlCommand bookQty = new SqlCommand("SELECT Quantity FROM tblBookList WHERE BookTitle = '" + lblBookTitle.Text + "'", cn);
                SqlDataReader qtyReader = bookQty.ExecuteReader();

                while (qtyReader.Read())
                {
                    txtbookQty.Text = qtyReader["Quantity"].ToString();
                    int temp_bookQty = Int32.Parse(txtbookQty.Text);

                    temp_bookQty++;

                    SqlCommand cd = new SqlCommand("UPDATE tblBookList SET Quantity = '" + temp_bookQty + "' WHERE BookTitle = '" + lblBookTitle.Text + "' ", cn);
                    cd.ExecuteNonQuery();

                }

                SqlCommand cmd = new SqlCommand("UPDATE tblBorrow SET Returned = 'Yes' WHERE ID = '" + txtBorrowID.Text + "' ", cn);
                cmd.ExecuteNonQuery();


                SqlCommand select = new SqlCommand("SELECT DueDate FROM tblBorrow WHERE ID = '" + txtBorrowID.Text + "' ",cn);
                SqlDataReader drr = select.ExecuteReader();
                while (drr.Read())
                {
                    lblDateReturned.Text = drr["DueDate"].ToString() + " " + DateTime.Now.ToString("hh:mm tt");

                    String[] split = lblDateReturned.Text.Replace(",", "").Split(' ');

                    int dateToReturned = Int32.Parse(split[1]);

                    int dateToday = Int32.Parse(DateTime.Now.ToString("dd"));
                    

                    if (dateToday == 30 || dateToday == 31)
                    {
                        if (dateToReturned < dateToday)
                        {
                            //Do Something..
                            select = new SqlCommand("UPDATE  tblBorrow SET DateReturned = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' WHERE ID = '" + txtBorrowID.Text + "' ", cn);
                            select.ExecuteNonQuery();
                        }                        
                    }

                    else if (dateToReturned < dateToday)
                    {
                        MessageBox.Show("+10 sa penalty .. gago ka ee!");
                        SqlCommand css = new SqlCommand("UPDATE  tblBorrow SET DateReturned = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' WHERE ID = '" + txtBorrowID.Text + "' ", cn);
                        css.ExecuteNonQuery();

                        SqlCommand penalty = new SqlCommand("SELECT Penalty FROM tblStudentList WHERE LibraryID = '" + lblLibraryID.Text + "'",cn);
                        SqlDataReader penaltyReader = penalty.ExecuteReader();

                        while(penaltyReader.Read())
                        {
                            String temp = penaltyReader["Penalty"].ToString();
                            int penaltyTemp = Int32.Parse(temp);

                            if (penaltyTemp == 20)
                            {
                                select = new SqlCommand("UPDATE tblStudentList SET Remarks = '" + "Need to call the guardian." + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
                                select.ExecuteNonQuery();
                            }
                            else
                            {
                                penaltyTemp += 10;

                                select = new SqlCommand("UPDATE tblStudentList SET Penalty = '" + penaltyTemp + "' WHERE LibraryID = '" + lblLibraryID.Text + "' ", cn);
                                select.ExecuteNonQuery();
                            }

                        }

                        //select = new SqlCommand("UPDATE tblStudentList SET Penalty = '" + 10 + "' WHERE LibraryID = '" + lblLibraryID.Text   + "' ",cn);
                        //select.ExecuteNonQuery();
                    }


                    else
                    {
                        SqlCommand update = new SqlCommand("UPDATE  tblBorrow SET DateReturned = '" + DateTime.Now.ToString("MMMM dd, yyyy") + "' WHERE ID = '" + txtBorrowID.Text + "' ", cn);
                        update.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully Returned!");

                lblLibraryID.Visible = false;
                lblStudentName.Visible = false;
                lblBookTitle.Visible = false;
                lblAuthor.Visible = false;
                lblDateBorrowed.Visible = false;
                lblDateReturned.Visible = false;
                lblReturned.Visible = false;

                showBorrowers();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bh = new BorrowedHistory();
            bh.Show();
            this.Hide();
        }

        private void ReturnBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to returning book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void dgvBorrowers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBorrowID.Text = dgvBorrowers.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                lblLibraryID.Text = dgvBorrowers.Rows[e.RowIndex].Cells["LibraryID"].Value.ToString();
                lblStudentName.Text = dgvBorrowers.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                lblBookTitle.Text = dgvBorrowers.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();
                lblAuthor.Text = dgvBorrowers.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                lblDateBorrowed.Text = dgvBorrowers.Rows[e.RowIndex].Cells["DateBorrowed"].Value.ToString();
                lblDateReturned.Text = dgvBorrowers.Rows[e.RowIndex].Cells["Due Date"].Value.ToString();
                lblReturned.Text = dgvBorrowers.Rows[e.RowIndex].Cells["Returned"].Value.ToString();

                lblLibraryID.Visible = true;
                lblStudentName.Visible = true;
                lblBookTitle.Visible = true;
                lblAuthor.Visible = true;
                lblDateBorrowed.Visible = true;
                lblDateReturned.Visible = true;
                lblReturned.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
