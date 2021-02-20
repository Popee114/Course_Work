namespace Coursework
{
    partial class MessAdmin
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
            this.comboBoxBuyer = new System.Windows.Forms.ComboBox();
            this.richTextBoxMessBuyer = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMessAdmin = new System.Windows.Forms.RichTextBox();
            this.buttonSendMess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBuyer
            // 
            this.comboBoxBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuyer.FormattingEnabled = true;
            this.comboBoxBuyer.Location = new System.Drawing.Point(547, 82);
            this.comboBoxBuyer.Name = "comboBoxBuyer";
            this.comboBoxBuyer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuyer.TabIndex = 0;
            this.comboBoxBuyer.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuyer_SelectedIndexChanged);
            // 
            // richTextBoxMessBuyer
            // 
            this.richTextBoxMessBuyer.Enabled = false;
            this.richTextBoxMessBuyer.Location = new System.Drawing.Point(184, 82);
            this.richTextBoxMessBuyer.Name = "richTextBoxMessBuyer";
            this.richTextBoxMessBuyer.Size = new System.Drawing.Size(357, 128);
            this.richTextBoxMessBuyer.TabIndex = 1;
            this.richTextBoxMessBuyer.Text = "";
            // 
            // richTextBoxMessAdmin
            // 
            this.richTextBoxMessAdmin.Enabled = false;
            this.richTextBoxMessAdmin.Location = new System.Drawing.Point(184, 216);
            this.richTextBoxMessAdmin.Name = "richTextBoxMessAdmin";
            this.richTextBoxMessAdmin.Size = new System.Drawing.Size(357, 128);
            this.richTextBoxMessAdmin.TabIndex = 2;
            this.richTextBoxMessAdmin.Text = "";
            // 
            // buttonSendMess
            // 
            this.buttonSendMess.BackColor = System.Drawing.Color.Silver;
            this.buttonSendMess.Enabled = false;
            this.buttonSendMess.FlatAppearance.BorderSize = 0;
            this.buttonSendMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMess.Location = new System.Drawing.Point(547, 312);
            this.buttonSendMess.Name = "buttonSendMess";
            this.buttonSendMess.Size = new System.Drawing.Size(121, 32);
            this.buttonSendMess.TabIndex = 3;
            this.buttonSendMess.Text = "Отправить ответ";
            this.buttonSendMess.UseVisualStyleBackColor = false;
            this.buttonSendMess.Click += new System.EventHandler(this.buttonSendMess_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Coursework.Properties.Resources.X;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(766, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(22, 19);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MessAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSendMess);
            this.Controls.Add(this.richTextBoxMessAdmin);
            this.Controls.Add(this.richTextBoxMessBuyer);
            this.Controls.Add(this.comboBoxBuyer);
            this.Name = "MessAdmin";
            this.Text = "MessAdmin";
            this.Load += new System.EventHandler(this.MessAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBuyer;
        private System.Windows.Forms.RichTextBox richTextBoxMessBuyer;
        private System.Windows.Forms.RichTextBox richTextBoxMessAdmin;
        private System.Windows.Forms.Button buttonSendMess;
        private System.Windows.Forms.Button buttonExit;
    }
}