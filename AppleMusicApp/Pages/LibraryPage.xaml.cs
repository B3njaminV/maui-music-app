using System.Collections.ObjectModel;

namespace AppleMusicApp.Pages;

public partial class LibraryPage : ContentPage
{

    public LibraryPage()
    {
        InitializeComponent();

        // Générer des données fictives de podcasts
        List<Music> podcasts = new List<Music>();

        for (int i = 1; i <= 10; i++)
        {
            string title = $"Podcast propriété {i}";
            string description = $"Description du podcast {i}";
            string imageUrl = $"podcast.jpg";
            string artist = $"Wayne Shorter";

            podcasts.Add(new Music { 
                Title = title, 
                Description = description, 
                ImageUrl = imageUrl, 
                Artist = artist, 
                Tracks = new List<string>
                {
                    "Titre du morceau 1 - Artiste 1",
                    "Titre du morceau 2 - Artiste 2",
                    "Titre du morceau 3 - Artiste 3",
                    "Titre du morceau 4 - Artiste 4",
                    "Titre du morceau 5 - Artiste 5",
                    "Titre du morceau 6 - Artiste 6",
                    "Titre du morceau 7 - Artiste 7",
                    "Titre du morceau 8 - Artiste 8"
                }
            });
        }

        musicsCollection.ItemsSource = podcasts;
    }

    private async void OnMusicSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Music selectedMusic)
        {
            await Navigation.PushAsync(new DetailPage(selectedMusic));
        }
    }

}
