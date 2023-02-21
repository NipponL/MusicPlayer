using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerLive
{
    internal abstract class MediaCollection
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }

        public MediaCollection(string title)
        {
            Title = title;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(string songTitle)
        {
            Songs.RemoveAll(x => x.Title == songTitle);
        }
        public SongLength Length()
        {
            int lengthInSeconds = 0;
            foreach (var song in Songs)
            {
                lengthInSeconds += song.Length.Seconds;
            }
            return new SongLength(lengthInSeconds);
        }
        public abstract string GetInfo();
    }
}
