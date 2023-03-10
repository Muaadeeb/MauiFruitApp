namespace MauiFruitApp;

public partial class MainPage : ContentPage
{
    private readonly List<string> fruits = new List<string>()
    {
        "Apple", "Banana", "Coconut", "Grape", "Guava", "Kiwi", "Mango", "Melon"
    };


	public MainPage()
	{
		InitializeComponent();
        Fruits.ItemsSource = fruits;
	}




    //private void BtnGoToPage2_Clicked(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new Page2(EnterUserName.Text));
    //}

    //private void BtnMoveToPage2_Clicked(object sender, EventArgs e)
    //{
    //    //Navigation.PushAsync(new Page2());
    //    Navigation.PushModalAsync(new Page2());
    //}
}

