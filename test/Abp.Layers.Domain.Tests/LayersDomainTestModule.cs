using Abp.Layers.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Layers;

[DependsOn(
    typeof(LayersEntityFrameworkCoreTestModule)
    )]
public class LayersDomainTestModule : AbpModule
{

}
