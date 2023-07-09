
using System.Net;

List<Department> departments = new List<Department>();

int numberOfEmployees = int.Parse(Console.ReadLine()!);

for (int i = 0; i < numberOfEmployees; i++)
{
    string[] commandTokens = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

    string name = commandTokens[0];
    decimal salary = decimal.Parse(commandTokens[1]);
    string department = commandTokens[2];

    if (!departments.Any(x => x.DepartmentName == department))

    {
        departments.Add(new Department(department));
    }

    departments.Find(x => x.DepartmentName == department).AddNewEmployee(name, salary);

}

Department bestDepartment = departments.OrderByDescending(x => x.TotalSalaries / x.Employees.Count()).First();
Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

foreach (var employee in bestDepartment.Employees.OrderByDescending(x => x.Salary))
{
    Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
}


public class Employee
{
    public Employee(string name, decimal salary)
    {
        this.Name = name;
        this.Salary = salary;
       
    }

    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

}

public class Department
{
    public string DepartmentName { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();
    public decimal TotalSalaries { get; set; }
    public void AddNewEmployee(string employerName, decimal employerSalary)
    {
        this.TotalSalaries += employerSalary;

        this.Employees.Add(new Employee(employerName, employerSalary));
    }

    public Department(string departmentName)
    {
        this.DepartmentName = departmentName;
    }
}