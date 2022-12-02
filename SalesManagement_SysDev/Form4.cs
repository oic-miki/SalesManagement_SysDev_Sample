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

        private int index = 0;

        private String selectedText = "";

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
            int columnNumber = 0;
            dataGridView1.Columns[columnNumber++].HeaderText = "No";
            dataGridView1.Columns[columnNumber++].HeaderText = "ユーザ名";
            dataGridView1.Columns[columnNumber++].HeaderText = "年齢";
            dataGridView1.Columns[columnNumber++].HeaderText = "性別";

            // セルのデータを5行分設定
            int rowNumber = 0;

            addRowData(rowNumber++, rowNumber, "ユーザ" + rowNumber, "28", "男性");
            addRowData(rowNumber++, rowNumber, "ユーザ" + rowNumber, "22", "女性");
            addRowData(rowNumber++, rowNumber, "ユーザ" + rowNumber, "34", "女性");
            addRowData(rowNumber++, rowNumber, "ユーザ" + rowNumber, "33", "男性");
            addRowData(rowNumber++, rowNumber, "ユーザ" + rowNumber, "27", "男性");

            //dataGridView1.Rows[1].Cells[0].Value = 1;
            //dataGridView1.Rows[1].Cells[1].Value = "ユーザ1";
            //dataGridView1.Rows[1].Cells[2].Value = "28";
            //dataGridView1.Rows[1].Cells[3].Value = "男性";
            //dataGridView1.Rows[1].Cells[0].Value = 2;
            //dataGridView1.Rows[1].Cells[1].Value = "ユーザ2";
            //dataGridView1.Rows[1].Cells[2].Value = "22";
            //dataGridView1.Rows[1].Cells[3].Value = "女性";
            //dataGridView1.Rows[2].Cells[0].Value = 3;
            //dataGridView1.Rows[2].Cells[1].Value = "ユーザ3";
            //dataGridView1.Rows[2].Cells[2].Value = "34";
            //dataGridView1.Rows[2].Cells[3].Value = "女性";
            //dataGridView1.Rows[3].Cells[0].Value = 4;
            //dataGridView1.Rows[3].Cells[1].Value = "ユーザ4";
            //dataGridView1.Rows[3].Cells[2].Value = "33";
            //dataGridView1.Rows[3].Cells[3].Value = "男性";
            //dataGridView1.Rows[4].Cells[0].Value = 5;
            //dataGridView1.Rows[4].Cells[1].Value = "ユーザ5";
            //dataGridView1.Rows[4].Cells[2].Value = "27";
            //dataGridView1.Rows[4].Cells[3].Value = "男性";

            SalesManagement_DevContext context = new SalesManagement_DevContext();

            //EmployeeDataAccess employeeDAO = new EmployeeDataAccess();
//            context.M_Employees.Add(
//                 new M_Employee()
//            {
//                EmID = 1,
//                EmPassword = "0001",
//                EmName = "三木",
//                EmPhone = "012-3456-7890",
//                EmHiredate = DateTime.ParseExact("19691218", "yyyyMMdd",
//    System.Globalization.CultureInfo.InvariantCulture),
////                EmHiredate = new DateTime(),
//            }
//                );
            comboBox1.DataSource = context.M_Employees.ToList();
            //foreach (DataGridViewRow rowData in dataGridView1.Rows)
            //{

            //    comboBox1.Items.AddRange(new String[] { rowData.HeaderCell.ToString() });

            //}

        }

        private void addRowData(int rowNumber, int number, string userName, string age, string gender)
        {

            int cellNumber = 0;

            dataGridView1.Rows[rowNumber].Cells[cellNumber++].Value = number;
            dataGridView1.Rows[rowNumber].Cells[cellNumber++].Value = userName;
            dataGridView1.Rows[rowNumber].Cells[cellNumber++].Value = age;
            dataGridView1.Rows[rowNumber++].Cells[cellNumber++].Value = gender;

        }

        public DataGridViewRow nextData()
        {

            if (index == dataGridView1.RowCount)
            {

                index = 0;

            }

            return dataGridView1.Rows[index++];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedText = ((M_Employee)comboBox1.SelectedItem).EmName.ToString();
//            label1.Text = ((M_Employee) comboBox1.SelectedItem).EmName.ToString();
            label1.Text = selectedText;

        }
    }

}
