namespace Journal.Forms.Users
{
    partial class User
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
            this.SelectRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectRoles
            // 
            this.SelectRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRoles.FormattingEnabled = true;
            this.SelectRoles.Location = new System.Drawing.Point(52, 140);
            this.SelectRoles.Name = "SelectRoles";
            this.SelectRoles.Size = new System.Drawing.Size(246, 24);
            this.SelectRoles.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(127, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Роль";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(52, 61);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(246, 22);
            this.NameBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин";
            // 
            // ActionBtn
            // 
            this.ActionBtn.Location = new System.Drawing.Point(85, 207);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(156, 35);
            this.ActionBtn.TabIndex = 13;
            this.ActionBtn.Text = "Изменить";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 254);
            this.Controls.Add(this.SelectRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionBtn);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActionBtn;
    }
}