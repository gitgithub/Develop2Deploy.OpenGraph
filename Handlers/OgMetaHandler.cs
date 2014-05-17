using Develop2Deploy.OpenGraph.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Handlers
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaHandler : ContentHandler
    {
        public OgMetaHandler(IRepository<OgMetaRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}