namespace Coursework
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.btnAOrders = new System.Windows.Forms.Button();
            this.btnAWarehouse = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.panelADesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAOrders
            // 
            this.btnAOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAOrders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAOrders.FlatAppearance.BorderSize = 0;
            this.btnAOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAOrders.Location = new System.Drawing.Point(302, 0);
            this.btnAOrders.Name = "btnAOrders";
            this.btnAOrders.Size = new System.Drawing.Size(99, 35);
            this.btnAOrders.TabIndex = 0;
            this.btnAOrders.Text = "Заказы";
            this.btnAOrders.UseVisualStyleBackColor = true;
            this.btnAOrders.Click += new System.EventHandler(this.btnAOrders_Click);
            // 
            // btnAWarehouse
            // 
            this.btnAWarehouse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAWarehouse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAWarehouse.FlatAppearance.BorderSize = 0;
            this.btnAWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAWarehouse.Location = new System.Drawing.Point(400, 0);
            this.btnAWarehouse.Name = "btnAWarehouse";
            this.btnAWarehouse.Size = new System.Drawing.Size(99, 35);
            this.btnAWarehouse.TabIndex = 1;
            this.btnAWarehouse.Text = "Склад";
            this.btnAWarehouse.UseVisualStyleBackColor = true;
            this.btnAWarehouse.Click += new System.EventHandler(this.btnAWarehouse_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonMessage);
            this.panelMenu.Controls.Add(this.buttonDeleteUser);
            this.panelMenu.Controls.Add(this.btnAWarehouse);
            this.panelMenu.Controls.Add(this.btnAOrders);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 35);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMessage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMessage.FlatAppearance.BorderSize = 0;
            this.buttonMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessage.Location = new System.Drawing.Point(144, 0);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(158, 35);
            this.buttonMessage.TabIndex = 3;
            this.buttonMessage.Text = "Сообщения пользователей";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Location = new System.Drawing.Point(499, 0);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(158, 35);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Удалить пользователя";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // panelADesktop
            // 
            this.panelADesktop.BackgroundImage = global::Coursework.Properties.Resources.Rjp8V567EVo;
            this.panelADesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelADesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelADesktop.Location = new System.Drawing.Point(0, 35);
            this.panelADesktop.Name = "panelADesktop";
            this.panelADesktop.Size = new System.Drawing.Size(800, 415);
            this.panelADesktop.TabIndex = 3;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelADesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buzz";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAOrders;
        private System.Windows.Forms.Button btnAWarehouse;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelADesktop;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonMessage;
    }
}