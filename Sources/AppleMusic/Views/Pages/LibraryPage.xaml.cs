using Model;

namespace AppleMusic.Views.Pages;

public partial class LibraryPage : ContentPage
{
    public Manager Manager => ((App)Application.Current!).MyManager;

    public LibraryPage()
    {
        InitializeComponent();
        BindingContext = Manager;
    }
}