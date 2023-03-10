namespace MauiFruitApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        // For when we are not using PushAsync (for example ModalAsync) Also Default Maui behavior.
        //MainPage = new AppShell(); 

        // For when we are using PushAsync
        MainPage = new NavigationPage(new AppShell());
    }
}
