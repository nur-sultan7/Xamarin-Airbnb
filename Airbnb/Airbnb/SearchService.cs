using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Airbnb
{
    class SearchService
    {
        public SearchGroup searchesGroups { get; }
        
        public SearchService()
        {
            
            searchesGroups = new SearchGroup("Recent Searches")
            {
                new Search(0, "Santa Monica, CA, United States",
                                new DateTime(2021,10,1), new DateTime(2021,10,10)),
                new Search(1, "West Hollywood, CA, United States",
                                new DateTime(2021,10,1), new DateTime(2021,10,10)),
               
            };

            
        }
        public IEnumerable<Search> GetSearches(string filter=null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return searchesGroups;
            return searchesGroups.Where(c => c.Location.StartsWith(filter));
        }
        public void DeleteSearch(int searchId)
        {
            searchesGroups.Remove(searchesGroups.Where(c => c.Id == searchId).First());
        }
    }
}
