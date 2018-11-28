using System;
using System.Collections.Generic;

namespace Fareast
{
    public interface IAnnoyIndex : IDisposable
    {
        int Dimension { get; }

        ulong Size { get; }

        IReadOnlyList<float> GetItemVector(ulong itemIndex);

        AnnoyIndexSearchResult GetNearest(
            IReadOnlyList<float> queryVector,
            uint nResult,
            int searchK,
            bool shouldIncludeDistance);

        AnnoyIndexSearchResult GetNearestToItem(
            ulong itemIndex,
            uint nResult,
            int searchK,
            bool shouldIncludeDistance);
    }
}
