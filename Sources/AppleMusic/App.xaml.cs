using AppleMusic.Views.CustomViews;

namespace AppleMusic;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
