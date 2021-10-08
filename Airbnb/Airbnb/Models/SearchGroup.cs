using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Airbnb
{
    public class SearchGroup : ObservableCollection<Search>
    {
        public string Title { get; set; }

        public SearchGroup(string searchGroupName, IEnumerable<Search> searches) : base(searches)
        {
            Title = searchGroupName;
        }


    }
}
