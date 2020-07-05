using System;

namespace UniversalElectronicCard
{
    class Ticket
    {
        public DateTime Duration { get; set; }
        public int Cost { get; set; }

        public Ticket(DateTime duration, int cost)
        {
            Duration = duration;
            Cost = cost;
        }
    }
}
