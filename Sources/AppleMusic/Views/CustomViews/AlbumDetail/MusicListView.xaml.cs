using Model;

namespace AppleMusic.Views.CustomViews.AlbumDetail;

public partial class MusicListView : ContentView
{
    private static Manager Manager => ((App)Application.Current!).MyManager;
    public Album Album
    {
        get => (Album)GetValue(AlbumProperty);
        set => SetValue(AlbumProperty, value);
    }
    public static readonly BindableProperty AlbumProperty =
        BindableProperty.Create(nameof(Album), typeof(Album), typeof(MusicListView), null, BindingMode.OneTime);
    
    public MusicListView()
    {
        InitializeComponent();
    }

    private void OnItemTapped(object? sender, ItemTappedEventArgs e)
    {
        Manager.CurrentAlbum = Album;
        Manager.CurrentMusic = e.Item as Music;
    }
}