namespace Journal.Forms.Journal
{
    partial class JournalGroup
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(1, 47);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(1205, 663);
            this.Grid.TabIndex = 10;
            // 
            // MarkBtn
            // 
            this.MarkBtn.Location = new System.Drawing.Point(13, 4);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(188, 37);
            this.MarkBtn.TabIndex = 11;
            this.MarkBtn.Text = "Выставить оценку";
            this.MarkBtn.UseVisualStyleBackColor = true;
            this.MarkBtn.Visible = false;
            this.MarkBtn.Click += new System.EventHandler(this.MarkBtn_Click);
            // 
            // Excel
            // 
            this.Excel.Location = new System.Drawing.Point(1043, 4);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(154, 36);
            this.Excel.TabIndex = 12;
            this.Excel.Text = "Сохранить в Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // JournalGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 709);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.MarkBtn);
            this.Controls.Add(this.Grid);
            this.Name = "JournalGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.Load += new System.EventHandler(this.JournalGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.Button Excel;
    }
}