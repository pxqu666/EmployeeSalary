// See https://aka.ms/new-console-template for more information

var employees = EmployeeListInitializer.GetEmployees();

foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}

var payroll = new PayrollCalculator();
Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");
