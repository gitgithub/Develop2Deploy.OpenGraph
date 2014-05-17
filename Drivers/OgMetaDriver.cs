using System;
using Develop2Deploy.OpenGraph.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment.Extensions;
using Orchard.UI.Resources;

namespace Develop2Deploy.OpenGraph.Drivers
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaDriver : ContentPartDriver<OgMetaPart>
    {
        private readonly IWorkContextAccessor _waContextAccessor;

        public OgMetaDriver(IWorkContextAccessor waContextAccessor)
        {
            _waContextAccessor = waContextAccessor;
        }

        protected override string Prefix
        {
            get { return "ogmeta"; }
        }

        protected override DriverResult Display(OgMetaPart part, string displayType, dynamic shapeHelper)
        {
            if (displayType != "Detail") return null;
            var resourceManager = _waContextAccessor.GetContext().Resolve<IResourceManager>();
            if (!String.IsNullOrWhiteSpace(part.OgTitle))
            {
                var ogTitle = new MetaEntry {Name = "ogtitle"};
                ogTitle.AddAttribute("property", "og:title");
                ogTitle.AddAttribute("content", part.OgTitle);
                resourceManager.SetMeta(ogTitle);
            }
            if (!String.IsNullOrWhiteSpace(part.OgType))
            {
                var ogType = new MetaEntry {Name = "ogtype"};
                ogType.AddAttribute("property", "og:type");
                ogType.AddAttribute("content", part.OgType);
                resourceManager.SetMeta(ogType);
            }
            if (!String.IsNullOrWhiteSpace(part.OgUrl))
            {
                var ogUrl = new MetaEntry {Name = "ogurl"};
                ogUrl.AddAttribute("property", "og:url");
                ogUrl.AddAttribute("content", part.OgUrl);
                resourceManager.SetMeta(ogUrl);
            }
            if (!String.IsNullOrWhiteSpace(part.OgImgUrl))
            {
                var ogImgUrl = new MetaEntry {Name = "ogimg"};
                ogImgUrl.AddAttribute("property", "og:image");
                ogImgUrl.AddAttribute("content", part.OgImgUrl);
                resourceManager.SetMeta(ogImgUrl);
            }
            if (!String.IsNullOrWhiteSpace(part.OgDescription))
            {
                var ogDesc = new MetaEntry {Name = "ogdesc"};
                ogDesc.AddAttribute("property", "og:description");
                ogDesc.AddAttribute("content", part.OgDescription);
                resourceManager.SetMeta(ogDesc);
            }
            if (!String.IsNullOrWhiteSpace(part.OgSiteName))
            {
                var ogSiteName = new MetaEntry {Name = "ogsitename"};
                ogSiteName.AddAttribute("property", "og:site_name");
                ogSiteName.AddAttribute("content", part.OgSiteName);
                resourceManager.SetMeta(ogSiteName);
            }
            return null;
        }

        protected override DriverResult Editor(OgMetaPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_OgMeta_Edit", () => shapeHelper.
                EditorTemplate(TemplateName: "Parts/OgMeta",
                    Model: part,
                    Prefix: Prefix));
        }

        protected override DriverResult Editor(OgMetaPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}