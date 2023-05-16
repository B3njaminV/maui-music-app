namespace AppleMusicApp.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(Music music)
	{
		InitializeComponent();
        BindingContext = music;
    }

    private void OnPlayClicked(object sender, EventArgs e)
    {
    }

    private void OnShuffleClicked(object sender, EventArgs e)
    {
    }

}