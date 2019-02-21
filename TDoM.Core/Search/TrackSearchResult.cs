using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core.Search
{
    public class TrackSearchResult: SearchResult
    {
        /// <summary>
        /// Type of track
        /// </summary>
        public TrackType TrackType;

        /// <summary>
        /// The underlying track
        /// </summary>
        public Track Track;

        /// <summary>
        /// Get the track's ID
        /// </summary>
        /// <returns>CID with the track's ID</returns>
        public CID GetID()
        {
            return Track.ID;
        }

        /// <summary>
        /// Get the title of the search result
        /// </summary>
        /// <returns>string with the text for the title of the search result</returns>
        public string GetTitleText()
        {
            //TODO: Implement properly
            return Track.Name;
        }

        /// <summary>
        /// Get the description of the search result
        /// </summary>
        /// <returns>Description of the track, with the artist, genere, and length</returns>
        public string GetDescriptionText()
        {
            //TODO: Implement properly
            return Track.GetArtistName() + " - " + Track.Genre + " - " + Track.Length.ToString("h'h 'm'm 's's'");
        }

        /// <summary>
        /// Get the image for the search result
        /// </summary>
        /// <returns>String with the URI</returns>
        public string GetImageURI()
        {
            return Aggregator.GetAlbum(Track.AlbumID).CoverArtURI;
        }
    }
}
