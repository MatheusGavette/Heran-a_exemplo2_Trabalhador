using System.Globalization;
using System.Text;

namespace Herança_exemplo2_Trabalhador.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee (string name, int hours, double valuePerHours, double additionalCharge) 
            : base (name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.10);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
