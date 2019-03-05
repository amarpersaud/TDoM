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
        public CID TrackID;

        public TrackSearchResult()
        {

        }

        public TrackSearchResult(CID t)
        {
            this.TrackID = t;
            TrackType = TrackType.Song;
        }

        public TrackSearchResult(CID t, TrackType tt)
        {
            this.TrackID = t;
            TrackType = tt;
        }

        /// <summary>
        /// Get the track's ID
        /// </summary>
        /// <returns>CID with the track's ID</returns>
        public CID GetID()
        {
            return TrackID;
        }

        /// <summary>
        /// Get the title of the search result
        /// </summary>
        /// <returns>string with the text for the title of the search result</returns>
        public string GetTitleText()
        {
            //TODO: Implement properly
            return Aggregator.GetTrack(TrackID).Name;
        }

        /// <summary>
        /// Get the description of the search result
        /// </summary>
        /// <returns>Description of the track, with the artist, genere, and length</returns>
        public string GetDescriptionText()
        {
            Track t = Aggregator.GetTrack(TrackID);
            //TODO: Implement properly
            return t.GetArtistName() + " - " + t.Genre + " - " + t.Length.ToString("h'h 'm'm 's's'");
        }

        /// <summary>
        /// Get the image for the search result
        /// </summary>
        /// <returns>String with the URI</returns>
        public string GetImageURI()
        {
            return Aggregator.GetAlbum(
                    Aggregator.GetTrack(TrackID).AlbumID
                ).CoverArtURI;
        }
    }
}
