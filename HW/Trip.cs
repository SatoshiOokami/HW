using System;

namespace HW
{
    public class Trip
    {
        public int TripID { get; set; }
        public string Employee { get; set; }
        public string Purpose { get; set; }
        public string Destination { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
