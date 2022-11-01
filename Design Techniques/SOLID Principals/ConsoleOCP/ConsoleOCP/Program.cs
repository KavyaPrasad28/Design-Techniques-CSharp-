using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOCP
{
    /// <summary>
    /// OCP - Open Closed Priciple
    /// "A software module/class is open for extension and closed for modification".
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new ExecutiveModel { FirstName = "Jasir", LastName = "Fayas"},
                new ManagerModel { FirstName = "Deepthi", LastName = "James"},
                new PersonModel { FirstName = "Hari", LastName = "Prasad"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.isManager} isExecutive: {emp.isExecutive}");
            }
        }
    }
}
