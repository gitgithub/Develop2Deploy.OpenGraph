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
            if (!String.IsNullOrWhiteSpace(part.Title))
            {
                var ogTitle = new MetaEntry {Name = "ogtitle"};
                ogTitle.AddAttribute("property", "og:title");
                ogTitle.AddAttribute("content", part.Title);
                resourceManager.SetMeta(ogTitle);
            }
            if (!String.IsNullOrWhiteSpace(part.Type))
            {
                var ogType = new MetaEntry {Name = "ogtype"};
                ogType.AddAttribute("property", "og:type");
                ogType.AddAttribute("content", part.Type);
                resourceManager.SetMeta(ogType);
            }
            if (!String.IsNullOrWhiteSpace(part.Url))
            {
                var ogUrl = new MetaEntry {Name = "ogurl"};
                ogUrl.AddAttribute("property", "og:url");
                ogUrl.AddAttribute("content", part.Url);
                resourceManager.SetMeta(ogUrl);
            }
            if (!String.IsNullOrWhiteSpace(part.ImgUrl))
            {
                var ogImgUrl = new MetaEntry {Name = "ogimg"};
                ogImgUrl.AddAttribute("property", "og:image");
                ogImgUrl.AddAttribute("content", part.ImgUrl);
                resourceManager.SetMeta(ogImgUrl);
            }
            if (!String.IsNullOrWhiteSpace(part.Description))
            {
                var ogDesc = new MetaEntry {Name = "ogdesc"};
                ogDesc.AddAttribute("property", "og:description");
                ogDesc.AddAttribute("content", part.Description);
                resourceManager.SetMeta(ogDesc);
            }
            if (!String.IsNullOrWhiteSpace(part.SiteName))
            {
                var ogSiteName = new MetaEntry {Name = "ogsitename"};
                ogSiteName.AddAttribute("property", "og:site_name");
                ogSiteName.AddAttribute("content", part.SiteName);
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

        protected override void Exporting(OgMetaPart part, ExportContentContext context)
        {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Title", part.Record.Title);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Type", part.Record.Type);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Url", part.Record.Url);
            context.Element(part.PartDefinition.Name).SetAttributeValue("ImgUrl", part.Record.ImgUrl);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Description", part.Record.Description);
            context.Element(part.PartDefinition.Name).SetAttributeValue("SiteName", part.Record.SiteName);
        }

        protected override void Importing(OgMetaPart part, ImportContentContext context)
        {
            part.Record.Title = context.Attribute(part.PartDefinition.Name, "Title");
            part.Record.Type = context.Attribute(part.PartDefinition.Name, "Type");
            part.Record.Url = context.Attribute(part.PartDefinition.Name, "Url");
            part.Record.ImgUrl = context.Attribute(part.PartDefinition.Name, "ImgUrl");
            part.Record.Description = context.Attribute(part.PartDefinition.Name, "Description");
            part.Record.SiteName = context.Attribute(part.PartDefinition.Name, "SiteName");
        }
    }
}