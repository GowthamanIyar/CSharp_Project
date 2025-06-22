namespace Unicom_TIC_Management_System
{
    partial class main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.admin = new System.Windows.Forms.Label();
            this.staff = new System.Windows.Forms.Label();
            this.lecturer = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admin.Location = new System.Drawing.Point(348, 84);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(45, 16);
            this.admin.TabIndex = 0;
            this.admin.Text = "Admin";
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // staff
            // 
            this.staff.AutoSize = true;
            this.staff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staff.Location = new System.Drawing.Point(350, 133);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(33, 16);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // lecturer
            // 
            this.lecturer.AutoSize = true;
            this.lecturer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lecturer.Location = new System.Drawing.Point(345, 181);
            this.lecturer.Name = "lecturer";
            this.lecturer.Size = new System.Drawing.Size(55, 16);
            this.lecturer.TabIndex = 0;
            this.lecturer.Text = "Lecturer";
            this.lecturer.Click += new System.EventHandler(this.lecturer_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student.Location = new System.Drawing.Point(348, 229);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(52, 16);
            this.student.TabIndex = 0;
            this.student.Text = "Student";
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(259, 35);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(223, 16);
            this.role.TabIndex = 1;
            this.role.Text = "Please Select Your Role in this UMS\r\n";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.role);
            this.Controls.Add(this.student);
            this.Controls.Add(this.lecturer);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.admin);
            this.Name = "main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label staff;
        private System.Windows.Forms.Label lecturer;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.Label role;
    }
}