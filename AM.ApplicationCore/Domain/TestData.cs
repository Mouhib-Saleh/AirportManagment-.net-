using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>() { new Plane() { Capacity = 150, ManufactureDate = new DateTime(), PlaneType = PlaneType.Boing }, new Plane() { Capacity = 250, ManufactureDate = new DateTime(), PlaneType = PlaneType.Airbus } };
        public static List<Staff> Staffs { get; set; } = new List<Staff>() { new Staff() { FirstName = "Captain", LastName = "Captain", EmailAddress = "fdfffdf", BirthDate = new DateTime(), EmployementDate = new DateTime(), Salary = 90099 } };
        public static List<Traveller> Travellers { get; set; } = new List<Traveller> { new Traveller() { FirstName="Travaller1" ,LastName="Travaller1" , EmailAddress="ffdfdfdfdf",BirthDate=new DateTime(),HealthInformation="no trouble",Nationality="Amercian"} };
        public static List<Flight> Flights { get; set; } = new List<Flight> { new Flight() { FlightDate=new DateTime(),Destination="Paris",EffectiveArrival=new DateTime(), plane = Planes[1], EstimatedDuration = 110, passangers = new List<Passanger>(Travellers) } };
    }
}
