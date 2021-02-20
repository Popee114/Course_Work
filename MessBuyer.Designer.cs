namespace Coursework
{
    partial class MessBuyer
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
            this.panelHighMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClosing = new System.Windows.Forms.Button();
            this.richTextBoxMessAdmin = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMessBuyer = new System.Windows.Forms.RichTextBox();
            this.buttonSendMess = new System.Windows.Forms.Button();
            this.panelHighMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHighMenu
            // 
            this.panelHighMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.panelHighMenu.Controls.Add(this.label3);
            this.panelHighMenu.Controls.Add(this.buttonClosing);
            this.panelHighMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHighMenu.Location = new System.Drawing.Point(0, 0);
            this.panelHighMenu.Name = "panelHighMenu";
            this.panelHighMenu.Size = new System.Drawing.Size(362, 23);
            this.panelHighMenu.TabIndex = 4;
            this.panelHighMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHighMenu_MouseDown);
            this.panelHighMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHighMenu_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Juice ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Связь с администратором";
            // 
            // buttonClosing
            // 
            this.buttonClosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClosing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.buttonClosing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.buttonClosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosing.Location = new System.Drawing.Point(335, 0);
            this.buttonClosing.Name = "buttonClosing";
            this.buttonClosing.Size = new System.Drawing.Size(27, 23);
            this.buttonClosing.TabIndex = 8;
            this.buttonClosing.Text = "X";
            this.buttonClosing.UseVisualStyleBackColor = false;
            this.buttonClosing.Click += new System.EventHandler(this.buttonClosing_Click);
            // 
            // richTextBoxMessAdmin
            // 
            this.richTextBoxMessAdmin.Enabled = false;
            this.richTextBoxMessAdmin.Location = new System.Drawing.Point(12, 29);
            this.richTextBoxMessAdmin.Name = "richTextBoxMessAdmin";
            this.richTextBoxMessAdmin.Size = new System.Drawing.Size(339, 119);
            this.richTextBoxMessAdmin.TabIndex = 5;
            this.richTextBoxMessAdmin.Text = "";
            // 
            // richTextBoxMessBuyer
            // 
            this.richTextBoxMessBuyer.Enabled = false;
            this.richTextBoxMessBuyer.Location = new System.Drawing.Point(12, 154);
            this.richTextBoxMessBuyer.Name = "richTextBoxMessBuyer";
            this.richTextBoxMessBuyer.Size = new System.Drawing.Size(339, 119);
            this.richTextBoxMessBuyer.TabIndex = 6;
            this.richTextBoxMessBuyer.Text = "";
            // 
            // buttonSendMess
            // 
            this.buttonSendMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(221)))));
            this.buttonSendMess.FlatAppearance.BorderSize = 0;
            this.buttonSendMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMess.Location = new System.Drawing.Point(12, 279);
            this.buttonSendMess.Name = "buttonSendMess";
            this.buttonSendMess.Size = new System.Drawing.Size(339, 35);
            this.buttonSendMess.TabIndex = 10;
            this.buttonSendMess.Text = "Отправить сообщение";
            this.buttonSendMess.UseVisualStyleBackColor = false;
            this.buttonSendMess.Click += new System.EventHandler(this.buttonSendMess_Click);
            // 
            // MessBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(177)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(362, 325);
            this.Controls.Add(this.buttonSendMess);
            this.Controls.Add(this.richTextBoxMessBuyer);
            this.Controls.Add(this.richTextBoxMessAdmin);
            this.Controls.Add(this.panelHighMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessBuyer";
            this.Load += new System.EventHandler(this.MessBuyer_Load);
            this.panelHighMenu.ResumeLayout(false);
            this.panelHighMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHighMenu;
        private System.Windows.Forms.Button buttonClosing;
        private System.Windows.Forms.RichTextBox richTextBoxMessAdmin;
        private System.Windows.Forms.RichTextBox richTextBoxMessBuyer;
        private System.Windows.Forms.Button buttonSendMess;
        private System.Windows.Forms.Label label3;
    }
}