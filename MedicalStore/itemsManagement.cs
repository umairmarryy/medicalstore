﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class itemsManagement : Form
    {
        public itemsManagement()
        {
            InitializeComponent();
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainScreen ms = new MainScreen();
            ms.Show();
            this.Hide();
        }
    }
}
