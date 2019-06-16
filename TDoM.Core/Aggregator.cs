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
        List<SearchResult> SearchResults = new List<SearchResult>();

        public Aggregator()
        {
            YTClient = new YoutubeClient();
        }

        public async void SearchFor(MediaType type, string query)
        {
            List<SearchResult> results = new List<SearchResult>();


            //Search in appropriate places.

            if (type.HasFlag(MediaType.Track))
            {

            }
            if (type.HasFlag(MediaType.Album))
            {

            }
            if (type.HasFlag(MediaType.Playlist))
            {

            }

            var youtubeResults = await YTClient.SearchVideosAsync(query);

            foreach(Video vid in youtubeResults)
            {
                results.Add(new TrackSearchResult());

            }

            SearchResults = results;
        }


        /// <summary>
        /// Get track based on the ID.
        /// </summary>
        /// <param name="id">ID of the track (Itunes, AMG, TDoM, etc)</param>
        /// <returns>Track with appropriate metadata</returns>
        public static Track GetTrack(CID id)
        {
            //TODO: implement
            // Hit cache, then lookup if cache doesn't have it
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
            // Hit cache, then lookup if cache doesn't have it
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
            // Hit cache, then lookup if cache doesn't have it
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a playlist based on the ID. Will only hit TDoM ID because playlists are TDoM only.
        /// </summary>
        /// <param name="id">ID of the album or collection (TDoM)</param>
        /// <returns>Album with appropriate metadata</returns>
        public static Playlist GetPlaylist(CID id)
        {
            //TODO: implement
            // Hit cache, then lookup if cache doesn't have it
            throw new NotImplementedException();
        }
    }
}
