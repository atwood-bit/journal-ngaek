namespace Journal.Forms.Subjects
{
    partial class Subject
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
            this.SelectTeachers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.NewSubject = new System.Windows.Forms.CheckBox();
            this.SelectSubjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectTeachers
            // 
            this.SelectTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTeachers.FormattingEnabled = true;
            this.SelectTeachers.Location = new System.Drawing.Point(45, 167);
            this.SelectTeachers.Name = "SelectTeachers";
            this.SelectTeachers.Size = new System.Drawing.Size(246, 24);
            this.SelectTeachers.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Преподаватель";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(45, 91);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(246, 22);
            this.NameBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Предмет";
            // 
            // ActionBtn
            // 
            this.ActionBtn.Location = new System.Drawing.Point(89, 215);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(156, 35);
            this.ActionBtn.TabIndex = 6;
            this.ActionBtn.Text = "Добавить";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // NewSubject
            // 
            this.NewSubject.AutoSize = true;
            this.NewSubject.Location = new System.Drawing.Point(45, 52);
            this.NewSubject.Name = "NewSubject";
            this.NewSubject.Size = new System.Drawing.Size(133, 21);
            this.NewSubject.TabIndex = 11;
            this.NewSubject.Text = "Новый предмет";
            this.NewSubject.UseVisualStyleBackColor = true;
            this.NewSubject.CheckedChanged += new System.EventHandler(this.NewSubject_CheckedChanged);
            // 
            // SelectSubjects
            // 
            this.SelectSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSubjects.FormattingEnabled = true;
            this.SelectSubjects.Location = new System.Drawing.Point(45, 91);
            this.SelectSubjects.Name = "SelectSubjects";
            this.SelectSubjects.Size = new System.Drawing.Size(246, 24);
            this.SelectSubjects.TabIndex = 12;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 264);
            this.Controls.Add(this.SelectSubjects);
            this.Controls.Add(this.NewSubject);
            this.Controls.Add(this.SelectTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionBtn);
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.CheckBox NewSubject;
        private System.Windows.Forms.ComboBox SelectSubjects;
    }
}