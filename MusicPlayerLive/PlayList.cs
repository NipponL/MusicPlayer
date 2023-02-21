using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerLive
{
    enum Category { Pop, Rock, Classical, Jazz, HipHop }
    internal class PlayList:MediaCollection
    {
        public Category Category { get; set; }

        public PlayList(string title, Category category) : base(title)
        {
            Category = category;
        }

        public void ShuffleSongs()
        {
            Random  rnd = new Random(Guid.NewGuid().GetHashCode());
            Songs.Sort((x,y) => rnd.Next(-1, 2));
        }

        public override string GetInfo()
        {

                string erg = "";
                erg+= "\n** "+this.Title+" ("+this.Category+"):\n";
                foreach (Song song in Songs)
                {
                    erg += song + "\n";
                }
            erg += "Playlist-Length: " + this.Length()+"\n";
            return erg;
        }


    }
}
