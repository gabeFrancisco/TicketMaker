using System.Collections.Generic;

namespace TicketMaker.Web.Models
{
    public class TicketIssuer
    {
        public int TicketQuantity { get; set; }
        public int TicketNumbers { get; set; }
        public bool IsOrdered { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public Queue<int> TotalTickets { get; set; } = new Queue<int>();
    }
}