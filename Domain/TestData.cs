using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>() {

        new Plane (){
        PlaneType=PlaneType.Boing,
        Capacity=150,
        ManufactureDate=new DateTime(2015,02,03)
        },
        new Plane (){
        PlaneType=PlaneType.Airbus,
        Capacity=250,ManufactureDate=new DateTime(2020,11,11)
        }
        };
        public static List<Staff> Staff { get; set; } = new List<Staff>() {
        new Staff()
        {
            FirstName="captain",
            LastName="capitain",
            EmailAddress="Captain.captain@gmail.com",
            BirthDate=new DateTime(1965,01,01),
            EmplyementDate=new DateTime(1999,01,01),
            Salary=99999
        },
          new Staff()
        {
            FirstName="hostess1",
            LastName="hostess1",
            EmailAddress="hostess1.hostess1@gmail.com",
            BirthDate=new DateTime(1995,01,01),
            EmplyementDate=new DateTime(2020,01,01),
            Salary=999
        },
          new Staff()
        {
            FirstName="hostess2",
            LastName="hostess2",
            EmailAddress="hostess2.hostess2@gmail.com",
            BirthDate=new DateTime(1996,01,01),
            EmplyementDate=new DateTime(2020,01,01),
            Salary=999
        }
        };
        public static List<Traveller> Traveller { get; set; } = new List<Traveller>() {
        new Traveller()
        {
            FirstName="Traveller1",
            LastName="Traveller1",
            EmailAddress="Traveller1.Traveller1@gmail.com",
            BirthDate=new DateTime(1980,01,01),
            HealthInformation="No troubles",
            Nationality="Amercan"
        },
        new Traveller()
          {
            FirstName="Traveller2",
            LastName="Traveller2",
            EmailAddress="Traveller2.Traveller2@gmail.com",
            BirthDate=new DateTime(1981,01,01),
            HealthInformation="Some troubles",
            Nationality="Frensh"
        },
        new Traveller()
          {
            FirstName="Traveller3",
            LastName="Traveller3",
            EmailAddress="Traveller3.Traveller3@gmail.com",
            BirthDate=new DateTime(1982,01,01),
            HealthInformation="No troubles",
            Nationality="Tunisian"
        },
         new Traveller()
          {
            FirstName="Traveller4",
            LastName="Traveller4",
            EmailAddress="Traveller4.Traveller4@gmail.com",
            BirthDate=new DateTime(1983,01,01),
            HealthInformation="Some troubles",
            Nationality="American"
        },
         new Traveller()
        {
            FirstName="Traveller5",
            LastName="Traveller5",
            EmailAddress="Traveller5.Traveller5@gmail.com",
            BirthDate=new DateTime(1984,01,01),
            HealthInformation="Some troubles",
            Nationality="Spanish"
        },
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
                FlightDate=new DateTime(2022,01,01,15,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                plane= Planes[1],
                EstimateDuration=110,
                passengers= new List<Passenger>(Traveller),

            },
              new Flight()
            {
                FlightDate=new DateTime(2022,02,01,21,10,10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 02, 01, 23, 10, 10),
                plane= Planes[1],
                EstimateDuration=110,
                passengers= new List<Passenger>(Traveller),

            },
        };

    }
}
