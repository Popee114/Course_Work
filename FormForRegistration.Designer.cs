namespace Coursework
{
    partial class FormForRegistration
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegEmail = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRegName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(20, 199);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 16);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(20, 120);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 16);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(23, 215);
            this.textBoxRegPassword.MaxLength = 15;
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.PasswordChar = '•';
            this.textBoxRegPassword.Size = new System.Drawing.Size(176, 20);
            this.textBoxRegPassword.TabIndex = 5;
            // 
            // textBoxRegLogin
            // 
            this.textBoxRegLogin.Location = new System.Drawing.Point(23, 139);
            this.textBoxRegLogin.MaxLength = 12;
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(86, 20);
            this.textBoxRegLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Повторите пароль";
            // 
            // textBoxRegConfirmPassword
            // 
            this.textBoxRegConfirmPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegConfirmPassword.Location = new System.Drawing.Point(23, 254);
            this.textBoxRegConfirmPassword.MaxLength = 15;
            this.textBoxRegConfirmPassword.Name = "textBoxRegConfirmPassword";
            this.textBoxRegConfirmPassword.PasswordChar = '•';
            this.textBoxRegConfirmPassword.Size = new System.Drawing.Size(176, 20);
            this.textBoxRegConfirmPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(107, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Эл. почта";
            // 
            // textBoxRegEmail
            // 
            this.textBoxRegEmail.Location = new System.Drawing.Point(113, 139);
            this.textBoxRegEmail.MaxLength = 50;
            this.textBoxRegEmail.Name = "textBoxRegEmail";
            this.textBoxRegEmail.Size = new System.Drawing.Size(86, 20);
            this.textBoxRegEmail.TabIndex = 2;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(48, 280);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(124, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(107, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Фамилия";
            // 
            // textBoxRegSurname
            // 
            this.textBoxRegSurname.Location = new System.Drawing.Point(113, 178);
            this.textBoxRegSurname.MaxLength = 12;
            this.textBoxRegSurname.Name = "textBoxRegSurname";
            this.textBoxRegSurname.Size = new System.Drawing.Size(86, 20);
            this.textBoxRegSurname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Имя";
            // 
            // textBoxRegName
            // 
            this.textBoxRegName.Location = new System.Drawing.Point(23, 178);
            this.textBoxRegName.MaxLength = 12;
            this.textBoxRegName.Name = "textBoxRegName";
            this.textBoxRegName.Size = new System.Drawing.Size(86, 20);
            this.textBoxRegName.TabIndex = 3;
            // 
            // FormForRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 326);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRegSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRegName);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRegEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxRegPassword);
            this.Controls.Add(this.textBoxRegLogin);
            this.Name = "FormForRegistration";
            this.Text = "FormForRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.TextBox textBoxRegLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegEmail;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRegName;
    }
}