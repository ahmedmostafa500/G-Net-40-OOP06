using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
    public partial class Cinema
    {
        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (var t in tickets)
            {
                if (t != null)
                    t.Print();
            }
        }
    }
}
