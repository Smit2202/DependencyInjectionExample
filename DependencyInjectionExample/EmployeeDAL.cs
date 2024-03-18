using System.Collections.Generic;
namespace DependencyInjectionDesignPattern
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                new Employee() { ID = 1, Name = "Pranaya", Department = "IT" },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR" },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll" }
            };

            foreach (Employee emp in ListEmployees)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }

            return ListEmployees;
        }
    }
}