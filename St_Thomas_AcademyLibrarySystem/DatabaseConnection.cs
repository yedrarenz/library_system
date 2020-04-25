using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.Sql;
using System.Data.SqlClient;

namespace St_Thomas_AcademyLibrarySystem
{
    public partial class DatabaseConnection : Form
    {

        public String ConnectionString;

        public DatabaseConnection()
        {
            InitializeComponent();
        }

        public void showServerName()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
            String[] instances = (String[])rk.GetValue("InstalledInstances");
            if (instances.Length > 0)
            {
                foreach (String element in instances)
                {
                    if (element == "MSSQLSERVER")
                        txtServerName.Text = (System.Environment.MachineName);
                    else
                        txtServerName.Text = (System.Environment.MachineName + @"\" + element);

                }
            }
        }

        public void dbConnect()
        {
            ConnectionString = "Data Source= '" + txtServerName.Text + "' ;Initial Catalog= '" + txtDatabaseName.Text + "'; INTEGRATED SECURITY = TRUE";
        
}

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            showServerName();

            //SqlConnection cn = new SqlConnection(ConnectionString);
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT SYSTEM_USER",cn);
            //SqlDataReader dr = cmd.ExecuteReader();

            //txtUserName.Text = dr.GetValue(0).ToString();

            //cn.Close();

         


        }

        private void txtBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Database File";

            openFileDialog1.DefaultExt = "mdf";
            openFileDialog1.Filter = "Database files (*.mdf)|*.mdf";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtDatabaseName.Text = openFileDialog1.FileName;
                txtDatabaseName.Text = openFileDialog1.FileName.Replace(".mdf", "").Remove(0, 3);
            }

            
        }

        private void btnConnectionString_Click(object sender, EventArgs e)
        {
            dbConnect();
            //Login lg = new Login();
            //lg.dc = this;
            //lg.Show();
            //this.Hide();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {

            dbConnect();

            //MessageBox.Show(ConnectionString);

            try
            {

                String Attach = "(ON (FILENAME = ' '" + txtDatabaseName.Text + ".mdf" + "' ') FOR ATTACH )";
                SqlConnection cn = new SqlConnection(ConnectionString);

                cn.Open();

                SqlCommand cmd = new SqlCommand(Attach, cn);
                cmd.ExecuteNonQuery();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
