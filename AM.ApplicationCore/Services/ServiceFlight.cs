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

       
    }
}
