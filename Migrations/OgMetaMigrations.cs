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
                    .Column<string>("OgTitle", column => column.Unlimited())
                    .Column<string>("OgType", column => column.Unlimited())
                    .Column<string>("OgUrl", column => column.Unlimited())
                    .Column<string>("OgImgUrl", column => column.Unlimited())
                    .Column<string>("OgDescription", column => column.Unlimited())
                    .Column<string>("OgSiteName", column => column.Unlimited())
                );

            ContentDefinitionManager.AlterPartDefinition("OgMetaPart", cfg => cfg.Attachable());

            return 1;
        }
    }
}