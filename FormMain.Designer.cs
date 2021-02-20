namespace Coursework
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnFormSignup = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnFormRegistration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.btnSingup = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormSignup
            // 
            this.btnFormSignup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFormSignup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFormSignup.Location = new System.Drawing.Point(12, 338);
            this.btnFormSignup.Name = "btnFormSignup";
            this.btnFormSignup.Size = new System.Drawing.Size(108, 27);
            this.btnFormSignup.TabIndex = 0;
            this.btnFormSignup.Text = "Войти";
            this.btnFormSignup.UseVisualStyleBackColor = true;
            this.btnFormSignup.Click += new System.EventHandler(this.btnFormSignup_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.Location = new System.Drawing.Point(14, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(220, 320);
            this.panel.TabIndex = 1;
            // 
            // btnFormRegistration
            // 
            this.btnFormRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormRegistration.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFormRegistration.Location = new System.Drawing.Point(126, 338);
            this.btnFormRegistration.Name = "btnFormRegistration";
            this.btnFormRegistration.Size = new System.Drawing.Size(108, 27);
            this.btnFormRegistration.TabIndex = 2;
            this.btnFormRegistration.Text = "Регистрация";
            this.btnFormRegistration.UseVisualStyleBackColor = true;
            this.btnFormRegistration.Click += new System.EventHandler(this.btnFormRegistration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Добро пожаловать!";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(34, 208);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 16);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(34, 162);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 16);
            this.labelLogin.TabIndex = 21;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxPasswordUser
            // 
            this.textBoxPasswordUser.Location = new System.Drawing.Point(37, 224);
            this.textBoxPasswordUser.Name = "textBoxPasswordUser";
            this.textBoxPasswordUser.PasswordChar = '•';
            this.textBoxPasswordUser.Size = new System.Drawing.Size(176, 20);
            this.textBoxPasswordUser.TabIndex = 20;
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Location = new System.Drawing.Point(37, 181);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(176, 20);
            this.textBoxLoginUser.TabIndex = 19;
            // 
            // btnSingup
            // 
            this.btnSingup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSingup.Location = new System.Drawing.Point(89, 250);
            this.btnSingup.Name = "btnSingup";
            this.btnSingup.Size = new System.Drawing.Size(75, 23);
            this.btnSingup.TabIndex = 18;
            this.btnSingup.Text = "Войти";
            this.btnSingup.UseVisualStyleBackColor = true;
            this.btnSingup.Click += new System.EventHandler(this.btnSingup_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Coursework.Properties.Resources.adsadas;
            this.pictureBox.Location = new System.Drawing.Point(61, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(124, 112);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(244, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPasswordUser);
            this.Controls.Add(this.textBoxLoginUser);
            this.Controls.Add(this.btnSingup);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnFormRegistration);
            this.Controls.Add(this.btnFormSignup);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Торговая фирма";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnFormSignup;
        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Button btnFormRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPasswordUser;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.Button btnSingup;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

