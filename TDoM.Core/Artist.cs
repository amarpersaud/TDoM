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
        /// General Roles of the artist
        /// </summary>
        public string Roles;

        /// <summary>
        /// Identifier for artist.
        /// </summary>
        CID id;
    }
}
