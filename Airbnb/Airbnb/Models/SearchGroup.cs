using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Airbnb
{
    public class SearchGroup : ObservableCollection<Search>
    {
        public string Title { get; }
       
       public SearchGroup(string searchGroupName)
        {
            Title = searchGroupName;
        }
    }
}
