using System;
using System.Collections.Generic;
using System.Text;

namespace Airbnb
{
   public class Search
    {

        public int Id { get; }
        public string Location { get; }
        private DateTime CheckIn { get; }
        private DateTime CheckOut { get; }

        public string CheckInAndOutString => $"{CheckIn:MMM d, yyyy} - {CheckOut:MMM d, yyyy}";
        public Search(int id , string location, DateTime checkIn, DateTime checkOut)
        {
            Id = id;
            Location = location;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
