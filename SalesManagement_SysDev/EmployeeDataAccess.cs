using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    public class EmployeeDataAccess
    {

        public M_Employee findByID(int id)
        {

//            M_Employee employee = actualEmployee(id); // 本物
            M_Employee employee = mockEmployee(id); // 偽物

            return employee;

        }

        private M_Employee mockEmployee(int id)
        {

            if (id == 1)
            {

                return new M_Employee()
                {
                    EmID = 1,
                    EmPassword = "0001",
                    EmName = "三木",
                };

            }

            return new M_Employee()
            {
                EmID = 0,
                EmPassword = "",
                EmName = "",
            };

        }

        private M_Employee actualEmployee(int id)
        {

            SalesManagement_DevContext context = new SalesManagement_DevContext();

            //            M_Employee conditionEmployee = new M_Employee();

            M_Employee conditionEmployee = new M_Employee()
            {
                EmID = 1,
                EmPassword = "0001",
                EmName = "三木",
            };

            context.M_Employees.Add(conditionEmployee);
            context.SaveChanges();

            M_Employee foundEmployee = context.M_Employees.Find(conditionEmployee.EmID = id);

            context.Dispose();

            return conditionEmployee;

        }

    }


}
