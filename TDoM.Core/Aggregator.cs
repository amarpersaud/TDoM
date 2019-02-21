using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TDoM.Core.Search;

using YoutubeExplode;
using YoutubeExplode.Models;
namespace TDoM.Core
{
    public class Aggregator
    {
        public YoutubeClient YTClient;

        public Aggregator()
        {
            YTClient = new YoutubeClient();
        }

        public async void SearchFor(MediaType type, string query)
        {
            //Hit cache first, then search in appropriate places.

            if (type.HasFlag(MediaType.Track))
            {

            }
            if (type.HasFlag(MediaType.Album))
            {

            }
            if (type.HasFlag(MediaType.Track))
            {

            }

            var youtubeResults = await YTClient.SearchVideosAsync(query);
        }


        /// <summary>
        /// Get track based on the ID.
        /// </summary>
        /// <param name="id">ID of the track (Itunes, AMG, TDoM, etc)</param>
        /// <returns>Track with appropriate metadata</returns>
        public static Track GetTrack(CID id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get an artist based on the ID.
        /// </summary>
        /// <param name="id">ID of the artist (Itunes, AMG, TDoM, etc)</param>
        /// <returns>Artist with appropriate metadata</returns>
        public static Artist GetArtist(CID id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get an album or collection based on the ID.
        /// </summary>
        /// <param name="id">ID of the album or collection (Itunes, AMG, TDoM, etc)</param>
        /// <returns>Album with appropriate metadata</returns>
        public static Album GetAlbum(CID id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
    }
}
