namespace Journal.Forms.Timetable
{
    partial class ChangeTimetable
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateLbl = new System.Windows.Forms.Label();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectSelect = new System.Windows.Forms.ComboBox();
            this.TeacherSelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.SubjectName,
            this.Fio});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 64);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 221);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 30;
            // 
            // SubjectName
            // 
            this.SubjectName.Text = "Предмет";
            this.SubjectName.Width = 160;
            // 
            // Fio
            // 
            this.Fio.Text = "Преподаватель";
            this.Fio.Width = 150;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLbl.Location = new System.Drawing.Point(12, 20);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(167, 20);
            this.DateLbl.TabIndex = 5;
            this.DateLbl.Text = "Выберите группу";
            // 
            // GroupLbl
            // 
            this.GroupLbl.AutoSize = true;
            this.GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLbl.Location = new System.Drawing.Point(419, 20);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(167, 20);
            this.GroupLbl.TabIndex = 6;
            this.GroupLbl.Text = "Выберите группу";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label23.Location = new System.Drawing.Point(437, 81);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(93, 20);
            this.Label23.TabIndex = 7;
            this.Label23.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(409, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Преподаватель";
            // 
            // SubjectSelect
            // 
            this.SubjectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectSelect.FormattingEnabled = true;
            this.SubjectSelect.Location = new System.Drawing.Point(389, 122);
            this.SubjectSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectSelect.Name = "SubjectSelect";
            this.SubjectSelect.Size = new System.Drawing.Size(196, 24);
            this.SubjectSelect.TabIndex = 9;
            // 
            // TeacherSelect
            // 
            this.TeacherSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherSelect.FormattingEnabled = true;
            this.TeacherSelect.Location = new System.Drawing.Point(389, 234);
            this.TeacherSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherSelect.Name = "TeacherSelect";
            this.TeacherSelect.Size = new System.Drawing.Size(196, 24);
            this.TeacherSelect.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(389, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить предмет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(213, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(16, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChangeTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 338);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TeacherSelect);
            this.Controls.Add(this.SubjectSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.GroupLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.ChangeTimetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.Label Label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SubjectSelect;
        private System.Windows.Forms.ComboBox TeacherSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader SubjectName;
        private System.Windows.Forms.ColumnHeader Fio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}