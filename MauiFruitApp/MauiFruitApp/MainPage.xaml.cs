namespace MauiFruitApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnGoToPage2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2(EnterUserName.Text));
    }

    //private void BtnMoveToPage2_Clicked(object sender, EventArgs e)
    //{
    //    //Navigation.PushAsync(new Page2());
    //    Navigation.PushModalAsync(new Page2());
    //}
}

