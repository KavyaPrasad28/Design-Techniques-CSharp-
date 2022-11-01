using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAdapterPattern
{
    /// <summary>
    /// the Adapter class creates the instance of the Adaptee class within itself and resolves the incompatibility. This way of implementation is termed as Object Adapter Pattern.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService service = new EmployeeService();
            var employee = service.GetEmployee(1001);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1004);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1020);
            PrintEmployeeDetails(employee);
            employee = service.GetEmployee(1002);
            PrintEmployeeDetails(employee);
        }
        static void PrintEmployeeDetails(Employee employee)
        {
            if (employee != null)
                Console.WriteLine(employee);
            else
                Console.WriteLine("Employee not found");
        }
    }
}
