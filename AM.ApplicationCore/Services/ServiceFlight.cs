using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
       
    {
     
        public List<Flight> listFlights { get; set; } = TestData.Flights;
        public static int MyProperty { get; set; }
        
        public IEnumerable<DateTime> getFlightDates(string Destination)
        {
         //   List<DateTime> dates = new List<DateTime>();
 /*           for (int i = 0; i < listFlights.Count; i++)
            {
                if (listFlights[i].Destination == Destination)
                {
                    dates.Add(listFlights[i].FlightDate);
                }
            }
 */
            foreach (Flight flight in listFlights)
            {
                if (flight.Destination== Destination)
                {
                    yield return flight.FlightDate;
                }
            }
           
        }

        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func)
        {
            Func<string,Flight,Boolean> condition = func;
            foreach (Flight item in listFlights)
            {
                if (condition(filterValue, item))
                {
                    Console.WriteLine(item);
                }
            }
        }













        //LINK requete
        public IList<DateTime> GetFlightDateslinq(string destination)
        {
            var query = from f in listFlights where f.Destination == destination select f.FlightDate;
            return query.ToList();
        }
        //Link methodes
        public IList<DateTime> GetFlightDateslinq2(string destination)
        {
            var query = listFlights.
           Where(f => f.Destination == destination)
           .Select(f => f.FlightDate);
            return query.ToList();

        }
        // LINK RequeteImp
        public void ShowFlightDetailsDel(Plane plane)
        {
            var req = from f in listFlights
                      where (f.plane == plane)
                      select new { f.FlightDate, f.Destination };
            foreach (var item in req)
            {
                Console.WriteLine(item.Destination + " " + item.FlightDate);
            }
        }
        // LINK methodImp
        public void ShowFlightDetails2(Plane plane)
        {

            var req = listFlights.Where(f => f.plane == plane).Select(f => new { f.FlightDate, f.Destination });
            foreach (var item in req)
            {
                Console.WriteLine(item.Destination + " " + item.FlightDate);
            }
        }
        //Retourner le nombre de vols programmés pour une semaine(7jours) à partir d’une date
        // donnée

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            return listFlights.Where(f => f.FlightDate > startDate && ((f.FlightDate - startDate).TotalDays < 7)).Count();
        }

        // LINK Syntaxe
        public IList<Flight> OrderedDurationFlights()
        {
            var query = from f in listFlights orderby f.EstimatedDuration descending select f;
            return query.ToList();
        }
        // LINK des methodes
        public IList<Flight> OrderedDurationFlights2()
        {
            return listFlights.OrderByDescending(f => f.FlightDate).ToList();
        }
        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            var query = (from f in listFlights where f.FlightId == flight.FlightId select f).Single();
            return query.passangers.OfType<Traveller>().ToList().OrderBy(p => p.BirthDate).Take(3).ToList();
        }
        public double DurationAverageDel(string destination)
        {
            //var query = from f in Flights
            //where f.Destination == destination select f;
            //return query.Average (f=>f.EstimatedDuration);
            var query = listFlights
            .Where(f => f.Destination == destination)
            .Average(f => f.EstimatedDuration);
            return query;
        }
       
       
















    }
}
