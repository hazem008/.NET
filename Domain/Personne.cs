using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        //Constructeur par défaut(tapper ctor)
        public Personne()
        {
           nb++;
        }
        
        //Surcharges des méthodes(méthode de mm nom mais des nombres de paramétres différents)
        public bool Login(string nom, string password)
        {
            //Méthode1:
            //var result = nom==Nom && password==Password? true:false;
            ////Méthode2:
            //if(nom==Nom&& password==password)
            //    return true;
            //else return false;
            ////Méthode3:
            return nom == Nom && password ==Password ;
        }
        public bool Login(string nom, string password,string email)
        {
           
            return nom == Nom && password == Password && email==Email;
        }

        //Redifinition des méthodes(cas d'éritage): on ajoute "virtual" dans la classe mére, on ajoute "Override" dans la classe fille
        public virtual void GetMyType()
        {
            Console.WriteLine("je suis un personne");
        }

        public Personne(string nom, string prenom, DateTime dateNaissance, string email, string password, string confirmPassword)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public int Id { get; set;}
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public static int nb { get; set; }
        public override string ToString()
        {
            return Id+" " + Nom +" "+ Prenom+" "+ DateNaissance+" "+Email+" "+Password+" "+ConfirmPassword;
        }

    }
    
}
