﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Form4 form4 = new Form4();
            form4.TopLevel = false;
            panel1.Controls.Add(form4);
            form4.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
