using Model;

namespace AppleMusic.Views.CustomViews.AlbumDetail;

public partial class AlbumHeaderView : ContentView
{
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
}