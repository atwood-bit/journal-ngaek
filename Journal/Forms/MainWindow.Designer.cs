namespace Journal.Forms
{
    partial class MainWindow
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
            this.GroupInfo = new System.Windows.Forms.Button();
            this.Timetable = new System.Windows.Forms.Button();
            this.TeacherList = new System.Windows.Forms.Button();
            this.SubjectList = new System.Windows.Forms.Button();
            this.GroupList = new System.Windows.Forms.Button();
            this.ViewPerfomance = new System.Windows.Forms.Button();
            this.JournalBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.StudentsList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupInfo
            // 
            this.GroupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupInfo.Location = new System.Drawing.Point(34, 45);
            this.GroupInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.Size = new System.Drawing.Size(153, 63);
            this.GroupInfo.TabIndex = 0;
            this.GroupInfo.Text = "Информация о группе";
            this.GroupInfo.UseVisualStyleBackColor = true;
            this.GroupInfo.Click += new System.EventHandler(this.GroupInfo_Click);
            // 
            // Timetable
            // 
            this.Timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timetable.Location = new System.Drawing.Point(230, 258);
            this.Timetable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(153, 63);
            this.Timetable.TabIndex = 1;
            this.Timetable.Text = "Раcписание";
            this.Timetable.UseVisualStyleBackColor = true;
            this.Timetable.Click += new System.EventHandler(this.Timetable_Click);
            // 
            // TeacherList
            // 
            this.TeacherList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherList.Location = new System.Drawing.Point(422, 45);
            this.TeacherList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(153, 63);
            this.TeacherList.TabIndex = 2;
            this.TeacherList.Text = "Список преподавателей";
            this.TeacherList.UseVisualStyleBackColor = true;
            this.TeacherList.Click += new System.EventHandler(this.TeacherList_Click);
            // 
            // SubjectList
            // 
            this.SubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectList.Location = new System.Drawing.Point(422, 143);
            this.SubjectList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(153, 63);
            this.SubjectList.TabIndex = 5;
            this.SubjectList.Text = "Список предметов";
            this.SubjectList.UseVisualStyleBackColor = true;
            this.SubjectList.Click += new System.EventHandler(this.SubjectList_Click);
            // 
            // GroupList
            // 
            this.GroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupList.Location = new System.Drawing.Point(230, 143);
            this.GroupList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(153, 63);
            this.GroupList.TabIndex = 4;
            this.GroupList.Text = "Список групп";
            this.GroupList.UseVisualStyleBackColor = true;
            this.GroupList.Click += new System.EventHandler(this.GroupList_Click);
            // 
            // ViewPerfomance
            // 
            this.ViewPerfomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewPerfomance.Location = new System.Drawing.Point(34, 143);
            this.ViewPerfomance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewPerfomance.Name = "ViewPerfomance";
            this.ViewPerfomance.Size = new System.Drawing.Size(153, 63);
            this.ViewPerfomance.TabIndex = 3;
            this.ViewPerfomance.Text = "Просмотр успеваемости";
            this.ViewPerfomance.UseVisualStyleBackColor = true;
            this.ViewPerfomance.Click += new System.EventHandler(this.ViewPerfomance_Click);
            // 
            // JournalBtn
            // 
            this.JournalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalBtn.Location = new System.Drawing.Point(34, 258);
            this.JournalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JournalBtn.Name = "JournalBtn";
            this.JournalBtn.Size = new System.Drawing.Size(153, 63);
            this.JournalBtn.TabIndex = 8;
            this.JournalBtn.Text = "Журнал группы";
            this.JournalBtn.UseVisualStyleBackColor = true;
            this.JournalBtn.Click += new System.EventHandler(this.JournalBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersBtn.Location = new System.Drawing.Point(422, 258);
            this.UsersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(153, 63);
            this.UsersBtn.TabIndex = 7;
            this.UsersBtn.Text = "Список пользователей";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Visible = false;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // StudentsList
            // 
            this.StudentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsList.Location = new System.Drawing.Point(230, 45);
            this.StudentsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(153, 63);
            this.StudentsList.TabIndex = 6;
            this.StudentsList.Text = "Список учащихся";
            this.StudentsList.UseVisualStyleBackColor = true;
            this.StudentsList.Click += new System.EventHandler(this.StudentsList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoItem,
            this.ExitItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InfoItem
            // 
            this.InfoItem.Name = "InfoItem";
            this.InfoItem.Size = new System.Drawing.Size(65, 20);
            this.InfoItem.Text = "Справка";
            this.InfoItem.Click += new System.EventHandler(this.InfoItem_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(54, 20);
            this.ExitItem.Text = "Выход";
            this.ExitItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 343);
            this.Controls.Add(this.JournalBtn);
            this.Controls.Add(this.UsersBtn);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.ViewPerfomance);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.Timetable);
            this.Controls.Add(this.GroupInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GroupInfo;
        private System.Windows.Forms.Button Timetable;
        private System.Windows.Forms.Button TeacherList;
        private System.Windows.Forms.Button SubjectList;
        private System.Windows.Forms.Button GroupList;
        private System.Windows.Forms.Button ViewPerfomance;
        private System.Windows.Forms.Button JournalBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button StudentsList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InfoItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
    }
}