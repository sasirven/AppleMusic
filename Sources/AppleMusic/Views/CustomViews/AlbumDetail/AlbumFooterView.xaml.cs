using Model;

namespace AppleMusic.Views.CustomViews.AlbumDetail;

public partial class AlbumFooterView : ContentView
{
    
    public Album Album
    {
        get => (Album)GetValue(AlbumProperty);
        set => SetValue(AlbumProperty, value);
    }
    public static readonly BindableProperty AlbumProperty =
        BindableProperty.Create(nameof(Album), typeof(Album), typeof(AlbumFooterView), null, BindingMode.OneTime);
    
    public AlbumFooterView()
    {
        InitializeComponent();
    }
}