using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeeModel employee = new EmployeeModel();
            EmployeeRepo employeeRepo = new EmployeeRepo();
            //employeeRepo.GetAllEmployee();
            employee.EmployeeName = "Sandeep";
            employee.Department = "Sales";
            employee.PhoneNumber = "9863584931";
            employee.Address = "9865 KY Street";
            employee.Gender = "M";
            employee.BasicPay = 10000.00M;
            employee.Deductions = 1500.00;
            employee.StartDate = Convert.ToDateTime("2012-11-03");
           
            employee.EmployeeID = 2;
            employee.BasicPay = 3000000;
            
            employeeRepo.AddEmployee(employee);
               
        }
    }
}
