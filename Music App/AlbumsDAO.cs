using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    internal class AlbumsDAO
    {
        // Connection string for connecting to MySQL database
        String connectionString = "datasource=localhost;port=3306;username=root;password=;database=music;";

        // Method to retrieve all albums from the database
        public List<Album> getAllAlbums()
        {
            // Start with an empty list
            List<Album> returnThese = new List<Album>();

            // Connect to MySQL
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SQL statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Create an Album object for each record retrieved
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };

                    // Retrieve tracks for the album
                    a.Tracks = getTracksForAlbum(a.ID);
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        // Method to search for albums by title
        public List<Album> searchTitles(String searchTerm)
        {
            // Start with an empty list
            List<Album> returnThese = new List<Album>();

            // Connect to MySQL
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create wildcard phrase for searching
            String searchWildPhrase = "%" + searchTerm + "%";

            // Define the SQL statement to search for albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, ALBUM, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS WHERE ALBUM LIKE @search";
            command.Parameters.AddWithValue("search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Create an Album object for each record retrieved
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        // Method to add a new album to the database
        internal int addOneAlbum(Album album)
        {
            // Connect to MySQL
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SQL statement to insert a new album
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@album,@artist,@year,@imageURL,@description)", connection);

            // Add parameters to the SQL statement
            command.Parameters.AddWithValue("@album", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            // Execute the SQL command and return the number of affected rows
            int newRows = command.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }

        // Method to retrieve tracks for a given album ID
        public List<Track> getTracksForAlbum(int albumID)
        {
            // Start with an empty list
            List<Track> returnThese = new List<Track>();

            // Connect to MySQL
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SQL statement to fetch tracks for the album
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Create a Track object for each record retrieved
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();

            return returnThese;
        }

        // Method to retrieve tracks for a given album ID using a join query
        public List<JObject> getTracksUsingJoin(int albumID)
        {
            // Start with an empty list
            List<JObject> returnThese = new List<JObject>();

            // Connect to MySQL
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SQL statement to fetch tracks for the album using a join query
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT tracks.ID as trackID, albums.ALBUM `track_title`, `video_url`, `lyrics` FROM `tracks` JOIN albums ON albums_ID = albums.ID WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Create a JObject for each record retrieved
                    JObject newTrack = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    returnThese.Add(newTrack);
                }
            }
            connection.Close();

            return returnThese;
        }

        // Method to delete a track from the database
        internal int deleteTrack(int trackID)
        {
            // Connect to MySQL
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the SQL statement to delete a track
            MySqlCommand command = new MySqlCommand("DELETE FROM `tracks` WHERE `tracks`.`ID` = @trackID;", connection);

            command.Parameters.AddWithValue("trackID", trackID);

            // Execute the SQL command and return the result
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
