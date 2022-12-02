using System;
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

        Form4 form4;

        public Form3()
        {
            InitializeComponent();

            form4 = new Form4();
            form4.TopLevel = false;
            panel1.Controls.Add(form4);
            form4.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow rowData = form4.nextData();

            int cellNumber = 0;

            label1.Text = rowData.Cells[cellNumber++].Value.ToString();
            label2.Text = rowData.Cells[cellNumber++].Value.ToString();
            label3.Text = rowData.Cells[cellNumber++].Value.ToString();
            label4.Text = rowData.Cells[cellNumber++].Value.ToString();

        }
    }
}
