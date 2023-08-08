using Abp.Layers.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Abp.Layers.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LayersEntityFrameworkCoreModule),
    typeof(LayersApplicationContractsModule)
    )]
public class LayersDbMigratorModule : AbpModule
{
}
