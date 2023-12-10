namespace Employees_Heirachy.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string? EmployeeNumber { get; set; }
        public decimal Salary { get; set; }
        public string? Role { get; set; }
        public string? ReportingLineManager { get; set; }
        public string? EmailAddress { get; set; }


        public Employee()
        {

        }
    }
}