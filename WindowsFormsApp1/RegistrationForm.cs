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
    public partial class RegistrationForm : Form
    {
        // String Connection
        string path = @"Data Source=LAPTOP-SE4TH6C3\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;


        public RegistrationForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtDesignation.Text == "" || txtEmail.Text == "" || txtID.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {
                    string gender;
                    if (radioFemale.Checked)
                    {
                        gender = "Female";
                    }
                    else if (radioMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Undefined";
                    }
                    con.Open();
                    cmd = new SqlCommand("insert into Employee (Employee_FirstName,Employee_LastName,Employee_Designation,Employee_Email,Emp_ID,Gender,Addrss) values ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtDesignation.Text + "', '" + txtEmail.Text + "', '" + txtID.Text + "', '" + gender + "', '" + txtAddress.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved in database!");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");
                }
            }


        }

        public void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";
        }
    }
}
