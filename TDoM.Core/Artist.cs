using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core
{
    public class Artist
    {
        /// <summary>
        /// Name of the Artist
        /// </summary>
        public string Name;
        /// <summary>
        /// When the artist was born
        /// </summary>
        public DateTime OriginTime;
        /// <summary>
        /// Where the artist originated
        /// </summary>
        public string OriginPlace;

        /// <summary>
        /// General Roles of the artist/band
        /// </summary>
        public Role[] Roles;

        /// <summary>
        /// When the artist died. Should be DateTime.MinValue if artist is still alive 
        /// </summary>
        public DateTime Deceased;

        /// <summary>
        /// Returns if the artist is deceased.
        /// </summary>
        public bool IsDeceased
        {
            get
            {
                return Deceased == DateTime.MinValue;
            }
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
        /// Compares this Artist's id with another to check if they are the same artist
        /// </summary>
        /// <param name="a">Other artists</param>
        /// <returns>False if artist ids are not the same</returns>
        public bool IsSameArtist(Artist a)
        {
            return this.ITunesID == a.ITunesID || this.AMGID == a.AMGID;
        }
    }
}
