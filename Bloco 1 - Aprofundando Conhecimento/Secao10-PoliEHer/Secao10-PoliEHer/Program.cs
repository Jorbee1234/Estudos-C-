
using Secao10_PoliEHer.Entities;
using System.Globalization;

namespace Secao10_PoliEHer
{
    public class Program
    {
        static void Main(String[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Digite o número de empregados: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                OutsourceEmployee outsource = new();
                Console.WriteLine($"Emprado #{i} dados: ");
                Console.WriteLine("Terceirizado (s/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                outsource.Name = Console.ReadLine();
                Console.WriteLine("Horas: ");
                outsource.Hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor por hora: ");
                outsource.ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 's')
                {
                    Console.WriteLine("Valor adicional: ");
                    outsource.AdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(outsource);
                }
                else
                {
                    list.Add(outsource);
                }

                Console.WriteLine("Pagamentos :");
                foreach(Employee emp in list)
                {
                    Console.WriteLine(emp.ValuePerHour);
                }
            }
        }
    }
}