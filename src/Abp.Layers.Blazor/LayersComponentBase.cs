using Abp.Layers.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Abp.Layers.Blazor;

public abstract class LayersComponentBase : AbpComponentBase
{
    protected LayersComponentBase()
    {
        LocalizationResource = typeof(LayersResource);
    }
}
