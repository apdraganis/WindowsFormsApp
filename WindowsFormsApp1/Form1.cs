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
        string courseName;

        RegistrationForm rg = new RegistrationForm();

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
            empty();
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
            dr[4] = courseName;

            dt.Rows.Add(dr);
            dtDataGridView.DataSource = dt;
        }

        public void empty()
        {
            txtName.Text = "";
            txtDesignation.Text = "";
            txtSalary.Text = "";
            rBtnFemale.Checked = false;
            rBtnMale.Checked = false;
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
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(183, 135);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(145, 20);
            this.txtDesignation.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(183, 170);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(145, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 95);
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
            this.rBtnFemale.Location = new System.Drawing.Point(183, 206);
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
            this.rBtnMale.Location = new System.Drawing.Point(275, 206);
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
            this.label4.Location = new System.Drawing.Point(68, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender:";
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Location = new System.Drawing.Point(68, 338);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(0, 13);
            this.displayLbl.TabIndex = 10;
            this.displayLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // cBoxGood
            // 
            this.cBoxGood.AutoSize = true;
            this.cBoxGood.Location = new System.Drawing.Point(183, 247);
            this.cBoxGood.Name = "cBoxGood";
            this.cBoxGood.Size = new System.Drawing.Size(52, 17);
            this.cBoxGood.TabIndex = 11;
            this.cBoxGood.Text = "Good";
            this.cBoxGood.UseVisualStyleBackColor = true;
            // 
            // cBoxVeryGood
            // 
            this.cBoxVeryGood.AutoSize = true;
            this.cBoxVeryGood.Location = new System.Drawing.Point(269, 247);
            this.cBoxVeryGood.Name = "cBoxVeryGood";
            this.cBoxVeryGood.Size = new System.Drawing.Size(76, 17);
            this.cBoxVeryGood.TabIndex = 12;
            this.cBoxVeryGood.Text = "Very Good";
            this.cBoxVeryGood.UseVisualStyleBackColor = true;
            // 
            // reviewLbl
            // 
            this.reviewLbl.AutoSize = true;
            this.reviewLbl.Location = new System.Drawing.Point(71, 247);
            this.reviewLbl.Name = "reviewLbl";
            this.reviewLbl.Size = new System.Drawing.Size(46, 13);
            this.reviewLbl.TabIndex = 13;
            this.reviewLbl.Text = "Review:";
            // 
            // dtDataGridView
            // 
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Location = new System.Drawing.Point(71, 338);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.Size = new System.Drawing.Size(349, 150);
            this.dtDataGridView.TabIndex = 14;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(183, 283);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourse.TabIndex = 15;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Course:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 97);
            this.panel1.TabIndex = 17;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.Location = new System.Drawing.Point(12, 36);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 46);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(154, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Invoice";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(300, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Items";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(445, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Products";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(590, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reports";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Location = new System.Drawing.Point(738, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Shop";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._new;
            this.pictureBox1.Location = new System.Drawing.Point(0, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 603);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCourse);
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
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCourse.Items.Add("C# Programming");
            comboBoxCourse.Items.Add("C++ Programming");
            comboBoxCourse.Items.Add("Java Programming");
            comboBoxCourse.Items.Add("PHP Programming");
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseName = comboBoxCourse.SelectedItem.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
