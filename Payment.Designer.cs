namespace Coursework
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panelHighMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCARD = new System.Windows.Forms.RadioButton();
            this.radioButtonNAL = new System.Windows.Forms.RadioButton();
            this.textBoxCARD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDateDelivery = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonPickup = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddressDelovery = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.panelHighMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHighMenu
            // 
            this.panelHighMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.panelHighMenu.Controls.Add(this.label3);
            this.panelHighMenu.Controls.Add(this.buttonClose);
            this.panelHighMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHighMenu.Location = new System.Drawing.Point(0, 0);
            this.panelHighMenu.Name = "panelHighMenu";
            this.panelHighMenu.Size = new System.Drawing.Size(349, 23);
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
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Оплата и получение товара";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(322, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(27, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(221)))));
            this.groupBox1.Controls.Add(this.radioButtonCARD);
            this.groupBox1.Controls.Add(this.radioButtonNAL);
            this.groupBox1.Controls.Add(this.textBoxCARD);
            this.groupBox1.Font = new System.Drawing.Font("Juice ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оплата";
            // 
            // radioButtonCARD
            // 
            this.radioButtonCARD.AutoSize = true;
            this.radioButtonCARD.Location = new System.Drawing.Point(17, 40);
            this.radioButtonCARD.Name = "radioButtonCARD";
            this.radioButtonCARD.Size = new System.Drawing.Size(80, 18);
            this.radioButtonCARD.TabIndex = 4;
            this.radioButtonCARD.TabStop = true;
            this.radioButtonCARD.Text = "По карте - ";
            this.radioButtonCARD.UseVisualStyleBackColor = true;
            this.radioButtonCARD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonCARD_MouseClick);
            // 
            // radioButtonNAL
            // 
            this.radioButtonNAL.AutoSize = true;
            this.radioButtonNAL.Location = new System.Drawing.Point(17, 20);
            this.radioButtonNAL.Name = "radioButtonNAL";
            this.radioButtonNAL.Size = new System.Drawing.Size(84, 18);
            this.radioButtonNAL.TabIndex = 3;
            this.radioButtonNAL.TabStop = true;
            this.radioButtonNAL.Text = "Наличными";
            this.radioButtonNAL.UseVisualStyleBackColor = true;
            this.radioButtonNAL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonNAL_MouseClick);
            // 
            // textBoxCARD
            // 
            this.textBoxCARD.Enabled = false;
            this.textBoxCARD.Location = new System.Drawing.Point(97, 39);
            this.textBoxCARD.MaxLength = 16;
            this.textBoxCARD.Name = "textBoxCARD";
            this.textBoxCARD.Size = new System.Drawing.Size(219, 21);
            this.textBoxCARD.TabIndex = 2;
            this.textBoxCARD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCARD_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(221)))));
            this.groupBox2.Controls.Add(this.maskedTextBoxDateDelivery);
            this.groupBox2.Controls.Add(this.radioButtonDelivery);
            this.groupBox2.Controls.Add(this.radioButtonPickup);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxAddressDelovery);
            this.groupBox2.Font = new System.Drawing.Font("Juice ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 139);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Получение товара";
            // 
            // maskedTextBoxDateDelivery
            // 
            this.maskedTextBoxDateDelivery.Enabled = false;
            this.maskedTextBoxDateDelivery.Location = new System.Drawing.Point(17, 111);
            this.maskedTextBoxDateDelivery.Mask = "0000/00/00";
            this.maskedTextBoxDateDelivery.Name = "maskedTextBoxDateDelivery";
            this.maskedTextBoxDateDelivery.Size = new System.Drawing.Size(75, 21);
            this.maskedTextBoxDateDelivery.TabIndex = 35;
            this.maskedTextBoxDateDelivery.ValidatingType = typeof(System.DateTime);
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Location = new System.Drawing.Point(17, 41);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(75, 18);
            this.radioButtonDelivery.TabIndex = 10;
            this.radioButtonDelivery.TabStop = true;
            this.radioButtonDelivery.Text = "Доставка";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            this.radioButtonDelivery.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonDelivery_MouseClick);
            // 
            // radioButtonPickup
            // 
            this.radioButtonPickup.AutoSize = true;
            this.radioButtonPickup.Location = new System.Drawing.Point(17, 19);
            this.radioButtonPickup.Name = "radioButtonPickup";
            this.radioButtonPickup.Size = new System.Drawing.Size(79, 18);
            this.radioButtonPickup.TabIndex = 9;
            this.radioButtonPickup.TabStop = true;
            this.radioButtonPickup.Text = "Смовывоз";
            this.radioButtonPickup.UseVisualStyleBackColor = true;
            this.radioButtonPickup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonPickup_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Желаемая дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ваш адрес";
            // 
            // textBoxAddressDelovery
            // 
            this.textBoxAddressDelovery.Enabled = false;
            this.textBoxAddressDelovery.Location = new System.Drawing.Point(17, 74);
            this.textBoxAddressDelovery.MaxLength = 50;
            this.textBoxAddressDelovery.Name = "textBoxAddressDelovery";
            this.textBoxAddressDelovery.Size = new System.Drawing.Size(219, 21);
            this.textBoxAddressDelovery.TabIndex = 5;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(221)))));
            this.buttonBuy.FlatAppearance.BorderSize = 0;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Juice ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.Location = new System.Drawing.Point(11, 246);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(178, 35);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Подтвердить";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(221)))));
            this.buttonCheck.Enabled = false;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Juice ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(195, 246);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(144, 35);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Чек";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(177)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(349, 290);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelHighMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.panelHighMenu.ResumeLayout(false);
            this.panelHighMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHighMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCARD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAddressDelovery;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCARD;
        private System.Windows.Forms.RadioButton radioButtonNAL;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonPickup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateDelivery;
        private System.Windows.Forms.Label label3;
    }
}