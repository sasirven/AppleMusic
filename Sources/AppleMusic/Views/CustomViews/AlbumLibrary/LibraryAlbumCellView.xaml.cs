
using AppleMusic.Views.Pages;
using Model;

namespace AppleMusic.Views.CustomViews.AlbumLibrary;

public partial class LibraryAlbumCellView : ContentView
{
    public LibraryAlbumCellView()
    {
        InitializeComponent();
    }

    private async void GoToAlbum(object? sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AlbumPage(BindingContext as Album));
    }
}