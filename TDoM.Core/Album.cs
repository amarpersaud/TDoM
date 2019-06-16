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
        public List<CID> AlbumArtists;

        /// <summary>
        /// ID of the album
        /// </summary>
        public CID ID;

        /// <summary>
        /// Name of the album
        /// </summary>
        public string Name;

        /// <summary>
        /// IDs of the tracks on the album
        /// </summary>
        public CID[] Tracks;

        /// <summary>
        /// Release date of the album
        /// </summary>
        public DateTime Release;

        /// <summary>
        /// URI for the album's cover art
        /// </summary>
        public string CoverArtURI;

        /// <summary>
        /// URI for sources that have the audio or tracks for this album.
        /// May be Youtube videos or soundcloud links
        /// </summary>
        public string[] EquivalentSourceURI;

        /// <summary>
        /// Total runtime of all tracks on the album
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetRuntime()
        {
            TimeSpan total = new TimeSpan();
            foreach(var t in Tracks)
            {
                total += Aggregator.GetTrack(t).Length;
            }
            return total;
        }

        /// <summary>
        /// If the track has a band
        /// </summary>
        /// <returns>false if the artists did not form a band, or there is a single artist</returns>
        public bool HasBand()
        {
            foreach(CID b in AlbumArtists)
            {
                if(Aggregator.GetArtist(b) is Band)
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
            foreach (CID a in AlbumArtists)
            {
                if (Aggregator.GetArtist(a) is Band)
                {
                    return (Band)Aggregator.GetArtist(a);
                }
            }
            //TODO: exeptions and logging
            return null;
        }
    }
}
