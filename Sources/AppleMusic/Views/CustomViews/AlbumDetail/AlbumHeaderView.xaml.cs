using Model;

namespace AppleMusic.Views.CustomViews.AlbumDetail;

public partial class AlbumHeaderView : ContentView
{
    private static Manager Manager => ((App)Application.Current!).MyManager;
    public Album Album
    {
        get => (Album)GetValue(AlbumProperty);
        set => SetValue(AlbumProperty, value);
    }

    public static readonly BindableProperty AlbumProperty =
        BindableProperty.Create(nameof(Album), typeof(Album), typeof(AlbumHeaderView), null, BindingMode.OneTime);
    
    public AlbumHeaderView()
    {
        InitializeComponent();
    }

    private void Play_Button_OnClicked(object? sender, EventArgs e)
    {
        Manager.CurrentAlbum = Album;
        Manager.CurrentMusic = Album.Musics.FirstOrDefault();
    }

    private void Shuffle_Button_OnClicked(object? sender, EventArgs e)
    {
        var random = new Random();
        var index = random.Next(0, Album.Musics.Count);
        Manager.CurrentAlbum = Album;
        Manager.CurrentMusic = Album.Musics.ToList()[index];
    }
}