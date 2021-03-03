namespace Journal.Forms.Teachers
{
    partial class Teacher
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(43, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(246, 22);
            this.NameBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО преподавателя";
            // 
            // ActionBtn
            // 
            this.ActionBtn.Location = new System.Drawing.Point(87, 108);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(156, 35);
            this.ActionBtn.TabIndex = 6;
            this.ActionBtn.Text = "Добавить";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 162);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionBtn);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActionBtn;
    }
}