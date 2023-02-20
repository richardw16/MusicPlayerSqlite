using MusicPlayerLive;
using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Data Source=..\..\..\music_library.db";
        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            Dictionary<int, Album> albums = new Dictionary<int, Album>();

            // TODO: 1. commit "Alben aus der DB lesen und im Dictionary speichern"

            // TODO: 2. commit: "Alle Songs abrufen und den Alben zuweisen"
            // HINWEIS:
            // Song song = new Song(songId, title, artist, duration);
            // albums[albumId].AddSong(song);

            // TODO: 3. commit: "Alle PlayLists aus DB lesen und die Songs zuweisen"
            List<PlayList> playlists = new List<PlayList>();
            // HINWEIS: du kannst du category aus der DB mit "Enum.Parse" parsen: https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-7.0

            MusicPlayer player = new MusicPlayer();
            foreach (Album album in albums.Values)
            {
                player.AddAlbum(album);
            }
            foreach (PlayList playlist in playlists)
            {
                player.AddPlayList(playlist);
            }

            Console.WriteLine(player);
        }
    }

    // Hilfsmethode zum Suchen eines Songs anhand der ID
    static Song FindSongById(int id, Dictionary<int, Album> albums)
    {
        foreach (Album album in albums.Values)
        {
            foreach (Song song in album.Songs)
            {
                if (song.Id == id)
                {
                    return song;
                }
            }
        }
        return null;
    }
}




