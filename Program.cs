using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1IsHere
{
    public abstract class Organization
    {
        public string Name { get; set; }

        public Organization(string name)
        {
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Організація: {Name}");
        }

        public override bool Equals(object obj)
        {
            if (obj is Organization other)
                return this.Name == other.Name;
            return false;
        }

        public override int GetHashCode() => Name.GetHashCode();
    }

    public class InsuranceCompany : Organization
    {
        public string AgentName { get; set; }
        public int PolicyCount { get; set; }
        public double TotalAmount { get; set; }

        public InsuranceCompany(string name, string agent, int policies, double amount)
            : base(name)
        {
            AgentName = agent;
            PolicyCount = policies;
            TotalAmount = amount;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Страхова компанія '{Name}': Агент {AgentName}, " +
                              $"Кількість полісів: {PolicyCount}, Сума: {TotalAmount} грн.");
        }
    }

    public class ConstructionCompany : Organization
    {
        public string ForemanName { get; set; }
        public double Estimate { get; set; }
        public double Area { get; set; }

        public ConstructionCompany(string name, string foreman, double estimate, double area)
            : base(name)
        {
            ForemanName = foreman;
            Estimate = estimate;
            Area = area;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Будівельна компанія '{Name}': Прораб {ForemanName}, " +
                              $"Смета: {Estimate} грн, Площа: {Area} кв.м.");
        }
    }

    public class MetroBuild : Organization
    {
        public string RouteName { get; set; }
        public int PassengerCount { get; set; }
        public double Distance { get; set; }

        public MetroBuild(string name, string route, int passengers, double distance)
            : base(name)
        {
            RouteName = route;
            PassengerCount = passengers;
            Distance = distance;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Метробуд '{Name}': Маршрут '{RouteName}', " +
                              $"Пасажирів: {PassengerCount}, Відстань: {Distance} км.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Organization> organizations = new List<Organization>
            {
                new InsuranceCompany("ТАС", "Рубан", 150, 500000),
                new ConstructionCompany("КАН Девелопмент", "Муляр", 2000000, 1200.5),
                new MetroBuild("Київський Метрополітен", "Синя гілка", 45000, 22.7)
            };

            Console.WriteLine("Пізнє зв'язування");
            foreach (var org in organizations)
            {
                org.DisplayInfo();
            }

            Console.WriteLine("\nРаннє зв'язування");
            InsuranceCompany specificCompany = new InsuranceCompany("Тест", "Тестовий", 1, 100);
            specificCompany.DisplayInfo();

            Console.WriteLine("\nПеревірка методу Equals");
            Organization org1 = new MetroBuild("Метро", "А", 10, 5);
            Organization org2 = new MetroBuild("Метро", "Б", 20, 10);
            Console.WriteLine($"Чи однакові назви організацій (Equals): {org1.Equals(org2)}");

            Console.ReadKey();
        }
    }
}