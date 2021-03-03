namespace Journal.Forms.Timetable
{
    partial class AddTimetable
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
            this.label3 = new System.Windows.Forms.Label();
            this.GroupSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectsSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TeacherSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата";
            // 
            // GroupSelect
            // 
            this.GroupSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupSelect.FormattingEnabled = true;
            this.GroupSelect.Location = new System.Drawing.Point(24, 128);
            this.GroupSelect.Name = "GroupSelect";
            this.GroupSelect.Size = new System.Drawing.Size(246, 24);
            this.GroupSelect.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Группа";
            // 
            // SubjectsSelect
            // 
            this.SubjectsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectsSelect.FormattingEnabled = true;
            this.SubjectsSelect.Location = new System.Drawing.Point(24, 207);
            this.SubjectsSelect.Name = "SubjectsSelect";
            this.SubjectsSelect.Size = new System.Drawing.Size(246, 24);
            this.SubjectsSelect.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Предмет";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // TeacherSelect
            // 
            this.TeacherSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherSelect.FormattingEnabled = true;
            this.TeacherSelect.Location = new System.Drawing.Point(24, 278);
            this.TeacherSelect.Name = "TeacherSelect";
            this.TeacherSelect.Size = new System.Drawing.Size(246, 24);
            this.TeacherSelect.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Преподаватель";
            // 
            // AddTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 398);
            this.Controls.Add(this.TeacherSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectsSelect);
            this.Controls.Add(this.label2);
            this.Name = "AddTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.AddTimetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GroupSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SubjectsSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox TeacherSelect;
        private System.Windows.Forms.Label label4;
    }
}