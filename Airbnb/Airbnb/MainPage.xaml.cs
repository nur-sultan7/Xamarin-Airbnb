using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Airbnb
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            var service = new SearchService();
            listview.ItemsSource = new List<SearchGroup>
            { 
                service.searchesGroups
            };
            
            
        }
    }
}
