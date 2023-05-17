

using Model;

namespace AppleMusic.Views.CustomViews;

public partial class ImageTitleView : ContentView
{
    public Album Album
    {
        get => (Album)GetValue(AlbumProperty);
        set => SetValue(AlbumProperty, value);
    }

    public static readonly BindableProperty AlbumProperty =
        BindableProperty.Create(nameof(Album), typeof(Album), typeof(ImageTitleView), null, BindingMode.OneTime);
    
    public ImageTitleView()
    {
        InitializeComponent();
        BindingContext = Album;
    }
}