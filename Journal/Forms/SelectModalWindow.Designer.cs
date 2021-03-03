namespace Journal.Forms
{
    partial class SelectModalWindow
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
            this.GroupSelect = new System.Windows.Forms.ComboBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SelectStudents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите группу";
            // 
            // GroupSelect
            // 
            this.GroupSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupSelect.FormattingEnabled = true;
            this.GroupSelect.Location = new System.Drawing.Point(76, 64);
            this.GroupSelect.Name = "GroupSelect";
            this.GroupSelect.Size = new System.Drawing.Size(163, 24);
            this.GroupSelect.TabIndex = 5;
            this.GroupSelect.SelectedIndexChanged += new System.EventHandler(this.GroupSelect_SelectedIndexChanged);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOK.Location = new System.Drawing.Point(76, 219);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(163, 43);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "Ок";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // SelectStudents
            // 
            this.SelectStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectStudents.FormattingEnabled = true;
            this.SelectStudents.Location = new System.Drawing.Point(76, 137);
            this.SelectStudents.Name = "SelectStudents";
            this.SelectStudents.Size = new System.Drawing.Size(163, 24);
            this.SelectStudents.TabIndex = 8;
            this.SelectStudents.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите учащегося";
            this.label2.Visible = false;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(57, 137);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 9;
            this.StartDate.Visible = false;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(57, 180);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 22);
            this.EndDate.TabIndex = 10;
            this.EndDate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "C";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "По";
            this.label4.Visible = false;
            // 
            // SelectModalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.SelectStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.GroupSelect);
            this.Controls.Add(this.label1);
            this.Name = "SelectModalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.SelectGroupModalWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupSelect;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.ComboBox SelectStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}