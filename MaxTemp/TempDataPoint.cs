using System;

namespace MaxTemp
{
    public class TempDataPoint
    {
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Value { get; set; }

        public TempDataPoint(string location, DateTime date, string value)
        {
            Location = location;
            Date = date;
            Value = value;
        }
    }
}