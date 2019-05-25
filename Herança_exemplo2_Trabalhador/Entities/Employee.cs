using System.Globalization;
using System.Text;

namespace Herança_exemplo2_Trabalhador.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee (string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder papper = new StringBuilder();
            papper.AppendLine("Payments:");
            papper.Append(Name);
            papper.Append(" - $ ");
            papper.Append(Payment().ToString("F2", CultureInfo.InvariantCulture);

            return papper.ToString();
        }
    }
}
