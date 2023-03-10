namespace MauiFruitApp;

public partial class FruitDetail : ContentPage
{
    public FruitDetail(Fruit fruit)
    {
        InitializeComponent();
        ImgFruit.Source = fruit.ImageName;
        FruitName.Text = fruit.Name;
        FruitSentence.Text = fruit.Sentence;
    }



    //public FruitDetail(Fruit fruit)
    //{
    //    InitializeComponent();
    //}

    //public FruitDetail(string selectedItemName, string selectedItemImageName, string selectedItemSentence)
    //{
    //    InitializeComponent();
    //}
}