using System.ComponentModel;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaPart : ContentPart<OgMetaRecord>
    {
        [DisplayName("Title")]
        public string OgTitle
        {
            get { return Retrieve(t => t.Title); }
            set { Store(t => t.Title, value); }
        }

        [DisplayName("Type")]
        public string OgType
        {
            get { return Retrieve(t => t.Type); }
            set { Store(t => t.Type, value); }
        }

        [DisplayName("Url")]
        public string OgUrl
        {
            get { return Retrieve(u => u.Url); }
            set { Store(u => u.Url, value); }
        }

        [DisplayName("Image Url")]
        public string OgImgUrl
        {
            get { return Retrieve(u => u.ImgUrl); }
            set { Store(u => u.ImgUrl, value); }
        }

        [DisplayName("Description")]
        public string OgDescription
        {
            get { return Retrieve(d => d.Description); }
            set { Store(d => d.Description, value); }
        }

        [DisplayName("Site Name")]
        public string OgSiteName
        {
            get { return Retrieve(s => s.SiteName); }
            set { Store(s => s.SiteName, value); }
        }
    }
}