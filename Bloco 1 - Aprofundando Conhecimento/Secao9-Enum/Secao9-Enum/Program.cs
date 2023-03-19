using Secao9_Enum.Entities;
using Secao9_Enum.Entities.Enums;
using System.Globalization;

namespace Secao9_Enum
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Coloque o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Coloque dados do trabalho: ");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salaray: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i}: contract data:");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContrat contract = new(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.department.Name}");
            Console.WriteLine($"Income for {monthAndYear} : {worker.Income(year, month)}");
        }
    }
}