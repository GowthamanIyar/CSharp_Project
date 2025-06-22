namespace Unicom_TIC_Management_System
{
    partial class course
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
            this.Courses = new System.Windows.Forms.Label();
            this.selectcourse = new System.Windows.Forms.ComboBox();
            this.subjects = new System.Windows.Forms.Label();
            this.selectsubject = new System.Windows.Forms.ComboBox();
            this.selectedsubjects = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.newcourse = new System.Windows.Forms.Label();
            this.newsubject = new System.Windows.Forms.Label();
            this.addcourse = new System.Windows.Forms.TextBox();
            this.addsubject = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedsubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // Courses
            // 
            this.Courses.AutoSize = true;
            this.Courses.Location = new System.Drawing.Point(121, 56);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(57, 16);
            this.Courses.TabIndex = 0;
            this.Courses.Text = "Courses";
            // 
            // selectcourse
            // 
            this.selectcourse.FormattingEnabled = true;
            this.selectcourse.Location = new System.Drawing.Point(216, 48);
            this.selectcourse.Name = "selectcourse";
            this.selectcourse.Size = new System.Drawing.Size(444, 24);
            this.selectcourse.TabIndex = 1;
            this.selectcourse.SelectedIndexChanged += new System.EventHandler(this.selectcourse_SelectedIndexChanged);
            // 
            // subjects
            // 
            this.subjects.AutoSize = true;
            this.subjects.Location = new System.Drawing.Point(121, 97);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(59, 16);
            this.subjects.TabIndex = 0;
            this.subjects.Text = "Subjects";
            // 
            // selectsubject
            // 
            this.selectsubject.FormattingEnabled = true;
            this.selectsubject.Location = new System.Drawing.Point(216, 89);
            this.selectsubject.Name = "selectsubject";
            this.selectsubject.Size = new System.Drawing.Size(444, 24);
            this.selectsubject.TabIndex = 1;
            this.selectsubject.SelectedIndexChanged += new System.EventHandler(this.selectsubject_SelectedIndexChanged);
            // 
            // selectedsubjects
            // 
            this.selectedsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedsubjects.Location = new System.Drawing.Point(124, 216);
            this.selectedsubjects.Name = "selectedsubjects";
            this.selectedsubjects.RowHeadersWidth = 51;
            this.selectedsubjects.RowTemplate.Height = 24;
            this.selectedsubjects.Size = new System.Drawing.Size(536, 167);
            this.selectedsubjects.TabIndex = 2;
            this.selectedsubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedsubjects_CellContentClick);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(213, 407);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 16);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // remove
            // 
            this.remove.AutoSize = true;
            this.remove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove.Location = new System.Drawing.Point(434, 407);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(59, 16);
            this.remove.TabIndex = 0;
            this.remove.Text = "Remove";
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Location = new System.Drawing.Point(545, 407);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(32, 16);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // newcourse
            // 
            this.newcourse.AutoSize = true;
            this.newcourse.Location = new System.Drawing.Point(119, 136);
            this.newcourse.Name = "newcourse";
            this.newcourse.Size = new System.Drawing.Size(80, 16);
            this.newcourse.TabIndex = 0;
            this.newcourse.Text = "New Course";
            this.newcourse.Click += new System.EventHandler(this.newcourse_Click);
            // 
            // newsubject
            // 
            this.newsubject.AutoSize = true;
            this.newsubject.Location = new System.Drawing.Point(121, 173);
            this.newsubject.Name = "newsubject";
            this.newsubject.Size = new System.Drawing.Size(82, 16);
            this.newsubject.TabIndex = 0;
            this.newsubject.Text = "New Subject";
            this.newsubject.Click += new System.EventHandler(this.newsubject_Click);
            // 
            // addcourse
            // 
            this.addcourse.Location = new System.Drawing.Point(216, 129);
            this.addcourse.Name = "addcourse";
            this.addcourse.Size = new System.Drawing.Size(361, 22);
            this.addcourse.TabIndex = 3;
            this.addcourse.TextChanged += new System.EventHandler(this.addcourse_TextChanged);
            // 
            // addsubject
            // 
            this.addsubject.Location = new System.Drawing.Point(216, 167);
            this.addsubject.Name = "addsubject";
            this.addsubject.Size = new System.Drawing.Size(361, 22);
            this.addsubject.TabIndex = 3;
            this.addsubject.TextChanged += new System.EventHandler(this.addsubject_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(216, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(140, 22);
            this.id.TabIndex = 3;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(402, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(258, 22);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(313, 407);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(52, 16);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 458);
            this.Controls.Add(this.update);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.addsubject);
            this.Controls.Add(this.addcourse);
            this.Controls.Add(this.selectedsubjects);
            this.Controls.Add(this.selectsubject);
            this.Controls.Add(this.selectcourse);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.back);
            this.Controls.Add(this.newsubject);
            this.Controls.Add(this.newcourse);
            this.Controls.Add(this.subjects);
            this.Controls.Add(this.Courses);
            this.Name = "course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedsubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Courses;
        private System.Windows.Forms.ComboBox selectcourse;
        private System.Windows.Forms.Label subjects;
        private System.Windows.Forms.ComboBox selectsubject;
        private System.Windows.Forms.DataGridView selectedsubjects;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label remove;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label newcourse;
        private System.Windows.Forms.Label newsubject;
        private System.Windows.Forms.TextBox addcourse;
        private System.Windows.Forms.TextBox addsubject;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label update;
    }
}