using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerLive
{
    internal class MusicPlayer
    {
        public List<Album> Albums { get; set; }
        public List<PlayList> PlayLists { get; set; }
        public MusicPlayer()
        {
            Albums = new List<Album>();
            PlayLists = new List<PlayList>();
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }
        public void AddPlayList(PlayList playList)
        {
            PlayLists.Add(playList);
        }
        public override string ToString()
        {
            string erg = "";
            erg+="Albums:\n";
            foreach (Album album in Albums)
            {
                erg+=album.GetInfo();
                
            }
            erg += "\n\nPlaylists:\n";
            foreach (PlayList album in PlayLists)
            {
                erg += album.GetInfo();
            }
            return erg;
        }

    }
}
