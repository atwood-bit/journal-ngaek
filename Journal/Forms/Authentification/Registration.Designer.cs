namespace Journal.Forms
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.ComboBox();
            this.TeacherPass = new System.Windows.Forms.TextBox();
            this.CustomLabel = new System.Windows.Forms.Label();
            this.SelectBox = new System.Windows.Forms.ComboBox();
            this.SelectStudents = new System.Windows.Forms.ComboBox();
            this.StudentsName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зарегистрировать как";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(137, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(31, 320);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(181, 35);
            this.Register.TabIndex = 5;
            this.Register.Text = "Зарегистрироваться";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(269, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 36);
            this.Back.TabIndex = 6;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log.Location = new System.Drawing.Point(27, 156);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(59, 20);
            this.Log.TabIndex = 2;
            this.Log.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ФИО";
            // 
            // NameUser
            // 
            this.NameUser.Location = new System.Drawing.Point(235, 118);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(148, 22);
            this.NameUser.TabIndex = 7;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(235, 156);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(148, 22);
            this.Login.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(235, 197);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(148, 22);
            this.Password.TabIndex = 9;
            // 
            // Role
            // 
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Учащийся",
            "Преподаватель",
            "Родитель"});
            this.Role.Location = new System.Drawing.Point(235, 80);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(148, 24);
            this.Role.TabIndex = 10;
            this.Role.SelectedIndexChanged += new System.EventHandler(this.Role_SelectedIndexChanged);
            // 
            // TeacherPass
            // 
            this.TeacherPass.Location = new System.Drawing.Point(269, 232);
            this.TeacherPass.Name = "TeacherPass";
            this.TeacherPass.PasswordChar = '*';
            this.TeacherPass.Size = new System.Drawing.Size(114, 22);
            this.TeacherPass.TabIndex = 12;
            // 
            // CustomLabel
            // 
            this.CustomLabel.AutoSize = true;
            this.CustomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomLabel.Location = new System.Drawing.Point(27, 232);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(209, 20);
            this.CustomLabel.TabIndex = 11;
            this.CustomLabel.Text = "Пароль преподавателя";
            // 
            // SelectBox
            // 
            this.SelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectBox.FormattingEnabled = true;
            this.SelectBox.Items.AddRange(new object[] {
            "Учащийся",
            "Преподаватель",
            "Родитель"});
            this.SelectBox.Location = new System.Drawing.Point(235, 232);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(148, 24);
            this.SelectBox.TabIndex = 13;
            this.SelectBox.SelectedIndexChanged += new System.EventHandler(this.SelectBox_SelectedIndexChanged);
            // 
            // SelectStudents
            // 
            this.SelectStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectStudents.FormattingEnabled = true;
            this.SelectStudents.Items.AddRange(new object[] {
            "Учащийся",
            "Преподаватель",
            "Родитель"});
            this.SelectStudents.Location = new System.Drawing.Point(235, 272);
            this.SelectStudents.Name = "SelectStudents";
            this.SelectStudents.Size = new System.Drawing.Size(148, 24);
            this.SelectStudents.TabIndex = 15;
            this.SelectStudents.Visible = false;
            // 
            // StudentsName
            // 
            this.StudentsName.AutoSize = true;
            this.StudentsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsName.Location = new System.Drawing.Point(27, 272);
            this.StudentsName.Name = "StudentsName";
            this.StudentsName.Size = new System.Drawing.Size(93, 20);
            this.StudentsName.TabIndex = 14;
            this.StudentsName.Text = "Учащийся";
            this.StudentsName.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 368);
            this.Controls.Add(this.SelectStudents);
            this.Controls.Add(this.StudentsName);
            this.Controls.Add(this.SelectBox);
            this.Controls.Add(this.TeacherPass);
            this.Controls.Add(this.CustomLabel);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.NameUser);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameUser;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.TextBox TeacherPass;
        private System.Windows.Forms.Label CustomLabel;
        private System.Windows.Forms.ComboBox SelectBox;
        private System.Windows.Forms.ComboBox SelectStudents;
        private System.Windows.Forms.Label StudentsName;
    }
}