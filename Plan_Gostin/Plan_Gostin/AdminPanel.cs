﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}