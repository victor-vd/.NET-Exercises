using Models.Employee;

namespace Properties;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.Name = "Paulo";
        emp.Age = 19;

        Console.WriteLine(emp);
    }
}
