using Develop2Deploy.OpenGraph.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Handlers
{
    [OrchardFeature("Develop2Deploy.TwitterDataCard")]
    public class TwitterDataHandler : ContentHandler
    {
        public TwitterDataHandler(IRepository<TwitterDataRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}