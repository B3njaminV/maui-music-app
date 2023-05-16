﻿using System.Collections.ObjectModel;

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
            string title = $"Podcast {i}";
            string description = $"Description du podcast {i}";
            string imageUrl = $"podcast.jpg";
            string artist = $"Personne";

            podcasts.Add(new Music { Title = title, Description = description, ImageUrl = imageUrl, Artist = artist});
        }

        musicsCollection.ItemsSource = podcasts;
    }

    private async void OnMusicSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Music selectedMusic)
        {
            //await Navigation.PushAsync(new DetailPodcastPage(selectedPodcast));
        }
    }

}
