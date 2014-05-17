using System.ComponentModel;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaPart : ContentPart<OgMetaRecord>
    {
        [DisplayName("Title")]
        public string Title
        {
            get { return Retrieve(t => t.Title); }
            set { Store(t => t.Title, value); }
        }

        [DisplayName("Type")]
        public string Type
        {
            get { return Retrieve(t => t.Type); }
            set { Store(t => t.Type, value); }
        }

        [DisplayName("Url")]
        public string Url
        {
            get { return Retrieve(u => u.Url); }
            set { Store(u => u.Url, value); }
        }

        [DisplayName("Image Url")]
        public string ImgUrl
        {
            get { return Retrieve(u => u.ImgUrl); }
            set { Store(u => u.ImgUrl, value); }
        }

        [DisplayName("Description")]
        public string Description
        {
            get { return Retrieve(d => d.Description); }
            set { Store(d => d.Description, value); }
        }

        [DisplayName("Site Name")]
        public string SiteName
        {
            get { return Retrieve(s => s.SiteName); }
            set { Store(s => s.SiteName, value); }
        }
    }
}