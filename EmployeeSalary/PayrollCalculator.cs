public class PayrollCalculator
{
    // Polimorfisms redzams foreach ciklâ, kur katrs Employee objekts 
    // (neatkarîgi no tâ vai tas ir FullTimeEmployee, HourlyEmployee vai SalesEmployee)
    // izsauc savu paðrealizçto CalculateSalary() metodi. PayrollCalculator nebija jâmaina,
    // jo tas darbojas ar abstraktâ klase Employee un tâs CalculateSalary() metodi,
    // nevis ar konkrçtâm klasçm. Tas ir Liskovas substitûcijas princips - jebkura 
    // klase, kas manto Employee, var aizvietot to bez koda maiòas.
    public decimal TotalSalary(List<Employee> employees)
    {
        decimal total = 0m;
        foreach (Employee employee in employees)
        {
            total += employee.CalculateSalary();
        }
        return total;
    }
}