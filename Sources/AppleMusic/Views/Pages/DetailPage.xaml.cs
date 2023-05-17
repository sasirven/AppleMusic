using Model;


namespace AppleMusic.Views.Pages;

public partial class DetailPage : ContentPage
{
    public Manager Manager => ((App)Application.Current!).MyManager;
    public Album CurrentAlbum => Manager.Albums.First();
    
    public DetailPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}