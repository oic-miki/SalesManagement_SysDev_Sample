using System;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace SalesManagement_SysDev
{
    public class EmployeeDataAccess
    {

        public M_Employee findByID(int id)
        {

            // DBアクセス
            M_Employee employee = find(id);
            if (employee != null)
            {

                return employee;

            }

            return mock(0);

        }

        private M_Employee mock(int id)
        {

            if (id != 1)
            {

                return new M_Employee() // NullObject の返却
                {
                    EmID = 0,
                    EmPassword = "",
                    EmName = "",
                    EmPhone = "000-0000-0000",
                    EmHiredate = DateTime.ParseExact("20221111", "yyyyMMdd",
    System.Globalization.CultureInfo.InvariantCulture),
                    //                EmHiredate = new DateTime(),
                };

            }

            return new M_Employee()
            {
                EmID = 1,
                EmPassword = "0001",
                EmName = "三木",
                EmPhone = "012-3456-7890",
                EmHiredate = DateTime.ParseExact("19691218", "yyyyMMdd",
    System.Globalization.CultureInfo.InvariantCulture),
//                EmHiredate = new DateTime(),
            };

        }

        private M_Employee find(int id)
        {

            M_Employee conditionEmployee = mock(id);

            SalesManagement_DevContext context = new SalesManagement_DevContext();
            DbContextTransaction transaction = context.Database.BeginTransaction();

            context.M_Employees.Add(conditionEmployee);

            try
            {

                context.SaveChanges();

                Console.WriteLine("SaveChanges()");
                transaction.Commit();

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

            // データの検索
            M_Employee foundEmployee = context.M_Employees.Find(id);
//            M_Employee foundEmployee = context.M_Employees.Find(conditionEmployee.EmID = id);

            context.Dispose();

            return foundEmployee;

        }

    }

}
