namespace Journal.Forms.Groups
{
    partial class Group
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
            this.SpecialtyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(34, 47);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(186, 20);
            this.NameBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название группы";
            // 
            // ActionBtn
            // 
            this.ActionBtn.Location = new System.Drawing.Point(72, 156);
            this.ActionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(117, 28);
            this.ActionBtn.TabIndex = 9;
            this.ActionBtn.Text = "Добавить";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // SpecialtyBox
            // 
            this.SpecialtyBox.Location = new System.Drawing.Point(34, 117);
            this.SpecialtyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecialtyBox.Name = "SpecialtyBox";
            this.SpecialtyBox.Size = new System.Drawing.Size(186, 20);
            this.SpecialtyBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Специальность";
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 194);
            this.Controls.Add(this.SpecialtyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.Group_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.TextBox SpecialtyBox;
        private System.Windows.Forms.Label label2;
    }
}