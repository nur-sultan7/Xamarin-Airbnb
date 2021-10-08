using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private List<SearchGroup> searchGroup;
        
        public SearchListExercise()
        {
            InitializeComponent();
            service = new SearchService();
            SetSearchGroup();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetSearchGroup(e.NewTextValue);
        }
        private void SetSearchGroup(string searchStr = null)
        {
            searchGroup = new List<SearchGroup> { new SearchGroup("Recent searches", service.GetSearches(searchStr)) };
            listview.ItemsSource = searchGroup;
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var searchObject =(Search) ((MenuItem)sender).CommandParameter;
            service.DeleteSearch(searchObject.Id);
            searchGroup[0].Remove(searchObject);
        }
    }
}