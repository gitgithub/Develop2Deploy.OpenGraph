using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaRecord : ContentPartRecord
    {
        [DataType(DataType.Text)]
        public virtual string Title { get; set; }

        [DataType(DataType.Text)]
        public virtual string Type { get; set; }

        [DataType(DataType.Url)]
        public virtual string Url { get; set; }

        [DataType(DataType.ImageUrl)]
        public virtual string ImgUrl { get; set; }

        [DataType(DataType.Text)]
        public virtual string Description { get; set; }

        [DataType(DataType.Text)]
        public virtual string SiteName { get; set; }
    }
}