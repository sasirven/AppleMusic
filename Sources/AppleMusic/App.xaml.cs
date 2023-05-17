using AppleMusic.Views.CustomViews;
using Model;
using StubLib;

namespace AppleMusic;

public partial class App : Application
{
	public Manager MyManager { get; } = new(new Stub());
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
