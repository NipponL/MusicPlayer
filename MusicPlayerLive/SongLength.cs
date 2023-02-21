using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerLive
{
    internal class SongLength
    {
        public int Seconds { get; set; }
        /// <summary>
        /// Create a new SongLength Object
        /// </summary>
        /// <param name="seconds">Length in Seconds</param>
        public SongLength(int seconds)
        {
            Seconds = seconds;
        }
        public override string ToString()
        {
            //238 -> 3:58
            return $"{Seconds / 60}:{Seconds % 60}";
        }
    }
}
