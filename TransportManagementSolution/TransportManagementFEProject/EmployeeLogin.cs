using System;
using System.Collections.Generic;
using System.Text;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    public class EmployeeLogin
    {
        ILogin<Employee> repo;

        public EmployeeLogin()
        {
            repo = new EmployeeRepo();
        }
        public void Register()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDetails();
            repo.Add(employee);

        }
        public void Login()
        {
            Employee employee = new Employee();
            Console.WriteLine(" Please enter the username");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the password");
            if (repo.Login(employee))
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Invalid username or password");
        }
    }
}
