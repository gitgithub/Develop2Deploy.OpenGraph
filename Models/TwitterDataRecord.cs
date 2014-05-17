using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement.Records;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.TwitterDataCard")]
    public class TwitterDataRecord : ContentPartRecord
    {
        [DataType(DataType.Text)]
        public virtual string TwitterCard { get; set; }

        [DataType(DataType.Text)]
        public virtual string TwitterSite { get; set; }

        [DataType(DataType.Text)]
        public virtual string TwitterTitle { get; set; }

        [DataType(DataType.Text)]
        public virtual string TwitterDesc { get; set; }

        [DataType(DataType.Text)]
        public virtual string Creator { get; set; }

        [DataType(DataType.ImageUrl)]
        public virtual string ImageUrl { get; set; }
    }
}