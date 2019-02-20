using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core
{
    public class Album
    {
        /// <summary>
        /// Artists that worked on the album. May have differing roles from
        /// </summary>
        public Artist[] AlbumArtists;

        /// <summary>
        /// Name of the album
        /// </summary>
        public string Name;

        /// <summary>
        /// Tracks on the album
        /// </summary>
        public Track[] Tracks;

        /// <summary>
        /// Release date of the album
        /// </summary>
        public DateTime Release;

        /// <summary>
        /// Total runtime of all tracks on the album
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetRuntime()
        {
            TimeSpan total = new TimeSpan();
            foreach(var t in Tracks)
            {
                total += t.Length;
            }
            return total;
        }

        /// <summary>
        /// If the track has a band
        /// </summary>
        /// <returns>false if the artists did not form a band, or there is a single artist</returns>
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
        /// <summary>
        /// Gets the band that created the album
        /// </summary>
        /// <returns>Band if there is a single band. Null if there is no band or made by a single artist.</returns>
        public Band GetBand()
        {
            foreach (Artist a in AlbumArtists)
            {
                if (a is Band)
                {
                    return (Band)a;
                }
            }
            //TODO: exeptions and logging
            return null;
        }
    }
}
