using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        readonly SqlConnection con = new SqlConnection("Data Source=LAPTOP-SE4TH6C3\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;");
        
        // Constructor
        public Login()
        {
            InitializeComponent();
        }
        private void Authenticate(int isAdmin)
        {
            try
            {
                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter your credentials");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoginUsers WHERE User_Name=@Name AND User_Pass=@Pass " +
                        "AND isAdmin=@isAdmin", con);
                    cmd.Parameters.AddWithValue("@Name", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successfull!");
                        AdminForm ob = new AdminForm();
                        this.Hide();
                        ob.Show();
                    } 
                    else
                    {
                        MessageBox.Show("Please check your credentials!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoginCustomer_Click(object sender, EventArgs e)
        {
            int isAdmin = 0;
            Authenticate(isAdmin);
        }

        private void BtnLoginAdmin_Click(object sender, EventArgs e)
        {
            int isAdmin = 1;
            Authenticate(isAdmin);
        }
    }
}
