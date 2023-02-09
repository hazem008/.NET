using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + HealthInformation + " " + Nationality;
        }
        public virtual void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a Traveller");
        }
    }
}
