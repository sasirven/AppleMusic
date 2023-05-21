using Model;


namespace AppleMusic.Views.Pages;

public partial class AlbumPage : ContentPage
{
    public Album? Album { get; set; }
 
    public AlbumPage(Album? album)
    {
        InitializeComponent();
        Album = album;
        BindingContext = Album;
    }
}