namespace Unicom_TIC_Management_System
{
    partial class login
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
            this.userid = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(180, 110);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(52, 16);
            this.userid.TabIndex = 0;
            this.userid.Text = "User ID";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(180, 162);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 0;
            this.password.Text = "Password";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(326, 208);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 16);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Location = new System.Drawing.Point(458, 208);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(48, 16);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(276, 104);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(278, 22);
            this.user_id.TabIndex = 1;
            this.user_id.TextChanged += new System.EventHandler(this.user_id_TextChanged);
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(276, 156);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(278, 22);
            this.password1.TabIndex = 1;
            this.password1.TextChanged += new System.EventHandler(this.password1_TextChanged);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(180, 55);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(36, 16);
            this.role.TabIndex = 2;
            this.role.Text = "Role";
            // 
            // roles
            // 
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(276, 46);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(230, 24);
            this.roles.TabIndex = 3;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.role);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label submit;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.ComboBox roles;
    }
}