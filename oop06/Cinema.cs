using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
     public partial class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    break;
                }
            }
        }

        public Ticket[] GetTickets()
        {
            return tickets;
        }
    }
}
