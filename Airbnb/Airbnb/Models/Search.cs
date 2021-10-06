using System;
using System.Collections.Generic;
using System.Text;

namespace Airbnb
{
   public class Search
    {

        public int Id { get; }
        public string Location { get; }
        DateTime CheckIn { get; }
        DateTime CheckOut { get; }

        public Search(int id , string location, DateTime checkIn, DateTime checkOut)
        {
            Id = id;
            Location = location;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
