using Volo.Abp.Modularity;

namespace Abp.Layers;

[DependsOn(
    typeof(LayersApplicationModule),
    typeof(LayersDomainTestModule)
    )]
public class LayersApplicationTestModule : AbpModule
{

}
