using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core
{
    public class CID
    {
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
        public bool IsSame(CID a)
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
