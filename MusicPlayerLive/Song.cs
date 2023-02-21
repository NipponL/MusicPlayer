using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerLive
{
    internal class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public SongLength Length { get; set; }

        public Song(int id,string title, string artist, int length)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Length = new SongLength(length);
        }
        public override string ToString()
        {
            return $"  - {Title} by {Artist} ({Length})";
        }
    }
}
