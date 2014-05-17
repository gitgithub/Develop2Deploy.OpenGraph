using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace Develop2Deploy.OpenGraph.Migrations
{
    [OrchardFeature("Develop2Deploy.OpenGraph")]
    public class OgMetaMigrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("OgMetaRecord",
                table => table
                    .ContentPartRecord()
                    .Column<string>("Title", column => column.Unlimited())
                    .Column<string>("Type", column => column.Unlimited())
                    .Column<string>("Url", column => column.Unlimited())
                    .Column<string>("ImgUrl", column => column.Unlimited())
                    .Column<string>("Description", column => column.Unlimited())
                    .Column<string>("SiteName", column => column.Unlimited())
                );

            ContentDefinitionManager.AlterPartDefinition("OgMetaPart",
                cfg => cfg
                    .WithDescription("Open Graph Meta Tags")
                    .Attachable());

            return 1;
        }
    }
}