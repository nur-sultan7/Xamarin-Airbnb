using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Airbnb
{
    public class SearchGroup : List<Search>
    {
        private string Name { get; set; }
        private ObservableCollection<Search> Searches { get; set; }
       public SearchGroup(string searchGroupName, ObservableCollection<Search> searches)
        {
            Name = searchGroupName;
            Searches = searches;
        }
    }
}
