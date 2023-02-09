using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmplyementDate  { get; set; }
        public string Fuction  { get; set; }
        public float Salary  { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + EmplyementDate + " " + Fuction+" "+ Salary;
        }
        public override void PassengerType()
        {
            Console.WriteLine("I am a passenger I am a Staff Member");
        }
    }
}
