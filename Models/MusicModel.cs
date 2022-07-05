using System.Collections.Generic;

namespace NewApp.Models
{
    public class MusicModel
    {
        public List<SongAndArtistModel> Songs = new List<SongAndArtistModel>();
        public class SongAndArtistModel
        {
            public string Canzone { get; set; }
            public string Cantante { get; set; }
        }
    }
}
