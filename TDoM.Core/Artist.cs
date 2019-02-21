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
        /// Identifier for artist.
        /// </summary>
        CID id;

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
    }
}
