using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
    internal class VIPTicket:Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50;

        public VIPTicket(string movie, decimal price, bool lounge)
            : base(movie, price)
        {
            LoungeAccess = lounge;
        }

        public override string TicketType => "VIP";

        public override decimal CalculateFinalPrice()
        {
            return (Price + ServiceFee) * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
