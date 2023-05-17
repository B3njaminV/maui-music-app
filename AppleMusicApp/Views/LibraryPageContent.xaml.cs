namespace AppleMusicApp.Views;

public partial class LibraryPageContent : ContentView
{
    public LibraryPageContent()
    {
        InitializeComponent();

    }

    public string ImageLPC {
        get => "";
        set
        {
           image.Source = value;
        }
    }

    public string LabelLPC
    {
        get => "";
        set
        {
            label.Text = value;
        }
    }
    
}
