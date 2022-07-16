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
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        // String Connection
        readonly string path = @"Data Source=LAPTOP-SE4TH6C3\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True";
        readonly SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int ID;

        // Constructor
        public RegistrationForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Display();
            button2.Enabled = false;
            button3.Enabled = false;
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
                    Clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}");
                }
            }


        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";
        }

        public void Display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Employee", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            radioFemale.Checked = false;
            radioMale.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Female")
            {
                radioFemale.Checked = true;
                radioMale.Checked = false;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                radioMale.Checked = true;
                radioFemale.Checked = false;
            }
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (radioFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Male";
                }

                con.Open();
                cmd = new SqlCommand("UPDATE Employee SET Employee_FirstName='"+ txtFirstName.Text + "', Employee_LastName='" + txtLastName.Text + "', Employee_Designation='" + txtDesignation.Text + "', Employee_Email='" + txtEmail.Text + "', Emp_ID='" + txtID.Text + "', Gender='" + gender + "', Addrss='" + txtAddress.Text + "' WHERE Employee_ID='"+ ID +"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been updated!");
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE from Employee WHERE Employee_Id='"+ ID +"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been deleted!");
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            adpt = new SqlDataAdapter("SELECT * FROM Employee WHERE Employee_FirstName LIKE '%" + txtSearch.Text  + "%'", con);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;

                for (int j = 2; j <= dataGridView1.Rows.Count; j++)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                    }
                };

                for(int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                };

                for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    };
                };
            }
            catch (Exception)
            {
             
            }

        }
    }
}
