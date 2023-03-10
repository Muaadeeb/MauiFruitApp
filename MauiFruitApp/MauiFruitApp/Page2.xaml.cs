namespace MauiFruitApp;

public partial class Page2 : ContentPage
{
	public Page2(string userName)
	{
        InitializeComponent();
        UserName.Text = userName;
	}

    //private void TapNavigateBack_Tapped(object sender, TappedEventArgs e)
    //{
    //    Navigation.PopModalAsync();
    //}

    //private void BtnNavigateBack_Clicked(object sender, EventArgs e)
    //{
    //    Navigation.PopAsync();
    //}
}