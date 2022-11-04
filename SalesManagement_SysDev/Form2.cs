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

            /*
                        foreach (var M_Employee in context.M_Employees)
                        {
                            if (textBox1.Text != M_Employee.EmID)
                            {

                                //error

                            }
                            label1.Text = M_Employee.EmPassword;
                        }
            context.M_Employees.Add(newEmployee);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
            //            context.SaveChanges();

            //            M_Employee foundEmployee = context.M_Employees.Find(newEmployee.EmID = 1, newEmployee.EmPassword = "0001");
            */
            M_Employee foundEmployee = employeeDAO.findByID(Int16.Parse(textBox1.Text));
            if (foundEmployee != null && foundEmployee.EmPassword == textBox2.Text)
            {

                label1.Text = foundEmployee.EmName;

                MessageBox.Show("サインイン完了！");

            }
            else
            {

                MessageBox.Show("IDかパスワードに問題があります！");

            }

        }
    }
}
