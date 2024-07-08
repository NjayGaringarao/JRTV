using CommunityToolkit.Maui.Views;
using JRTV.Models;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

namespace JRTV.Templates;

public partial class CountryPopup : Popup
{
    public ObservableCollection<Country> Countries { get; set; }

    public CountryPopup()
    {
        InitializeComponent();
        Countries = new ObservableCollection<Country>
        {
                new Country { Name = "Philippines", ImageSource = "ph.png" },
                new Country {Name = "Japan", ImageSource = "jp.png"},
                new Country {Name = "South Korea", ImageSource = "sk.png"},
                new Country {Name = "United States of Amerika", ImageSource = "us.png"},
                new Country {Name = "United Kingdom", ImageSource = "uk.png"}
            };
        BindingContext = this;
    }

    private void OnCountrySelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            var selectedCountry = e.CurrentSelection[0] as Country;
            // Close the popup and pass the selected country as the result
            Close(selectedCountry);
        }
    }
}