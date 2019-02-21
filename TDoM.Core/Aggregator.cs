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


        public static Track GetTrack(CID id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
        public static Artist GetArtist(CID id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
        public static Album GetAlbum(CID id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
    }
}
