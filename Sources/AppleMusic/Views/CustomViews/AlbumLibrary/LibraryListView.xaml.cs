using Model;

namespace AppleMusic.Views.CustomViews.AlbumLibrary;

public partial class LibraryListView : ContentView
{

    public IReadOnlyCollection<Album> Albums
    {
        get => (IReadOnlyCollection<Album>)GetValue(AlbumsProperty);
        set => SetValue(AlbumsProperty, value);
    }
    public static readonly BindableProperty AlbumsProperty =
        BindableProperty.Create(nameof(Albums), typeof(IReadOnlyCollection<Album>), typeof(LibraryListView), null, BindingMode.OneTime);
    
    public LibraryListView()
    {
        InitializeComponent();
    }
}