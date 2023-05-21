using Model;

namespace AppleMusic.Views.CustomViews.AlbumDetail;

public partial class MusicListView : ContentView
{
    public IReadOnlyCollection<Music> Musics
    {
        get => (IReadOnlyCollection<Music>)GetValue(MusicsProperty);
        set => SetValue(MusicsProperty, value);
    }
    public static readonly BindableProperty MusicsProperty =
        BindableProperty.Create(nameof(Musics), typeof(IReadOnlyCollection<Music>), typeof(MusicListView), null, BindingMode.OneTime);
    
    public MusicListView()
    {
        InitializeComponent();
    }
}