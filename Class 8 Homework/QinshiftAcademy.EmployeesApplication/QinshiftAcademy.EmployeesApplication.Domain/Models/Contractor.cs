using QinshiftAcademy.EmployeesApplication.Domain.Enums;
using QinshiftAcademy.EmployeesApplication.Domain.Models;

namespace QinshiftAcademy.EmployeesApplication.Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
      

        public Contractor(string firstName, string lastName, double workHours, int payPerHour) : base(firstName, lastName, 0, EmployeeRole.Manager)
        {
            
            WorkHours = workHours;
            PayPerHour = payPerHour;
            
        }

        public void PrintContractorInfo()
        {
            Salary = GetSalary();
            Console.WriteLine($"{FirstName} {LastName} Salary: {Salary}");
        }

        public override double GetSalary()
        {
            return WorkHours * PayPerHour;
        }



    }
 
}
