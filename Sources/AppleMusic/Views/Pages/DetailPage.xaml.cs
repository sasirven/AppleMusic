using Model;


namespace AppleMusic.Views.Pages;

public partial class DetailPage : ContentPage
{
    public static Manager Manager => ((App)Application.Current!).MyManager;
    public static Album CurrentAlbum => Manager.Albums.First();
    
    public DetailPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}