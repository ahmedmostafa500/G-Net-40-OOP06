using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
    internal class IMAXTicket:Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, decimal price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;
        }

        public override string TicketType => "IMAX";

        public override decimal CalculateFinalPrice()
        {
            return Price * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
