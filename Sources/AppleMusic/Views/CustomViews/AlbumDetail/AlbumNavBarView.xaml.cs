
namespace AppleMusic.Views.CustomViews.AlbumDetail;

public partial class AlbumNavBarView : ContentView
{
    public string AlbumName
    {
        get => (string)GetValue(AlbumNameProperty);
        set => SetValue(AlbumNameProperty, value);
    }
    public static readonly BindableProperty AlbumNameProperty =
        BindableProperty.Create(nameof(AlbumName), typeof(string), typeof(AlbumNavBarView), string.Empty, BindingMode.OneTime);
    
    public AlbumNavBarView()
    {
        InitializeComponent();
    }

    private void ImageButton_Clicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}