using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    internal class Album
    {
        // Properties of the Album class
        public int ID { get; set; }             // Unique identifier for the album
        public String AlbumName { get; set; }   // Name of the album
        public String ArtistName { get; set; }  // Name of the artist
        public int Year { get; set; }           // Year of release
        public String ImageURL { get; set; }    // URL of the album cover image
        public String Description { get; set; } // Description of the album
        public List<Track> Tracks { get; internal set; } // List of tracks in the album
    }
}
