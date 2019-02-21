using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core.Search
{
    public interface SearchResult
    {
        /// <summary>
        /// Get the title of the search result
        /// </summary>
        /// <returns>string with the text for the title of the search result</returns>
        string GetTitleText();

        /// <summary>
        /// Get the description of the search result
        /// </summary>
        /// <returns>Description of the search result</returns>
        string GetDescriptionText();

        /// <summary>
        /// Get the image for the search result
        /// </summary>
        /// <returns>String with the URI</returns>
        string GetImageURI();

        /// <summary>
        /// Get the track's ID
        /// </summary>
        /// <returns></returns>
        CID GetID();

    }
}
