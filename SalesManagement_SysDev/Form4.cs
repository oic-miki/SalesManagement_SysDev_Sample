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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

//            dataGridView1.RowHeadersVisible = false;
//            dataGridView1.AdvancedRowHeadersBorderStyle;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // 列数・行数を指定
    dataGridView1.ColumnCount = 4;
    dataGridView1.RowCount = 5;


    // 列名を指定
    dataGridView1.Columns[0].HeaderText = "No";
    dataGridView1.Columns[1].HeaderText = "ユーザ名";
    dataGridView1.Columns[2].HeaderText = "年齢";
    dataGridView1.Columns[3].HeaderText = "性別";


    // セルのデータを5行分設定
    dataGridView1.Rows[0].Cells[0].Value = 1;
    dataGridView1.Rows[0].Cells[1].Value = "ユーザ1";
    dataGridView1.Rows[0].Cells[2].Value = "28";
    dataGridView1.Rows[0].Cells[3].Value = "男性";
    dataGridView1.Rows[1].Cells[0].Value = 2;
    dataGridView1.Rows[1].Cells[1].Value = "ユーザ2";
    dataGridView1.Rows[1].Cells[2].Value = "22";
    dataGridView1.Rows[1].Cells[3].Value = "女性";
    dataGridView1.Rows[2].Cells[0].Value = 3;
    dataGridView1.Rows[2].Cells[1].Value = "ユーザ3";
    dataGridView1.Rows[2].Cells[2].Value = "34";
    dataGridView1.Rows[2].Cells[3].Value = "女性";
    dataGridView1.Rows[3].Cells[0].Value = 4;
    dataGridView1.Rows[3].Cells[1].Value = "ユーザ4";
    dataGridView1.Rows[3].Cells[2].Value = "33";
    dataGridView1.Rows[3].Cells[3].Value = "男性";
    dataGridView1.Rows[4].Cells[0].Value = 5;
    dataGridView1.Rows[4].Cells[1].Value = "ユーザ5";
    dataGridView1.Rows[4].Cells[2].Value = "27";
    dataGridView1.Rows[4].Cells[3].Value = "男性";
        }
    }
}
