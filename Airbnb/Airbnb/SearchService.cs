using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Airbnb
{
    public class SearchService
    {
        private List<Search> searches;
        public SearchService()
        {
            searches = new List<Search>()
            {
                new Search(0, "Santa Monica, CA, United States",
                                new DateTime(2021,10, 1), new DateTime(2021,10,10)),
                new Search(1, "West Hollywood, CA, United States",
                                new DateTime(2021,10, 1), new DateTime(2021,10,10))
            };
        }

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return searches;
            return searches.Where(c => c.Location.StartsWith(filter,StringComparison.OrdinalIgnoreCase));
        }
        public void DeleteSearch(int searchId)
        {
            searches.Remove(searches.Where(c => c.Id == searchId).First());
        }
    }
}
