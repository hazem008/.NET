//// See https://aka.ms/new-console-template for more information
////declaration variable 
//string ch;
////type: string, int, char, double, float, bool,DateTime, long, ....

//for (int i = 0; i < 2; i++)
//{
//    ch = Console.ReadLine();

//    Console.WriteLine("Bonjour " + ch);



//    int chiffreValue = 0;

//    // do
//    //
//    try
//    {
//        string chiffre = Console.ReadLine();
//        chiffreValue = int.Parse(chiffre);
//        if (chiffreValue > 15 && chiffreValue <= 18)
//        { Console.WriteLine("Ados"); }
//        else if (chiffreValue > 18)
//        { Console.WriteLine("Adulte"); }

//    }
//    catch
//    {
//        Console.WriteLine("Erreur au niveau de conversion du chiffre");
//    }
//    //} while (chiffreValue == 0);

//    Console.WriteLine("Votre nombre est " + (chiffreValue + 1));

//}

using AM.ApplicationCore.Services;
using System.Collections;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

Personne p = new Personne();
p.Id = 11;
p.Nom = "Kharroubi";
p.Prenom = "Hazem";
p.Email = "esprit@gmail.com";
p.DateNaissance = new DateTime(2000, 12, 30);
p.Password = "password";
p.ConfirmPassword = "password";
Console.WriteLine(p) ;
Personne p1 = new Personne("nom", "prenom", DateTime.Now, "email", "password", "confirmPassword");

//Initialisateur d'objet
Personne p2 = new Personne()
{
    Nom = "nom",
    Prenom="prenom",
    DateNaissance= DateTime.Now,
    Email="email",
    Password="password",
    ConfirmPassword="confirmPassword"
};

Conducteur c = new Conducteur(); ;
p.GetMyType();
c.GetMyType();

//Création d'un objet non initialisé de type Plane
Plane plane = new Plane();
plane.PlaneId = 2;
plane.Capacity = 256;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Airbus;
Console.WriteLine(plane) ;
//Plane plane1 = new Plane(PlaneType.Boing, 125, new DateTime(2022, 11, 11));
//Console.WriteLine(plane1) ;

//Initialisateur d'objet pour
Plane plane2 = new Plane()
{
    PlaneId = 1,
    Capacity = 120,
    ManufactureDate = new DateTime(2022, 3, 19),
    PlaneType = PlaneType.Airbus
};
// 9)On remarque que l'initialistaeur d'objet nous permet de créer et intialiser un objet sans besoin d'un constructeur explicite. 

//11)
Passenger traveller = new Traveller();
Passenger staff = new Staff();  
Passenger Passenger = new Passenger();
traveller.PassengerType();
staff.PassengerType();
Passenger.PassengerType();

//collection des objets non génériques
ArrayList list= new ArrayList();
list.Add(plane);
list.Add(1);
list.Add("Bonjour");

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
foreach (var item in list)
{
    Console.WriteLine(item);
}
//collection des objets génériques
IList <Plane> planes = new List<Plane>();
//IList:Ienumerable,Icollection
//ICollection:IEnumerable
//IEnumerable: assure le parcour des listes uniquement
//ICollection: les méthode des parcours et l'insertion(add, remove, recherche ...)
planes.Add(plane);
planes.Add(plane2);
IList<Plane> planes1 = new List<Plane>()
{
    plane,plane2,new Plane(){Capacity=12,PlaneId=4, ManufactureDate=new DateTime(2022,11,11)} 
};
Personne p11= new Personne();
Console.WriteLine(Personne.nb);
Personne p22= new Personne();
Console.WriteLine(Personne.nb);
Personne p33= new Personne();
Console.WriteLine(Personne.nb);

//TP2
//5)
ServiceFlight serviceFlight=  new ServiceFlight();
serviceFlight.Flights = TestData.Flights;
//6)






