namespace MauiFruitApp;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void BtnNavigateBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}