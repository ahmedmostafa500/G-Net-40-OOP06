using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop06
{
    internal static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket ticket)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("========== RECEIPT ==========");
            sb.AppendLine($"  Movie    : {ticket.MovieName}");
            sb.AppendLine($"  Type     : {ticket.TicketType}");
            sb.AppendLine($"  Price    : {ticket.Price}");
            sb.AppendLine($"  Final    : {ticket.CalculateFinalPrice():F2}");
            sb.AppendLine($"  Status   : {(ticket.IsBooked ? "Booked" : "Not Booked")}");
            sb.AppendLine("=============================");

            return sb.ToString();
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (var t in tickets)
            {
                if (t != null)
                    total += t.CalculateFinalPrice();
            }

            return total;
        }
    }
}
