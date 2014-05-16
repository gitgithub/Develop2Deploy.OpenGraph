using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaPart : ContentPart<OgMetaRecord>
    {
        public string OgTitle
        {
            get { return Retrieve(t => t.OgTitle); }
            set { Store(t => t.OgTitle, value); }
        }

        public string OgType
        {
            get { return Retrieve(t => t.OgType); }
            set { Store(t => t.OgType, value); }
        }

        public string OgUrl
        {
            get { return Retrieve(u => u.OgUrl); }
            set { Store(u => u.OgUrl, value); }
        }

        public string OgImgUrl
        {
            get { return Retrieve(u => u.OgImgUrl); }
            set { Store(u => u.OgImgUrl, value); }
        }

        public string OgDescription
        {
            get { return Retrieve(d => d.OgDescription); }
            set { Store(d => d.OgDescription, value); }
        }

        public string OgSiteName
        {
            get { return Retrieve(s => s.OgSiteName); }
            set { Store(s => s.OgSiteName, value); }
        }
    }
}