namespace projeto4;

public partial class sobre : ContentPage
{
	public sobre()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}