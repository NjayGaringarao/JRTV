using CommunityToolkit.Maui.Core.Views;
using CommunityToolkit.Maui.Views;
using JRTV.Models;
using JRTV.Templates;

namespace JRTV.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void CountryButton_Clicked(object sender, EventArgs e)
    {
        CountryButton.IsEnabled = false;
        var popup = new CountryPopup();
        var result = await this.ShowPopupAsync(popup) as Country;
        if (result != null)
        {
            await DisplayAlert("Testing",$"Selected Country: {result.Name}", "Okay");
            CountryButton.IsEnabled = true;
        }
        CountryButton.IsEnabled = true;
    }
}