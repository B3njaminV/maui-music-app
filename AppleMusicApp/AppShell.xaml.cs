namespace AppleMusicApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		CurrentItem = LibraryPanel;
		//OU
		//Shell.Current.GoToAsync("//LibraryPage");
	}
}

