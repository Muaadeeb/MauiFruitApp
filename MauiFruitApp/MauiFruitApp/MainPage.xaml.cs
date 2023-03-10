namespace MauiFruitApp;

public partial class MainPage : ContentPage
{
    private readonly List<Fruit> fruits = new List<Fruit>()
    {
        new Fruit(){Name = "Apple", ImageName = "apple.png", Sentence = "My Mom's apple pie is the best.  Have you tried it?"},
        new Fruit(){Name = "Apricot", ImageName = "apricot.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Banana", ImageName = "banana.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Coconut", ImageName = "coconut.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Grape", ImageName = "grape.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Guava", ImageName = "guava.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Kiwi", ImageName = "kiwi.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Mango", ImageName = "mango.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Melon", ImageName = "melon.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Orange", ImageName = "orange.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Peach", ImageName = "peach.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Pear", ImageName = "pear.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Pineapple", ImageName = "pineapple.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Plum", ImageName = "plum.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Pomegranate", ImageName = "pomegranate.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Strawberry", ImageName = "strawberry.png", Sentence = "Some cool phrase."},
        new Fruit(){Name = "Watermelon", ImageName = "watermelon.png", Sentence = "Some cool phrase."}
    };


	public MainPage()
	{
		InitializeComponent();
        Fruits.ItemsSource = fruits;
	}

    private void Fruits_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selecteditem = e.SelectedItem as Fruit;
        if (selecteditem == null) return;
        Navigation.PushAsync(new FruitDetail(selecteditem));
        ((ListView)sender).SelectedItem = null;
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

