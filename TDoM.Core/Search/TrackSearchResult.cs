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

        public CID GetID()
        {
            return Track.ID;
        }
        public MediaType GetMediaType() => MediaType.Track;


        public string GetTitleText()
        {
            //TODO: Implement properly
            return Track.Name;
        }
        public string GetDescriptionText()
        {
            //TODO: Implement properly
            return Track.GetArtistName() + " - " + Track.Genre + " - " + Track.Length.ToString("h'h 'm'm 's's'");
        }
        public string GetImageURI()
        {
            return Aggregator.GetAlbum(Track.AlbumID).CoverArtURI;
        }
    }
}
