using System;
using Develop2Deploy.OpenGraph.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Environment.Extensions;
using Orchard.UI.Resources;

namespace Develop2Deploy.OpenGraph.Drivers
{
    [OrchardFeature("Develop2Deploy.TwitterDataCard")]
    public class TwitterDataDriver : ContentPartDriver<TwitterDataPart>
    {
        private readonly IWorkContextAccessor _workContextAccessor;

        public TwitterDataDriver(IWorkContextAccessor workContextAccessor)
        {
            _workContextAccessor = workContextAccessor;
        }

        protected override string Prefix
        {
            get { return "twitterdatacard"; }
        }

        protected override DriverResult Display(TwitterDataPart part, string displayType, dynamic shapeHelper)
        {
            if (displayType != "Detail") return null;
            var resourceManager = _workContextAccessor.GetContext().Resolve<IResourceManager>();
            if (!String.IsNullOrWhiteSpace(part.TwitterCard))
            {
                var cardData = new MetaEntry
                {
                    Name = "twitter:card",
                    Content = part.TwitterCard
                };
                resourceManager.SetMeta(cardData);
            }
            if (!String.IsNullOrWhiteSpace(part.TwitterSite))
            {
                var cardSite = new MetaEntry
                {
                    Name = "twitter:site",
                    Content = part.TwitterSite
                };
                resourceManager.SetMeta(cardSite);
            }
            if (!String.IsNullOrWhiteSpace(part.TwitterTitle))
            {
                var cardTitle = new MetaEntry
                {
                    Name = "twitter:title",
                    Content = part.TwitterTitle
                };
                resourceManager.SetMeta(cardTitle);
            }
            if (!String.IsNullOrWhiteSpace(part.TwitterDesc))
            {
                var cardDesc = new MetaEntry
                {
                    Name = "twitter:description",
                    Content = part.TwitterDesc
                };
                resourceManager.SetMeta(cardDesc);
            }
            if (!String.IsNullOrWhiteSpace(part.Creator))
            {
                var cardCreator = new MetaEntry
                {
                    Name = "twitter:creator",
                    Content = part.Creator
                };
                resourceManager.SetMeta(cardCreator);
            }
            if (!String.IsNullOrWhiteSpace(part.ImageUrl))
            {
                var cardImageUrl = new MetaEntry
                {
                    Name = "twitter:image",
                    Content = part.ImageUrl
                };
                resourceManager.SetMeta(cardImageUrl);
            }
            return null;
        }

        protected override DriverResult Editor(TwitterDataPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_TwitterDataCard_Edit", () => shapeHelper.
                EditorTemplate(TemplateName: "Parts/TwitterDataCard",
                    Model: part,
                    Prefix: Prefix));
        }

        protected override DriverResult Editor(TwitterDataPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}