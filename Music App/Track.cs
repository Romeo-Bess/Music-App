namespace Music_App
{
    internal class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string VideoURL { get; set; }
        public String Lyrics { get; set; }

        //make a list<Track> songs
        public List<Track> Tracks { get; set;}
    }
}