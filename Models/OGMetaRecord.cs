using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaRecord : ContentPartRecord
    {
        [DataType(DataType.Text)]
        public virtual string OgTitle { get; set; }

        [DataType(DataType.Text)]
        public virtual string OgType { get; set; }

        [DataType(DataType.Url)]
        public virtual string OgUrl { get; set; }

        [DataType(DataType.ImageUrl)]
        public virtual string OgImgUrl { get; set; }

        [DataType(DataType.Text)]
        public virtual string OgDescription { get; set; }

        [DataType(DataType.Text)]
        public virtual string OgSiteName { get; set; }
    }
}