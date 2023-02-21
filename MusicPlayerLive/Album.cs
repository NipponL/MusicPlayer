using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerLive
{
    internal class Album: MediaCollection
    {
        public string Artist { get; set; }
        public int ReleaseYear { get; set; }

        public Album(string title, string artist, int releaseYear) : base(title)
        {
            Artist = artist;
            ReleaseYear = releaseYear;
        }
        public override string GetInfo()
        {

            string erg = "";
            erg += "\n* "+this.Title + " by " + this.Artist + " (Year: " + this.ReleaseYear + "):\n";
            foreach (Song song in Songs)
            {
                erg += song + "\n";
            }
            erg += "Album-Length: " + this.Length() + "\n";
            return erg;
        }

    }
}
