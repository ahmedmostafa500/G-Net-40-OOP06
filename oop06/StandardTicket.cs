using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
    internal class StandardTicket:Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movie, decimal price, string seat)
            : base(movie, price)
        {
            SeatNumber = seat;
        }

        public override string TicketType => "Standard";

        public override decimal CalculateFinalPrice()
        {
            return Price * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
