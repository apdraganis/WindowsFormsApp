using System;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        string name;
        string designation;
        int salary;
        string gender;
        string review;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            designation = txtDesignation.Text;
            salary = int.Parse(txtSalary.Text);
            

            // Gender
            if (rBtnFemale.Checked)
            {
                gender = rBtnFemale.Text;
            }
            else if (rBtnMale.Checked)
            {
                gender = rBtnMale.Text;
            }
            else
            {
                gender = "Not Specified";
            }

            // Review
            if (cBoxGood.Checked)
            {
                review = cBoxGood.Text;
            }
            else if (cBoxVeryGood.Checked)
            {
                review = cBoxVeryGood.Text;
            }
            else
            {
                review = "Not Specified";
            }

            display();
            //displayLbl.Text = $"Name: {name}\nDesignation: {designation}\nSalary: {salary}\nGender: {gender}\nReview: {review}";            

        }

        public void display()
        {
            dt.Columns.Add(" Name ");
            dt.Columns.Add(" Designation ");
            dt.Columns.Add(" Salary ");
            dt.Columns.Add(" Gender ");
            dt.Columns.Add(" Review ");

            DataRow dr = dt.NewRow();
            dr[0] = name;
            dr[1] = designation;
            dr[2] = salary;
            dr[3] = gender;
            dr[4] = review;

            dt.Rows.Add(dr);
            dtDataGridView.DataSource = dt;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.displayLbl = new System.Windows.Forms.Label();
            this.cBoxGood = new System.Windows.Forms.CheckBox();
            this.cBoxVeryGood = new System.Windows.Forms.CheckBox();
            this.reviewLbl = new System.Windows.Forms.Label();
            this.dtDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(198, 114);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(145, 20);
            this.txtDesignation.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(198, 149);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(145, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Location = new System.Drawing.Point(198, 185);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rBtnFemale.TabIndex = 7;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(290, 185);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(48, 17);
            this.rBtnMale.TabIndex = 8;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender:";
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Location = new System.Drawing.Point(83, 317);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(0, 13);
            this.displayLbl.TabIndex = 10;
            this.displayLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // cBoxGood
            // 
            this.cBoxGood.AutoSize = true;
            this.cBoxGood.Location = new System.Drawing.Point(198, 226);
            this.cBoxGood.Name = "cBoxGood";
            this.cBoxGood.Size = new System.Drawing.Size(52, 17);
            this.cBoxGood.TabIndex = 11;
            this.cBoxGood.Text = "Good";
            this.cBoxGood.UseVisualStyleBackColor = true;
            // 
            // cBoxVeryGood
            // 
            this.cBoxVeryGood.AutoSize = true;
            this.cBoxVeryGood.Location = new System.Drawing.Point(284, 226);
            this.cBoxVeryGood.Name = "cBoxVeryGood";
            this.cBoxVeryGood.Size = new System.Drawing.Size(76, 17);
            this.cBoxVeryGood.TabIndex = 12;
            this.cBoxVeryGood.Text = "Very Good";
            this.cBoxVeryGood.UseVisualStyleBackColor = true;
            // 
            // reviewLbl
            // 
            this.reviewLbl.AutoSize = true;
            this.reviewLbl.Location = new System.Drawing.Point(86, 226);
            this.reviewLbl.Name = "reviewLbl";
            this.reviewLbl.Size = new System.Drawing.Size(46, 13);
            this.reviewLbl.TabIndex = 13;
            this.reviewLbl.Text = "Review:";
            // 
            // dtDataGridView
            // 
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Location = new System.Drawing.Point(89, 266);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.Size = new System.Drawing.Size(349, 150);
            this.dtDataGridView.TabIndex = 14;
            this.dtDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDataGridView_CellContentClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 520);
            this.Controls.Add(this.dtDataGridView);
            this.Controls.Add(this.reviewLbl);
            this.Controls.Add(this.cBoxVeryGood);
            this.Controls.Add(this.cBoxGood);
            this.Controls.Add(this.displayLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rBtnMale);
            this.Controls.Add(this.rBtnFemale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
