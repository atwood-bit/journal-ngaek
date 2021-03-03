namespace Journal.Forms.Students
{
    partial class Student
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
            this.ActionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ActionBtn
            // 
            this.ActionBtn.Location = new System.Drawing.Point(68, 147);
            this.ActionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(117, 28);
            this.ActionBtn.TabIndex = 0;
            this.ActionBtn.Text = "Добавить";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя учащегося";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(35, 46);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(186, 20);
            this.NameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группа";
            // 
            // SelectGroup
            // 
            this.SelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectGroup.FormattingEnabled = true;
            this.SelectGroup.Location = new System.Drawing.Point(35, 108);
            this.SelectGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectGroup.Name = "SelectGroup";
            this.SelectGroup.Size = new System.Drawing.Size(186, 21);
            this.SelectGroup.TabIndex = 5;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 185);
            this.Controls.Add(this.SelectGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.AddStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectGroup;
    }
}