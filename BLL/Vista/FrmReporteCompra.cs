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
    public partial class FrmReporteCompra : Form
    {
        public FrmReporteCompra()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void FrmReporteCompra_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtfechainicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            menu formInicio = new menu();
            formInicio.Show();

            this.Hide();
            formInicio.FormClosed += (s, args) => this.Close();
        }
    }
}
