namespace FoodManagementResutaurant.ProgramFroms
{
    partial class SampleViewForm
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
            this.searchTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchStaticLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.headerText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // searchTxtb
            // 
            this.searchTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtb.DefaultText = "";
            this.searchTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxtb.IconLeft = global::FoodManagementResutaurant.Properties.Resources._3844432_magnifier_search_zoom_icon;
            this.searchTxtb.IconLeftSize = new System.Drawing.Size(30, 30);
            this.searchTxtb.Location = new System.Drawing.Point(452, 154);
            this.searchTxtb.Name = "searchTxtb";
            this.searchTxtb.PasswordChar = '\0';
            this.searchTxtb.PlaceholderText = "Search Here";
            this.searchTxtb.SelectedText = "";
            this.searchTxtb.Size = new System.Drawing.Size(336, 49);
            this.searchTxtb.TabIndex = 0;
            // 
            // searchStaticLabel
            // 
            this.searchStaticLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaticLabel.Location = new System.Drawing.Point(452, 130);
            this.searchStaticLabel.Name = "searchStaticLabel";
            this.searchStaticLabel.Size = new System.Drawing.Size(52, 18);
            this.searchStaticLabel.TabIndex = 1;
            this.searchStaticLabel.Text = "Search";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButton1.Image = global::FoodManagementResutaurant.Properties.Resources._3669477_add_box_ic_icon;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(12, 154);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButton1.Size = new System.Drawing.Size(57, 49);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // headerText
            // 
            this.headerText.BackColor = System.Drawing.Color.Transparent;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(17, 130);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(101, 22);
            this.headerText.TabIndex = 3;
            this.headerText.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(19, 254);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(762, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // SampleViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.searchStaticLabel);
            this.Controls.Add(this.searchTxtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleViewForm";
            this.Text = "SampleViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchTxtb;
        private Guna.UI2.WinForms.Guna2HtmlLabel searchStaticLabel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerText;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}