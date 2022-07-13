namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label displayLbl;
    }
}

