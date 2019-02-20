using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core
{
    public class Album
    {

        public Artist[] AlbumArtists;

        public string Name;
        public Track[] Tracks;

        public TimeSpan GetRuntime()
        {
            TimeSpan total = new TimeSpan();
            foreach(var t in Tracks)
            {
                total += t.Length;
            }
            return total;
        }

        public bool HasBand()
        {
            foreach(Artist b in AlbumArtists)
            {
                if(b is Band)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
