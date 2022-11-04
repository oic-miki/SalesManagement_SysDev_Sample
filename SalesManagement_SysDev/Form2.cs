using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            label1.Text = "ID:";
            label2.Text = "Password:";
            button1.Text = "Find";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeDataAccess employeeDAO = new EmployeeDataAccess();

            try
            {

                M_Employee foundEmployee = employeeDAO.findByID(Int16.Parse(textBox1.Text));
                if (foundEmployee.EmPassword.Length > 0 && foundEmployee.EmPassword == textBox2.Text)
                {

                    label1.Text = foundEmployee.EmID.ToString();
                    label2.Text = foundEmployee.EmName;


                    MessageBox.Show("サインイン完了！");

                }
                else
                {

                    MessageBox.Show("IDかパスワードに問題があります！");

                }

            }
            catch (System.FormatException fe)
            {

                MessageBox.Show("IDは必須入力です！");

            }

        }

    }

}
