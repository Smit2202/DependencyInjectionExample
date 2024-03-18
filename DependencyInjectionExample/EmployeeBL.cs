using System.Collections.Generic;
namespace DependencyInjectionDesignPattern
{
    public class EmployeeBL
    {
        public IEmployeeDAL? _employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDAL.SelectAllEmployees();
        }
    }
}