using FoodManagementResutaurant.ProgramFroms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManagementResutaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void KitchenButton_Click(object sender, EventArgs e)
        {
            

          //  KitchenButton.FillColor = Color.DarkRed; // cor normal
            KitchenButton.HoverState.FillColor = Color.Red; // cor quando mouse passa
          //  KitchenButton.PressedColor = Color.Black; // cor de clique (borda/efeito)
           
        }

        public void AddControlsToCenterPanel(Form form)
        {
            centerPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            centerPanel.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
