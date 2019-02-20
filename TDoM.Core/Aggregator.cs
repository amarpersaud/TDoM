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

        public async void SearchFor(SearchType type, string query)
        {
            if (type.HasFlag(SearchType.Track))
            {

            }
            if (type.HasFlag(SearchType.Album))
            {

            }
            if (type.HasFlag(SearchType.Track))
            {

            }

            var youtubeResults = await YTClient.SearchVideosAsync(query);


        }


    }
}
