namespace MauiFruitApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnMoveToPage2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }
}

