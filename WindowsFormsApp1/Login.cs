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
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SE4TH6C3\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;");
        
        // Constructor
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter your credentials");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoginUsers WHERE U_Name=@Name and U_Pass=@Pass", con);
                    cmd.Parameters.Add("@Name", txtUsername.Text);
                    cmd.Parameters.Add("@Pass", txtPassword.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successfull!");
                        Form1 ob = new Form1();
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
    }
}
