using DependencyInjectionDesignPattern;

namespace DependencyInjectionDesignPattern
{
    class DependencyInjectionDesignPattern
    {
        public static void Main(string[] args)
        {
            EmployeeBL employeeBLobj = new EmployeeBL(new EmployeeDAL());
            employeeBLobj.GetAllEmployees(); 
        }
    }
}
