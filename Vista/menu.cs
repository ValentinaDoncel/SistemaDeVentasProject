﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmDetalleCl formuser = new FrmDetalleCl();
            formuser.Show();

            this.Hide();
            formuser.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            ///
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            FrmReporteCompra formIRcompra = new FrmReporteCompra();
            formIRcompra.Show();

            this.Hide();
            formIRcompra.FormClosed += (s, args) => this.Close();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            FrmDetalleCl formUser = new FrmDetalleCl();
            formUser.Show();

            this.Hide();
            formUser.FormClosed += (s, args) => this.Close();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            FrmFactura formFacture = new FrmFactura();
            formFacture.Show();

            this.Hide();
            formFacture.FormClosed += (s, args) => this.Close();
        }
    }
    
}
