using System.ComponentModel;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Models
{
    [OrchardFeature("Develop2Deploy.TwitterDataCard")]
    public class TwitterDataPart : ContentPart<TwitterDataRecord>
    {
        [DisplayName("Twitter Card")]
        public string TwitterCard
        {
            get { return Retrieve(c => c.TwitterCard); }
            set { Store(c => c.TwitterCard, value); }
        }

        [DisplayName("Twitter Site")]
        public string TwitterSite
        {
            get { return Retrieve(s => s.TwitterSite); }
            set { Store(s => s.TwitterSite, value); }
        }

        [DisplayName("Twitter Title")]
        public string TwitterTitle
        {
            get { return Retrieve(t => t.TwitterTitle); }
            set { Store(t => t.TwitterTitle, value); }
        }

        [DisplayName("Twitter Description")]
        public string TwitterDesc
        {
            get { return Retrieve(d => d.TwitterDesc); }
            set { Store(d => d.TwitterDesc, value); }
        }

        [DisplayName("Twitter Creator")]
        public string Creator
        {
            get { return Retrieve(c => c.Creator); }
            set { Store(c => c.Creator, value); }
        }

        [DisplayName("Image Url For Twitter")]
        public string ImageUrl
        {
            get { return Retrieve(i => i.ImageUrl); }
            set { Store(i => i.ImageUrl, value); }
        }
    }
}