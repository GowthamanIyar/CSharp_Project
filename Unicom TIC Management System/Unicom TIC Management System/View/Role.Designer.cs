namespace Unicom_TIC_Management_System
{
    partial class Role
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
            this.profile = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.Label();
            this.timetable = new System.Windows.Forms.Label();
            this.marks = new System.Windows.Forms.Label();
            this.attendance = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.members = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.AutoSize = true;
            this.profile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.profile.Location = new System.Drawing.Point(338, 64);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(45, 16);
            this.profile.TabIndex = 0;
            this.profile.Text = "Profile";
            // 
            // courses
            // 
            this.courses.AutoSize = true;
            this.courses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.courses.Location = new System.Drawing.Point(330, 109);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(57, 16);
            this.courses.TabIndex = 0;
            this.courses.Text = "Courses";
            // 
            // timetable
            // 
            this.timetable.AutoSize = true;
            this.timetable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timetable.Location = new System.Drawing.Point(326, 154);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(68, 16);
            this.timetable.TabIndex = 0;
            this.timetable.Text = "Timetable";
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.marks.Location = new System.Drawing.Point(339, 201);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(44, 16);
            this.marks.TabIndex = 0;
            this.marks.Text = "Marks";
            // 
            // attendance
            // 
            this.attendance.AutoSize = true;
            this.attendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.attendance.Location = new System.Drawing.Point(326, 247);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(75, 16);
            this.attendance.TabIndex = 0;
            this.attendance.Text = "Attendance";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Location = new System.Drawing.Point(342, 346);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 16);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            // 
            // members
            // 
            this.members.AutoSize = true;
            this.members.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.members.Location = new System.Drawing.Point(328, 24);
            this.members.Name = "members";
            this.members.Size = new System.Drawing.Size(64, 16);
            this.members.TabIndex = 0;
            this.members.Text = "Members";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.password.Location = new System.Drawing.Point(329, 289);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 32);
            this.password.TabIndex = 1;
            this.password.Text = "  Change\r\nPassword";
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.members);
            this.Controls.Add(this.profile);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profile;
        private System.Windows.Forms.Label courses;
        private System.Windows.Forms.Label timetable;
        private System.Windows.Forms.Label marks;
        private System.Windows.Forms.Label attendance;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label members;
        private System.Windows.Forms.Label password;
    }
}