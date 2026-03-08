using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
    public abstract class Ticket
    {
        private static int counter = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Price = price;
        }

        public abstract decimal CalculateFinalPrice();

        public virtual string TicketType => "General";

        public void Book()
        {
            IsBooked = true;
        }

        public void Cancel()
        {
            IsBooked = false;
        }

        public virtual void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | {TicketType} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
