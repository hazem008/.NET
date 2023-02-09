using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    // le conducteur hérite de la classe personne
    public class Conducteur:Personne
    {
        public DateTime DatePermis { get; set; }
        public string TypePermis { get; set; }

        public override void GetMyType()
        {
            Console.WriteLine("je suis un conducteur");
        }
        public override string ToString()
        {
            return base.ToString()+" "+DatePermis+" "+TypePermis;
        }
    }
}
