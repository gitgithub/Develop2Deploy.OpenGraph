using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Migrations
{
    [OrchardFeature("Develop2Deploy.TwitterDataCard")]
    public class TwitterDataCardMigration : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("TwitterDataRecord", table => table
                .ContentPartRecord()
                .Column<string>("TwitterCard", col => col.Unlimited())
                .Column<string>("TwitterSite", col => col.Unlimited())
                .Column<string>("TwitterTitle", col => col.Unlimited())
                .Column<string>("TwitterDesc", col => col.Unlimited())
                .Column<string>("Creator", col => col.Unlimited())
                .Column<string>("ImageUrl", col => col.Unlimited())
                );

            ContentDefinitionManager.AlterPartDefinition("TwitterDataPart", cfg => cfg
                .WithDescription("Twitter Data Card Meta Tags")
                .Attachable());

            return 1;
        }
    }
}