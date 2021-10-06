using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Airbnb
{
    class SearchService
    {
        SearchGroup searchesGroups;
        ObservableCollection<Search> searches; 
        public SearchService()
        {
            searches = new ObservableCollection<Search>
            {
                new Search(0, "Santa Monica, CA, United States",
                                new DateTime(2021,10,1), new DateTime(2021,10,10)),
                new Search(0, "Santa Monica, CA, United States 2",
                                new DateTime(2021,10,1), new DateTime(2021,10,10))

            };
            searchesGroups = new SearchGroup("SearchGroup", searches);
        }
        IEnumerable<Search> GetSearches(string filter=null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return searches;
            return searches.Where(c => c.Location.StartsWith(filter));
        }
        void DeleteSearch(int searchId)
        {
            searches.Remove(searches.Where(c => c.Id == searchId).First());
        }
    }
}
