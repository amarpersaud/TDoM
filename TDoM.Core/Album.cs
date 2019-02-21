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
        public Dictionary<CID, Role[]> AlbumArtists;

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
            foreach(CID b in AlbumArtists.Keys)
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
            foreach (CID a in AlbumArtists.Keys)
            {
                if (Aggregator.GetArtist(a) is Band)
                {
                    return (Band)Aggregator.GetArtist(a);
                }
            }
            //TODO: exeptions and logging
            return null;
        }

        /// <summary>
        /// ITunes ID. For use in searching for artists or for checking identity
        /// </summary>
        public string ITunesID;

        /// <summary>
        /// All Media Guide (AMG) ID. For use in searching for artists or for checking identity
        /// </summary>
        public string AMGID;

        /// <summary>
        /// Custom TDoM ID. For use in searching for artists or for checking identity. 
        /// Mainly used in ensuring that artists not on ITunes or AMG still have an identifier.
        /// </summary>
        public string TDoMID;

        /// <summary>
        /// Compares this Artist's id with another to check if they are the same artist
        /// </summary>
        /// <param name="a">Other artists</param>
        /// <returns>False if artist ids are not the same</returns>
        public bool IsSameAlbum(Album a)
        {
            return SameID(this.ITunesID, a.ITunesID) ||
                   SameID(this.AMGID, a.AMGID) ||
                   SameID(this.TDoMID, a.TDoMID);
        }

        private bool SameID(string ida, string idb)
        {
            return ida == idb && ida != String.Empty;
        }
    }
}
