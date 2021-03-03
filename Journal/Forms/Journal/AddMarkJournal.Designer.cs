namespace Journal.Forms.Journal
{
    partial class AddMarkJournal
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
            this.SubjectsSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentsSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarkTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectsSelect
            // 
            this.SubjectsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectsSelect.FormattingEnabled = true;
            this.SubjectsSelect.Location = new System.Drawing.Point(26, 138);
            this.SubjectsSelect.Name = "SubjectsSelect";
            this.SubjectsSelect.Size = new System.Drawing.Size(246, 24);
            this.SubjectsSelect.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Предмет";
            // 
            // StudentsSelect
            // 
            this.StudentsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentsSelect.FormattingEnabled = true;
            this.StudentsSelect.Location = new System.Drawing.Point(26, 59);
            this.StudentsSelect.Name = "StudentsSelect";
            this.StudentsSelect.Size = new System.Drawing.Size(246, 24);
            this.StudentsSelect.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Учащийся";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(104, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Оценка";
            // 
            // MarkTxt
            // 
            this.MarkTxt.Location = new System.Drawing.Point(100, 224);
            this.MarkTxt.Name = "MarkTxt";
            this.MarkTxt.Size = new System.Drawing.Size(100, 22);
            this.MarkTxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddMarkJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MarkTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentsSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectsSelect);
            this.Controls.Add(this.label2);
            this.Name = "AddMarkJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.AddMarkJournal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SubjectsSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StudentsSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MarkTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}