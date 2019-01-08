namespace Client
{
    partial class MainMenu
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.historySideBarBtn = new System.Windows.Forms.Button();
            this.orderSideBarBtn = new System.Windows.Forms.Button();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.profileSideBarBtn = new System.Windows.Forms.Button();
            this.sideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.sideBarPanel.Controls.Add(this.historySideBarBtn);
            this.sideBarPanel.Controls.Add(this.orderSideBarBtn);
            this.sideBarPanel.Controls.Add(this.profileSideBarBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(267, 572);
            this.sideBarPanel.TabIndex = 0;
            // 
            // historySideBarBtn
            // 
            this.historySideBarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.historySideBarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.historySideBarBtn.FlatAppearance.BorderSize = 0;
            this.historySideBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historySideBarBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historySideBarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historySideBarBtn.Location = new System.Drawing.Point(0, 135);
            this.historySideBarBtn.Name = "historySideBarBtn";
            this.historySideBarBtn.Size = new System.Drawing.Size(279, 69);
            this.historySideBarBtn.TabIndex = 2;
            this.historySideBarBtn.Text = "History";
            this.historySideBarBtn.UseVisualStyleBackColor = false;
            this.historySideBarBtn.Click += new System.EventHandler(this.historySideBarBtn_Click);
            // 
            // orderSideBarBtn
            // 
            this.orderSideBarBtn.BackColor = System.Drawing.Color.Tomato;
            this.orderSideBarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.orderSideBarBtn.FlatAppearance.BorderSize = 0;
            this.orderSideBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderSideBarBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSideBarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderSideBarBtn.Location = new System.Drawing.Point(0, 69);
            this.orderSideBarBtn.Name = "orderSideBarBtn";
            this.orderSideBarBtn.Size = new System.Drawing.Size(279, 69);
            this.orderSideBarBtn.TabIndex = 1;
            this.orderSideBarBtn.Text = "Order";
            this.orderSideBarBtn.UseVisualStyleBackColor = false;
            this.orderSideBarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Location = new System.Drawing.Point(266, -1);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(805, 575);
            this.ParentPanel.TabIndex = 1;
            // 
            // profileSideBarBtn
            // 
            this.profileSideBarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.profileSideBarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profileSideBarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.profileSideBarBtn.FlatAppearance.BorderSize = 0;
            this.profileSideBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileSideBarBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileSideBarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileSideBarBtn.Image = global::Client.Properties.Resources.username_small;
            this.profileSideBarBtn.Location = new System.Drawing.Point(0, 4);
            this.profileSideBarBtn.Name = "profileSideBarBtn";
            this.profileSideBarBtn.Size = new System.Drawing.Size(279, 69);
            this.profileSideBarBtn.TabIndex = 0;
            this.profileSideBarBtn.UseVisualStyleBackColor = false;
            this.profileSideBarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button historySideBarBtn;
        private System.Windows.Forms.Button orderSideBarBtn;
        private System.Windows.Forms.Button profileSideBarBtn;
        private System.Windows.Forms.Panel ParentPanel;
    }
}