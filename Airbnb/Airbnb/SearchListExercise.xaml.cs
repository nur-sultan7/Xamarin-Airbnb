using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Airbnb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchListExercise : ContentPage
    {
        private SearchService service;
        public SearchListExercise()
        {
            InitializeComponent();
            service = new SearchService();

            listview.ItemsSource = GetSearchGroup();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetSearchGroup(e.NewTextValue);
        }
        private List<SearchGroup> GetSearchGroup(string searchStr = null)
        {
            return new List<SearchGroup> { new SearchGroup("Recent searches", service.GetSearches(searchStr)) };
        }
    }
}