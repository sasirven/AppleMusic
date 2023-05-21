

using Model;

namespace AppleMusic.Views.CustomViews;

public partial class PlayingMusicView : ContentView
{
    public Manager Manager => ((App)Application.Current!).MyManager;
    
    public PlayingMusicView()
    {
        InitializeComponent();
        BindingContext = Manager;
    }
}