
using AM.ApplicationCore.Domain;
using System.Collections;
using AM.ApplicationCore.Services;
using System.Collections.Generic;
using System.ComponentModel;

//string chaine = Console.ReadLine();
//float age = 0;
//try
//{
//    age = float.Parse(Console.ReadLine());

//}
//catch
//{
//    Console.WriteLine("Erreur");
//}
//Console.WriteLine("Hello" + chaine + "age : " + (age + 1));*


//Personne personne = new Personne();
//personne.Id=0;
//personne.Nom = "Mouhib";
//personne.Prenom = "Saleh";
//personne.Password = "0000";
//personne.Email = "";
//personne.DateNaissance = new DateTime(20, 12, 31, 15, 45, 54);
//Console.WriteLine(personne.ToString());
//Personne personne2 = new Personne(
//    "nom", "prenom", "email", "password", DateTime.Now
//    ) ;
//Personne personne3 = new Personne()
//{
//    Nom = "nom1",
//    Prenom = "prenom",
//    Email = "email",
//    DateNaissance = new DateTime(),
//    Password = "password",
//};
//Personne etudiant = new Etudiant();
//personne.GetMyType();
//etudiant.GetMyType();


/* Plane plane1 = new Plane();
plane1.PlaneId = 1;
plane1.Capacity = 300;
plane1.ManufactureDate = new DateTime(2022, 09, 23);
plane1.PlaneType = PlaneType.Airbus;
Console.WriteLine(plane1.ToString());
Plane plane2 = new Plane(PlaneType.Airbus, 500, DateTime.Now);
Console.WriteLine(plane2.ToString()); 
Plane p3 = new Plane()
{ Capacity = 500, PlaneType = PlaneType.Airbus, ManufactureDate = DateTime.Now };
Console.WriteLine(p3.ToString());
Passanger pass1 = new Passanger
{
    FirstName = "mariem",
    LastName = "aljene",
    EmailAddress = ""


};
ArrayList list = new ArrayList();
list.Add(pass1);

Console.WriteLine(pass1.CheckProfil("mariem", "aljene"));
pass1.PassangerType();
Staff stf = new Staff();
stf.PassangerType();

*/
ServiceFlight service = new ServiceFlight();
/* Action<String,int> action;
static void test(String a ,int v) { }

    action = test;
    action("hi",5);
Func<bool, string, Double> func;

static double test2(bool Lb, String str) { return 0; };




func = delegate (bool bol, String str)
{
    return 0;
};

double a = func(true, "hi");


action =  (String str, int nb) =>
Console.WriteLine("hi");
*/
Console.WriteLine("filter by destination");
string destinationFilter = "Paris";
Func<string, Flight, bool> destinationFilterFunc = (destination, flight) =>
    flight.Destination == destination;
service.GetFlights(destinationFilter, destinationFilterFunc);

// Example 2: filter flights by date
string dateFilter = "2023-02-20";
Func<string, Flight, bool> dateFilterFunc = (date, flight) =>
    flight.FlightDate.Equals(DateTime.Parse(date));
service.GetFlights(dateFilter, dateFilterFunc);































