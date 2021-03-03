namespace Journal
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Authorize = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Authorize
            // 
            this.Authorize.Location = new System.Drawing.Point(12, 95);
            this.Authorize.Margin = new System.Windows.Forms.Padding(2);
            this.Authorize.Name = "Authorize";
            this.Authorize.Size = new System.Drawing.Size(233, 24);
            this.Authorize.TabIndex = 0;
            this.Authorize.Text = "Вход";
            this.Authorize.UseVisualStyleBackColor = true;
            this.Authorize.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 123);
            this.Register.Margin = new System.Windows.Forms.Padding(2);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(233, 23);
            this.Register.TabIndex = 1;
            this.Register.Text = "Регистрация";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(83, 21);
            this.LoginTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(162, 20);
            this.LoginTxt.TabIndex = 5;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(83, 54);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(162, 20);
            this.PassTxt.TabIndex = 6;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 158);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Authorize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authorize;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.TextBox PassTxt;
    }
}

