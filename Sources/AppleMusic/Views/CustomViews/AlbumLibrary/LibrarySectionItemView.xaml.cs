

namespace AppleMusic.Views.CustomViews.AlbumLibrary;

public partial class LibrarySectionItemView : ContentView
{
    public string ImageSource
    {
        get => (string)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }
    public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(LibrarySectionItemView), null, BindingMode.OneTime);
    
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(LibrarySectionItemView), null, BindingMode.OneTime);
    
    public LibrarySectionItemView()
    {
        InitializeComponent();
    }
}