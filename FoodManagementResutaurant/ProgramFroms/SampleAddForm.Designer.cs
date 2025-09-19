namespace FoodManagementResutaurant.ProgramFroms
{
    partial class SampleAddForm
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
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groundPanelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groundPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.HeaderLbl);
            this.topPanel.Controls.Add(this.guna2PictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.FillColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 151);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.ForeColor = System.Drawing.Color.White;
            this.HeaderLbl.Location = new System.Drawing.Point(194, 56);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(73, 24);
            this.HeaderLbl.TabIndex = 3;
            this.HeaderLbl.Text = "Header";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 125);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // groundPanelMenu
            // 
            this.groundPanelMenu.Controls.Add(this.closeButton);
            this.groundPanelMenu.Controls.Add(this.saveButton);
            this.groundPanelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groundPanelMenu.FillColor = System.Drawing.Color.Gainsboro;
            this.groundPanelMenu.FillColor2 = System.Drawing.Color.Gainsboro;
            this.groundPanelMenu.Location = new System.Drawing.Point(0, 466);
            this.groundPanelMenu.Name = "groundPanelMenu";
            this.groundPanelMenu.Size = new System.Drawing.Size(800, 78);
            this.groundPanelMenu.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.AutoRoundedCorners = true;
            this.closeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.closeButton.BorderRadius = 23;
            this.closeButton.CustomizableEdges.TopRight = false;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.FillColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(179, 18);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(156, 48);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoRoundedCorners = true;
            this.saveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.BorderRadius = 23;
            this.saveButton.CustomizableEdges.TopRight = false;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(126)))));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(6, 18);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 48);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "SAVE";
            // 
            // SampleAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.groundPanelMenu);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleAddForm";
            this.Load += new System.EventHandler(this.SampleAddForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groundPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public System.Windows.Forms.Label HeaderLbl;
        public Guna.UI2.WinForms.Guna2Button saveButton;
        public Guna.UI2.WinForms.Guna2Button closeButton;
        public Guna.UI2.WinForms.Guna2Panel topPanel;
        public Guna.UI2.WinForms.Guna2GradientPanel groundPanelMenu;
    }
}