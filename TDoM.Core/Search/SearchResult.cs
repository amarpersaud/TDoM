using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core.Search
{
    public interface SearchResult
    {
        string GetTitleText();

        string GetDescriptionText();

        string GetImageURI();

        CID GetID();

    }
}
