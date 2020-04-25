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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        public String name;
        public Main main;

        SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

           private void btnAdd_Click(object sender, EventArgs e)
        {
             try {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into tblStudentList (StudentName, ContactNumber, Address, Year, Section) values ('"+txtStudentno.Text+"', '"+txtContactno.Text+"','"+txtAddr.Text+"', '"+txtyear.Text+"', '"+txtSection.Text+"')",cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully added");
                showStud();
                txtStudentno.ResetText();
                txtContactno.ResetText();
                txtAddr.ResetText();
                txtyear.ResetText();
                txtSection.ResetText();


            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
            finally { cn.Close(); }



        }


        public void showStud()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=STALibrary;Integrated Security=True");

                cn.Open();

                String query = "SELECT * FROM tblStudentList";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            showStud();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();
            this.Hide();
        }

        private void txtStudentno_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtStudentno.Text == "Student Name")
            {
                txtStudentno.SelectionStart = 0;
            }
        }

        private void txtContactno_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtContactno.Text == "Contact Number")
            {
                txtContactno.SelectionStart = 0;
            }
        }

        private void txtAddr_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAddr.Text == "Address")
            {
                txtAddr.SelectionStart = 0;
            }
        }

        private void txtyear_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtyear.Text == "Year")
            {
                txtyear.SelectionStart = 0;
            }
        }

        private void txtSection_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSection.Text == "Section")
            {
                txtSection.SelectionStart = 0;
            }
        }

        private void txtStudentno_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtStudentno.ReadOnly = false;
            if (txtStudentno.Text == "Student Name")
            {
                txtStudentno.Text = "";
            }
        }

        private void txtContactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContactno.ReadOnly = false;
            if (txtContactno.Text == "Contact Number")
            {
                txtContactno.Text = "";
            }
        }

        private void txtAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAddr.ReadOnly = false;
            if (txtAddr.Text == "Address")
            {
                txtAddr.Text = "";
            }
        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtyear.ReadOnly = false;
            if (txtyear.Text == "Year")
            {
                txtyear.Text = "";
            }
        }

        private void txtSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSection.ReadOnly = false;
            if (txtSection.Text == "Section")
            {
                txtSection.Text = "";
            }
        }

        private void txtStudentno_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtStudentno.Text == "")
            {
                txtStudentno.Text = "Student Name";
            }
        }

        private void txtContactno_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtContactno.Text == "")
            {
                txtContactno.Text = "Contact Number";
            }
        }

        private void txtAddr_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAddr.Text == "")
            {
                txtAddr.Text = "Address";
            }
        }

        private void txtyear_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtyear.Text == "")
            {
                txtyear.Text = "Year";
            }
        }

        private void txtSection_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSection.Text == "")
            {
                txtSection.Text = "Section";
            }
        }

        private void txtStudentno_Enter(object sender, EventArgs e)
        {
            txtStudentno.SelectionStart = 0;
            txtStudentno.ReadOnly = true;
        }

        private void txtContactno_Enter(object sender, EventArgs e)
        {
            txtContactno.SelectionStart = 0;
            txtContactno.ReadOnly = true;
        }

        private void txtAddr_Enter(object sender, EventArgs e)
        {
            txtAddr.SelectionStart = 0;
            txtAddr.ReadOnly = true;
        }

        private void txtyear_Enter(object sender, EventArgs e)
        {
            txtyear.SelectionStart = 0;
            txtyear.ReadOnly = true;
        }

        private void txtSection_Enter(object sender, EventArgs e)
        {
            txtSection.SelectionStart = 0;
            txtSection.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("update tblStudentList SET StudentName = '" + txtStudentno.Text + "' , ContactNumber = '" + txtContactno.Text + "' , Address = '" + txtAddr.Text + "' ,  Year = '" + txtyear.Text + "' , Section = '" + txtSection.Text + "' where LibraryID = '" + lblLibraryID.Text + "' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Updated");
                showStud();
                txtStudentno.Text = "Student Name";
                txtContactno.Text = "Contact Number";
                txtAddr.Text = "Address";
                txtyear.Text = "Year";
                txtSection.Text = "Section";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { cn.Close(); }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblLibraryID.Text = dgvStudents.Rows[e.RowIndex].Cells["LibraryID"].Value.ToString();
                txtStudentno.Text = dgvStudents.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                txtContactno.Text = dgvStudents.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
                txtAddr.Text = dgvStudents.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtyear.Text = dgvStudents.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                txtSection.Text = dgvStudents.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudents_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblLibraryID.Text = dgvStudents.Rows[e.RowIndex].Cells["LibraryID"].Value.ToString();
                txtStudentno.Text = dgvStudents.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                txtContactno.Text = dgvStudents.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
                txtAddr.Text = dgvStudents.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtyear.Text = dgvStudents.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                txtSection.Text = dgvStudents.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
