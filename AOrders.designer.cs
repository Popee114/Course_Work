namespace Coursework
{
    partial class AOrders
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxOrdersUserChoose = new System.Windows.Forms.ComboBox();
            this.dataGridViewOrdersProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrders = new System.Windows.Forms.TextBox();
            this.dataGridViewOrdersDelivery = new System.Windows.Forms.DataGridView();
            this.checkBoxOrdersStatus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfirmationDelivery = new System.Windows.Forms.Button();
            this.textBoxIdDelivery = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxDeliveryStatus = new System.Windows.Forms.CheckBox();
            this.buttonResetDelivery = new System.Windows.Forms.Button();
            this.buttonDeliveryToBuyer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDeliveryChoose = new System.Windows.Forms.ComboBox();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.buttonResetOrder = new System.Windows.Forms.Button();
            this.panelConfirmationOrder = new System.Windows.Forms.Panel();
            this.buttonConfirmationOrder = new System.Windows.Forms.Button();
            this.textBoxIdBuyerOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowBuyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersDelivery)).BeginInit();
            this.groupBoxDelivery.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.panelConfirmationOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackgroundImage = global::Coursework.Properties.Resources.X;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(766, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(22, 19);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxOrdersUserChoose
            // 
            this.comboBoxOrdersUserChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdersUserChoose.FormattingEnabled = true;
            this.comboBoxOrdersUserChoose.Location = new System.Drawing.Point(13, 32);
            this.comboBoxOrdersUserChoose.Name = "comboBoxOrdersUserChoose";
            this.comboBoxOrdersUserChoose.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdersUserChoose.TabIndex = 2;
            // 
            // dataGridViewOrdersProducts
            // 
            this.dataGridViewOrdersProducts.AllowUserToAddRows = false;
            this.dataGridViewOrdersProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersProducts.Location = new System.Drawing.Point(13, 59);
            this.dataGridViewOrdersProducts.Name = "dataGridViewOrdersProducts";
            this.dataGridViewOrdersProducts.ReadOnly = true;
            this.dataGridViewOrdersProducts.Size = new System.Drawing.Size(744, 122);
            this.dataGridViewOrdersProducts.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Покупатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Общее количество заказов";
            // 
            // textBoxOrders
            // 
            this.textBoxOrders.Enabled = false;
            this.textBoxOrders.Location = new System.Drawing.Point(354, 32);
            this.textBoxOrders.Name = "textBoxOrders";
            this.textBoxOrders.Size = new System.Drawing.Size(145, 20);
            this.textBoxOrders.TabIndex = 8;
            this.textBoxOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewOrdersDelivery
            // 
            this.dataGridViewOrdersDelivery.AllowUserToAddRows = false;
            this.dataGridViewOrdersDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersDelivery.Location = new System.Drawing.Point(13, 58);
            this.dataGridViewOrdersDelivery.Name = "dataGridViewOrdersDelivery";
            this.dataGridViewOrdersDelivery.ReadOnly = true;
            this.dataGridViewOrdersDelivery.Size = new System.Drawing.Size(571, 102);
            this.dataGridViewOrdersDelivery.TabIndex = 10;
            // 
            // checkBoxOrdersStatus
            // 
            this.checkBoxOrdersStatus.AutoSize = true;
            this.checkBoxOrdersStatus.Location = new System.Drawing.Point(64, 27);
            this.checkBoxOrdersStatus.Name = "checkBoxOrdersStatus";
            this.checkBoxOrdersStatus.Size = new System.Drawing.Size(75, 17);
            this.checkBoxOrdersStatus.TabIndex = 11;
            this.checkBoxOrdersStatus.Text = "Оплачено";
            this.checkBoxOrdersStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Просмотр заказов покупателей";
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.panel1);
            this.groupBoxDelivery.Controls.Add(this.buttonResetDelivery);
            this.groupBoxDelivery.Controls.Add(this.buttonDeliveryToBuyer);
            this.groupBoxDelivery.Controls.Add(this.label4);
            this.groupBoxDelivery.Controls.Add(this.comboBoxDeliveryChoose);
            this.groupBoxDelivery.Controls.Add(this.dataGridViewOrdersDelivery);
            this.groupBoxDelivery.Location = new System.Drawing.Point(25, 237);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(593, 166);
            this.groupBoxDelivery.TabIndex = 17;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Статус заказа";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConfirmationDelivery);
            this.panel1.Controls.Add(this.textBoxIdDelivery);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBoxDeliveryStatus);
            this.panel1.Location = new System.Drawing.Point(362, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 51);
            this.panel1.TabIndex = 23;
            // 
            // buttonConfirmationDelivery
            // 
            this.buttonConfirmationDelivery.BackColor = System.Drawing.Color.Silver;
            this.buttonConfirmationDelivery.FlatAppearance.BorderSize = 0;
            this.buttonConfirmationDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmationDelivery.Location = new System.Drawing.Point(147, 23);
            this.buttonConfirmationDelivery.Name = "buttonConfirmationDelivery";
            this.buttonConfirmationDelivery.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmationDelivery.TabIndex = 20;
            this.buttonConfirmationDelivery.Text = "Применить";
            this.buttonConfirmationDelivery.UseVisualStyleBackColor = false;
            this.buttonConfirmationDelivery.Click += new System.EventHandler(this.buttonConfirmationDelivery_Click);
            // 
            // textBoxIdDelivery
            // 
            this.textBoxIdDelivery.Location = new System.Drawing.Point(9, 25);
            this.textBoxIdDelivery.Name = "textBoxIdDelivery";
            this.textBoxIdDelivery.Size = new System.Drawing.Size(49, 20);
            this.textBoxIdDelivery.TabIndex = 12;
            this.textBoxIdDelivery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdDelivery_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Номер доставки";
            // 
            // checkBoxDeliveryStatus
            // 
            this.checkBoxDeliveryStatus.AutoSize = true;
            this.checkBoxDeliveryStatus.Location = new System.Drawing.Point(64, 27);
            this.checkBoxDeliveryStatus.Name = "checkBoxDeliveryStatus";
            this.checkBoxDeliveryStatus.Size = new System.Drawing.Size(88, 17);
            this.checkBoxDeliveryStatus.TabIndex = 11;
            this.checkBoxDeliveryStatus.Text = "Доставлено";
            this.checkBoxDeliveryStatus.UseVisualStyleBackColor = true;
            // 
            // buttonResetDelivery
            // 
            this.buttonResetDelivery.BackColor = System.Drawing.Color.Silver;
            this.buttonResetDelivery.FlatAppearance.BorderSize = 0;
            this.buttonResetDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetDelivery.Location = new System.Drawing.Point(221, 30);
            this.buttonResetDelivery.Name = "buttonResetDelivery";
            this.buttonResetDelivery.Size = new System.Drawing.Size(75, 23);
            this.buttonResetDelivery.TabIndex = 22;
            this.buttonResetDelivery.Text = "Сбросить";
            this.buttonResetDelivery.UseVisualStyleBackColor = false;
            this.buttonResetDelivery.Click += new System.EventHandler(this.buttonResetDelivery_Click);
            // 
            // buttonDeliveryToBuyer
            // 
            this.buttonDeliveryToBuyer.BackColor = System.Drawing.Color.Silver;
            this.buttonDeliveryToBuyer.FlatAppearance.BorderSize = 0;
            this.buttonDeliveryToBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeliveryToBuyer.Location = new System.Drawing.Point(140, 30);
            this.buttonDeliveryToBuyer.Name = "buttonDeliveryToBuyer";
            this.buttonDeliveryToBuyer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeliveryToBuyer.TabIndex = 21;
            this.buttonDeliveryToBuyer.Text = "Применить";
            this.buttonDeliveryToBuyer.UseVisualStyleBackColor = false;
            this.buttonDeliveryToBuyer.Click += new System.EventHandler(this.buttonDeliveryToBuyer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Покупатель";
            // 
            // comboBoxDeliveryChoose
            // 
            this.comboBoxDeliveryChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeliveryChoose.FormattingEnabled = true;
            this.comboBoxDeliveryChoose.Location = new System.Drawing.Point(13, 31);
            this.comboBoxDeliveryChoose.Name = "comboBoxDeliveryChoose";
            this.comboBoxDeliveryChoose.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeliveryChoose.TabIndex = 12;
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.Controls.Add(this.buttonResetOrder);
            this.groupBoxOrders.Controls.Add(this.panelConfirmationOrder);
            this.groupBoxOrders.Controls.Add(this.buttonShowBuyer);
            this.groupBoxOrders.Controls.Add(this.textBoxOrders);
            this.groupBoxOrders.Controls.Add(this.label3);
            this.groupBoxOrders.Controls.Add(this.dataGridViewOrdersProducts);
            this.groupBoxOrders.Controls.Add(this.comboBoxOrdersUserChoose);
            this.groupBoxOrders.Controls.Add(this.label1);
            this.groupBoxOrders.Location = new System.Drawing.Point(25, 44);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(763, 187);
            this.groupBoxOrders.TabIndex = 18;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Заказы";
            // 
            // buttonResetOrder
            // 
            this.buttonResetOrder.BackColor = System.Drawing.Color.Silver;
            this.buttonResetOrder.FlatAppearance.BorderSize = 0;
            this.buttonResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetOrder.Location = new System.Drawing.Point(221, 31);
            this.buttonResetOrder.Name = "buttonResetOrder";
            this.buttonResetOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonResetOrder.TabIndex = 20;
            this.buttonResetOrder.Text = "Сбросить";
            this.buttonResetOrder.UseVisualStyleBackColor = false;
            this.buttonResetOrder.Click += new System.EventHandler(this.buttonResetOrder_Click);
            // 
            // panelConfirmationOrder
            // 
            this.panelConfirmationOrder.Controls.Add(this.buttonConfirmationOrder);
            this.panelConfirmationOrder.Controls.Add(this.textBoxIdBuyerOrder);
            this.panelConfirmationOrder.Controls.Add(this.label2);
            this.panelConfirmationOrder.Controls.Add(this.checkBoxOrdersStatus);
            this.panelConfirmationOrder.Location = new System.Drawing.Point(545, 7);
            this.panelConfirmationOrder.Name = "panelConfirmationOrder";
            this.panelConfirmationOrder.Size = new System.Drawing.Size(217, 51);
            this.panelConfirmationOrder.TabIndex = 19;
            // 
            // buttonConfirmationOrder
            // 
            this.buttonConfirmationOrder.BackColor = System.Drawing.Color.Silver;
            this.buttonConfirmationOrder.FlatAppearance.BorderSize = 0;
            this.buttonConfirmationOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmationOrder.Location = new System.Drawing.Point(136, 23);
            this.buttonConfirmationOrder.Name = "buttonConfirmationOrder";
            this.buttonConfirmationOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmationOrder.TabIndex = 20;
            this.buttonConfirmationOrder.Text = "Применить";
            this.buttonConfirmationOrder.UseVisualStyleBackColor = false;
            this.buttonConfirmationOrder.Click += new System.EventHandler(this.buttonConfirmationOrder_Click);
            // 
            // textBoxIdBuyerOrder
            // 
            this.textBoxIdBuyerOrder.Location = new System.Drawing.Point(9, 25);
            this.textBoxIdBuyerOrder.Name = "textBoxIdBuyerOrder";
            this.textBoxIdBuyerOrder.Size = new System.Drawing.Size(49, 20);
            this.textBoxIdBuyerOrder.TabIndex = 12;
            this.textBoxIdBuyerOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdBuyerOrder_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Номер покупателя";
            // 
            // buttonShowBuyer
            // 
            this.buttonShowBuyer.BackColor = System.Drawing.Color.Silver;
            this.buttonShowBuyer.FlatAppearance.BorderSize = 0;
            this.buttonShowBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowBuyer.Location = new System.Drawing.Point(140, 31);
            this.buttonShowBuyer.Name = "buttonShowBuyer";
            this.buttonShowBuyer.Size = new System.Drawing.Size(75, 23);
            this.buttonShowBuyer.TabIndex = 9;
            this.buttonShowBuyer.Text = "Применить";
            this.buttonShowBuyer.UseVisualStyleBackColor = false;
            this.buttonShowBuyer.Click += new System.EventHandler(this.buttonShowBuyer_Click);
            // 
            // AOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.groupBoxOrders);
            this.Controls.Add(this.groupBoxDelivery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExit);
            this.Name = "AOrders";
            this.Load += new System.EventHandler(this.AOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersDelivery)).EndInit();
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            this.panelConfirmationOrder.ResumeLayout(false);
            this.panelConfirmationOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxOrdersUserChoose;
        private System.Windows.Forms.DataGridView dataGridViewOrdersProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrdersDelivery;
        private System.Windows.Forms.CheckBox checkBoxOrdersStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDeliveryChoose;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.Button buttonShowBuyer;
        private System.Windows.Forms.TextBox textBoxIdBuyerOrder;
        private System.Windows.Forms.Panel panelConfirmationOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirmationOrder;
        private System.Windows.Forms.Button buttonResetOrder;
        private System.Windows.Forms.Button buttonResetDelivery;
        private System.Windows.Forms.Button buttonDeliveryToBuyer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfirmationDelivery;
        private System.Windows.Forms.TextBox textBoxIdDelivery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxDeliveryStatus;
    }
}