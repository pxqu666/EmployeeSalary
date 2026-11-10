using System.Collections.Generic;

public class EmployeeListInitializer
{
    private static List<Employee> _employees;

    public static List<Employee> GetEmployees()
    {
        if (_employees == null)
        {
            _employees = new List<Employee>
            {
                new FullTimeEmployee("Anna", 1200m),
                new HourlyEmployee("Jânis", 8m, 100),
                new SalesEmployee("Marta", 600m, 2000m)
            };
        }
        return _employees;
    }
}